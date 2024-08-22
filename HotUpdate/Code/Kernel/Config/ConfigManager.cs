using System.Collections.Generic;
using System.Reflection;
using cfg;
using Luban;
using UnityEngine;
using YooAsset;

public class ConfigManager : Singleton<ConfigManager>
{
    private Tables _tables;
    public Tables CfgTables => _tables;
    
    private readonly Dictionary<string, AssetHandle> _assetHandles = new();
    private readonly Dictionary<string, byte[]> _bytes = new();
    
    public bool InitSuccess { get; private set; }
    
    public void InitConfig()
    {
        InitSuccess = false;
        var allTypes = Tables.GetAllTypes();
        foreach (var name in allTypes)
        {
            var handle = YooAssets.LoadAssetAsync<TextAsset>(name);
            _assetHandles.Add(name, handle);
            handle.Completed += Handheld_Completed;
        }
        //反射的方式获取（有消耗）
        // var properties = typeof(Tables).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        // foreach (var property in properties)
        // {
        //     var fullName = property.PropertyType.ToString();
        //     var name = fullName.Split('.')[1].ToLower();
        //     var handle = YooAssets.LoadAssetAsync<TextAsset>(name);
        //     _assetHandles.Add(name, handle);
        //     handle.Completed += Handheld_Completed;
        // }
    }
    
    private ByteBuf LoadByteBuf(string file)
    {
        var bytes = _bytes[file];
        return new ByteBuf(bytes);
    }

    private void Handheld_Completed(AssetHandle obj)
    {
        var textAsset = obj.AssetObject as TextAsset;
        var name = obj.AssetObject.name;
        var bytes = textAsset.bytes;
        _bytes[name] = bytes;
        _assetHandles[name].Release();
        _assetHandles.Remove(name);
        if (_assetHandles.Count == 0)
        {
            _tables = new Tables(LoadByteBuf);
            InitSuccess = true;
            _bytes.Clear();
        }
    }
}