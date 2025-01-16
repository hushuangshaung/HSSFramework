using System;
using System.Collections.Generic;
using UnityEngine;
using YooAsset;

namespace UniFramework.Pooling
{
	public class Spawner
	{
		private readonly Dictionary<string, GameObjectPool> _gameObjectPools = new(32);
		private readonly Dictionary<string, GameObjectPool> _removeList = new(32);
		
		private readonly GameObject _spawnerRoot;
		private readonly ResourcePackage _package;

		public string PackageName => _package.PackageName;

		internal Spawner(GameObject poolingRoot, ResourcePackage package)
		{
			_spawnerRoot = new GameObject($"{package.PackageName}");
			_spawnerRoot.transform.SetParent(poolingRoot.transform);
			_package = package;
		}

		/// <summary>
		/// 更新游戏对象池系统
		/// </summary>
		internal void Update()
		{
			_removeList.Clear();
			foreach (var pool in _gameObjectPools)
			{
				if (pool.Value.CanAutoDestroy())
				{				
					_removeList.Add(pool.Key, pool.Value);
				}
			}
			
			foreach (var pool in _removeList)
			{
				_gameObjectPools.Remove(pool.Key);
				pool.Value.DestroyPool();
			}
		}

		/// <summary>
		/// 销毁游戏对象池系统
		/// </summary>
		internal void Destroy()
		{
			DestroyAll(true);
		}

		/// <summary>
		/// 销毁对象对象池
		/// </summary>
		/// <param name="location"></param>
		public void Destroy(string location)
		{
			if (_gameObjectPools.ContainsKey(location))
			{
				var value = _gameObjectPools[location];
				value.DestroyPool();
				_gameObjectPools.Remove(location);
			}
		}

		/// <summary>
		/// 销毁所有对象池及其资源
		/// </summary>
		/// <param name="includeAll">销毁所有对象池，包括常驻对象池</param>
		public void DestroyAll(bool includeAll)
		{
			if (includeAll)
			{
				foreach (var pool in _gameObjectPools)
				{
					pool.Value.DestroyPool();
				}
				_gameObjectPools.Clear();
			}
			else
			{
				var removeList = new Dictionary<string, GameObjectPool>();
				foreach (var pool in _gameObjectPools)
				{
					if (pool.Value.DontDestroy == false)
						removeList.Add(pool.Key, pool.Value);
				}
				foreach (var pool in removeList)
				{
					_gameObjectPools.Remove(pool.Key);
					pool.Value.DestroyPool();
				}
			}
		}


		/// <summary>
		/// 异步创建指定资源的游戏对象池
		/// </summary>
		/// <param name="location">资源定位地址</param>
		/// <param name="dontDestroy">资源常驻不销毁</param>
		/// <param name="initCapacity">对象池的初始容量</param>
		/// <param name="maxCapacity">对象池的最大容量</param>
		/// <param name="destroyTime">静默销毁时间（注意：小于零代表不主动销毁）</param>
		public CreatePoolOperation CreateGameObjectPoolAsync(string location, bool dontDestroy = false, int initCapacity = 0, int maxCapacity = int.MaxValue, float destroyTime = -1f)
		{
			return CreateGameObjectPoolInternal(location, dontDestroy, initCapacity, maxCapacity, destroyTime);
		}

		/// <summary>
		/// 同步创建指定资源的游戏对象池
		/// </summary>
		/// <param name="location">资源定位地址</param>
		/// <param name="dontDestroy">资源常驻不销毁</param>
		/// <param name="initCapacity">对象池的初始容量</param>
		/// <param name="maxCapacity">对象池的最大容量</param>
		/// <param name="destroyTime">静默销毁时间（注意：小于零代表不主动销毁）</param>
		public CreatePoolOperation CreateGameObjectPoolSync(string location, bool dontDestroy = false, int initCapacity = 0, int maxCapacity = int.MaxValue, float destroyTime = -1f)
		{
			var operation = CreateGameObjectPoolInternal(location, dontDestroy, initCapacity, maxCapacity, destroyTime);
			operation.WaitForAsyncComplete();
			return operation;
		}

		/// <summary>
		/// 创建指定资源的游戏对象池
		/// </summary>
		private CreatePoolOperation CreateGameObjectPoolInternal(string location, bool dontDestroy = false, int initCapacity = 0, int maxCapacity = int.MaxValue, float destroyTime = -1f)
		{
			if (maxCapacity < initCapacity)
				throw new Exception("The max capacity value must be greater the init capacity value.");

			GameObjectPool pool = TryGetGameObjectPool(location);
			if (pool != null)
			{
				UniLogger.Warning($"GameObject pool is already existed : {location}");
				var operation = new CreatePoolOperation(pool.AssetHandle);
				YooAssets.StartOperation(operation);
				return operation;
			}
			else
			{
				pool = new GameObjectPool(_spawnerRoot, location, dontDestroy, initCapacity, maxCapacity, destroyTime);
				pool.CreatePool(_package);
				_gameObjectPools.Add(location, pool);

				var operation = new CreatePoolOperation(pool.AssetHandle);
				YooAssets.StartOperation(operation);
				return operation;
			}
		}


