#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace YIUIFramework.Editor
{
    internal static class YIUILoopScrollMenuItem
    {
        [MenuItem("GameObject/YIUI/LoopScroll/Horizontal", false, 10001)]
        private static void CreateLoopScrollHorizontal()
        {
            CreateLoopScroll("LoopScrollHorizontal");
        }

        [MenuItem("GameObject/YIUI/LoopScroll/Horizontal Reverse", false, 10002)]
        private static void CreateLoopScrollHorizontalReverse()
        {
            CreateLoopScroll("LoopScrollHorizontalReverse");
        }

        [MenuItem("GameObject/YIUI/LoopScroll/Horizontal Group", false, 10003)]
        private static void CreateLoopScrollHorizontalGroup()
        {
            CreateLoopScroll("LoopScrollHorizontalGroup");
        }
        
        [MenuItem("GameObject/YIUI/LoopScroll/Horizontal Multi", false, 10004)]
        private static void CreateLoopScrollHorizontalMulti()
        {
            CreateLoopScroll("LoopScrollHorizontalMulti");
        }

        [MenuItem("GameObject/YIUI/LoopScroll/Horizontal Reverse Multi", false, 10005)]
        private static void CreateLoopScrollHorizontalReverseMulti()
        {
            CreateLoopScroll("LoopScrollHorizontalReverseMulti");
        }

        // [MenuItem("GameObject/YIUI/LoopScroll/Horizontal Group Multi", false, 10006)]
        // private static void CreateLoopScrollHorizontalGroupMulti()
        // {
        //     CreateLoopScroll("LoopScrollHorizontalGroupMulti");
        // }

        [MenuItem("GameObject/YIUI/LoopScroll/Vertical", false, 10007)]
        private static void CreateLoopScrollVertical()
        {
            CreateLoopScroll("LoopScrollVertical");
        }

        [MenuItem("GameObject/YIUI/LoopScroll/Vertical Reverse", false, 10008)]
        private static void CreateLoopScrollVerticalReverse()
        {
            CreateLoopScroll("LoopScrollVerticalReverse");
        }

        [MenuItem("GameObject/YIUI/LoopScroll/Vertical Group", false, 10009)]
        private static void CreateLoopScrollVerticalGroup()
        {
            CreateLoopScroll("LoopScrollVerticalGroup");
        }
        
        [MenuItem("GameObject/YIUI/LoopScroll/Vertical Multi", false, 10010)]
        private static void CreateLoopScrollVerticalMulti()
        {
            CreateLoopScroll("LoopScrollVerticalMulti");
        }

        [MenuItem("GameObject/YIUI/LoopScroll/Vertical Reverse Multi", false, 10011)]
        private static void CreateLoopScrollVerticalReverseMulti()
        {
            CreateLoopScroll("LoopScrollVerticalReverseMulti");
        }

        // [MenuItem("GameObject/YIUI/LoopScroll/Vertical Group Multi", false, 10012)]
        // private static void CreateLoopScrollVerticalGroupMulti()
        // {
        //     CreateLoopScroll("LoopScrollVerticalGroupMulti");
        // }

        private static void CreateLoopScroll(string name)
        {
            var activeObject = Selection.activeObject as GameObject;
            if (activeObject == null)
            {
                UnityTipsHelper.ShowError($"请选择一个对象 右键创建");
                return;
            }

            var path = $"{UIStaticHelper.UIFrameworkPath}/Plugins/LoopScrollRect/YIUIEditor/TemplatePrefabs/{name}.prefab";

            Selection.activeObject = UIMenuItemHelper.CloneGameObjectByPath(path, activeObject.transform);
        }
    }
}
#endif