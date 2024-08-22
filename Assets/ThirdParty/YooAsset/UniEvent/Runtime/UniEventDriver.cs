using System;
using UnityEngine;

namespace UniFramework.Event
{
	internal class UniEventDriver : MonoBehaviour
	{
		void Update()
		{
			UniEvent.Update();
		}

		private void OnDestroy()
		{
			UniEvent.Destroy();
		}
	}
}