		/// <summary>
		/// 异步实例化一个游戏对象
		/// </summary>
		/// <param name="location">资源定位地址</param>
		/// <param name="scale">缩放</param>
		/// <param name="forceClone">强制克隆游戏对象，忽略缓存池里的对象</param>
		/// <param name="userDatas">用户自定义数据</param>
		public SpawnHandle SpawnAsync(string location, float scale = 1, bool forceClone = false, params System.Object[] userDatas)
		{
			return SpawnInternal(location, null, Vector3.zero, Quaternion.identity, forceClone, scale, userDatas);
		}

		/// <summary>
		/// 异步实例化一个游戏对象
		/// </summary>
		/// <param name="location">资源定位地址</param>
		/// <param name="parent">父物体</param>
		/// <param name="scale">缩放</param>
		/// <param name="forceClone">强制克隆游戏对象，忽略缓存池里的对象</param>
		/// <param name="userDatas">用户自定义数据</param>
		public SpawnHandle SpawnAsync(string location, Transform parent, float scale = 1, bool forceClone = false, params System.Object[] userDatas)
		{
			return SpawnInternal(location, parent, Vector3.zero, Quaternion.identity, forceClone, scale, userDatas);
		}

		/// <summary>
		/// 异步实例化一个游戏对象
		/// </summary>
		/// <param name="location">资源定位地址</param>
		/// <param name="parent">父物体</param>
		/// <param name="position">世界坐标</param>
		/// <param name="rotation">世界角度</param>
		/// <param name="scale">缩放</param>
		/// <param name="forceClone">强制克隆游戏对象，忽略缓存池里的对象</param>
		/// <param name="userDatas">用户自定义数据</param>
		public SpawnHandle SpawnAsync(string location, Transform parent, Vector3 position, Quaternion rotation, float scale = 1, bool forceClone = false, params System.Object[] userDatas)
		{
			return SpawnInternal(location, parent, position, rotation, forceClone, scale, userDatas);
		}

		// /// <summary>
		// /// 同步实例化一个游戏对象
		// /// </summary>
		// /// <param name="location">资源定位地址</param>
		// /// /// <param name="scale">缩放</param>
		// /// <param name="forceClone">强制克隆游戏对象，忽略缓存池里的对象</param>
		// /// <param name="userDatas">用户自定义数据</param>
		// public SpawnHandle SpawnSync(string location, float scale = 1f, bool forceClone = false, params System.Object[] userDatas)
		// {
		// 	SpawnHandle handle = SpawnInternal(location, null, Vector3.zero, Quaternion.identity, forceClone, scale, userDatas);
		// 	handle.WaitForAsyncComplete();
		// 	return handle;
		// }

		// /// <summary>
		// /// 同步实例化一个游戏对象
		// /// </summary>
		// /// <param name="location">资源定位地址</param>
		// /// <param name="parent">父物体</param>
		// /// /// <param name="scale">缩放</param>
		// /// <param name="forceClone">强制克隆游戏对象，忽略缓存池里的对象</param>
		// /// <param name="userDatas">用户自定义数据</param>
		// public SpawnHandle SpawnSync(string location, Transform parent, float scale = 1, bool forceClone = false, params System.Object[] userDatas)
		// {
		// 	SpawnHandle handle = SpawnInternal(location, parent, Vector3.zero, Quaternion.identity, forceClone, scale, userDatas);
		// 	handle.WaitForAsyncComplete();
		// 	return handle;
		// }

		// /// <summary>
		// /// 同步实例化一个游戏对象
		// /// </summary>
		// /// <param name="location">资源定位地址</param>
		// /// <param name="parent">父物体</param>
		// /// <param name="position">世界坐标</param>
		// /// <param name="rotation">世界角度</param>
		// /// <param name="scale">缩放</param>
		// /// <param name="forceClone">强制克隆游戏对象，忽略缓存池里的对象</param>
		// /// <param name="userDatas">用户自定义数据</param>
		// public SpawnHandle SpawnSync(string location, Transform parent, Vector3 position, Quaternion rotation, float scale = 1f, bool forceClone = false, params System.Object[] userDatas)
		// {
		// 	SpawnHandle handle = SpawnInternal(location, parent, position, rotation, forceClone, scale, userDatas);
		// 	handle.WaitForAsyncComplete();
		// 	return handle;
		// }

		/// <summary>
		/// 实例化一个游戏对象
		/// </summary>
		private SpawnHandle SpawnInternal(string location, Transform parent, Vector3 position, Quaternion rotation, bool forceClone, float scale = 1f, params System.Object[] userDatas)
		{
			var pool = TryGetGameObjectPool(location);
			if (pool != null)
			{
				return pool.Spawn(parent, position, rotation, forceClone, scale, userDatas);
			}

			// 如果不存在创建游戏对象池
			pool = new GameObjectPool(_spawnerRoot, location, false, 0, int.MaxValue, 10f);
			pool.CreatePool(_package);
			_gameObjectPools.Add(location, pool);
			return pool.Spawn(parent, position, rotation, forceClone, scale, userDatas);
		}


		private GameObjectPool TryGetGameObjectPool(string location)
		{
			if (_gameObjectPools.TryGetValue(location, out var value))
			{
				return value;
			}

			return null;
		}
	}
}