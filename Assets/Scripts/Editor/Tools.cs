using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class Tools
    {
        [MenuItem("Tools/StripAOTDll(第一次执行)", priority = -10000)]
        public static void StripAOTDllDllActiveBuildTarget()
        {
            var target = EditorUserBuildSettings.activeBuildTarget;
            HybridCLR.Editor.Commands.CompileDllCommand.CompileDll(target);
            
            StripAOTAssembly();
            
            AssetDatabase.Refresh();
        }
          
        /// <summary>
        /// 进一步剔除AOT dll中泛型函数元数据，输出到StrippedAOTAssembly2目录中
        /// </summary>
        private static void StripAOTAssembly()
        {
            BuildTarget target = EditorUserBuildSettings.activeBuildTarget;
            string srcDir =  HybridCLR.Editor.SettingsUtil.GetAssembliesPostIl2CppStripDir(target);
            string dstDir = $"{ HybridCLR.Editor.SettingsUtil.HybridCLRDataDir}/StrippedAOTAssembly2/{target}";
            Debug.LogError($"srcDir:{srcDir}  dstDir:{dstDir}");

            foreach (var dll in InitHelper.AotDllList)
            {
                var dllPath = $"{srcDir}/{dll}";
                var dstFile = $"{dstDir}/{dll}";
                HybridCLR.Editor.AOT.AOTAssemblyMetadataStripper.Strip(dllPath, dstFile);
            }
            // foreach (var src in Directory.GetFiles(srcDir, "*.dll"))
            // {
            //     string dllName = Path.GetFileName(src);
            //     string dstFile = $"{dstDir}/{dllName}";
            //     HybridCLR.Editor.AOT.AOTAssemblyMetadataStripper.Strip(src, dstFile);
            // }
        }

        [MenuItem("Tools/GenDll", priority = -9999)]
        public static void CompileDllActiveGenTarget()
        {
            var target = EditorUserBuildSettings.activeBuildTarget;
            HybridCLR.Editor.Commands.CompileDllCommand.CompileDll(target);
            
            CopyHotUpdateAssembliesToAOT();
            AssetDatabase.Refresh();
        }
        
        private static void CopyHotUpdateAssembliesToAOT()
        {
            var target = EditorUserBuildSettings.activeBuildTarget;
            var hotfixAotSrcDir = $"{ HybridCLR.Editor.SettingsUtil.HybridCLRDataDir}/StrippedAOTAssembly2/{target}";
            // var hotfixAotSrcDir = HybridCLR.Editor.SettingsUtil.GetAssembliesPostIl2CppStripDir(target);
            var aotAssembliesDstDir = $"{Application.dataPath}/GameRes/HotUpdateDLL/AOT";
            // foreach (var dll in HybridCLR.Editor.SettingsUtil.HotUpdateAssemblyFilesExcludePreserved)
            foreach (var dll in InitHelper.AotDllList)
            {
                var dllPath = $"{hotfixAotSrcDir}/{dll}";
                var dllBytesPath = $"{aotAssembliesDstDir}/{dll}.bytes";
                File.Copy(dllPath, dllBytesPath, true);
                Debug.Log($"[CopyHotUpdateAssembliesToStreamingAssets] copy aot dll {dllPath} -> {dllBytesPath}");
            }

            var hotfixDllSrcDir = HybridCLR.Editor.SettingsUtil.GetHotUpdateDllsOutputDirByTarget(target);
            var hotfixAssembliesDstDir = $"{Application.dataPath}/GameRes/HotUpdateDLL/DLL";
            foreach (var dll in InitHelper.HotUpdateDllList)
            {
                if (dll.StartsWith("Google.Protobuf.dll") || dll.StartsWith("System.Runtime.CompilerServices.Unsafe"))
                {
                    //System.Runtime.CompilerServices.Unsafe 先忽略，不知道为什么没有在：{hotfixDllSrcDir}。所以手动复制到：{dllBytesPath}
                    //Google.Protobuf.dll 先忽略，不知道为什么没有在：{hotfixDllSrcDir}。所以手动复制到：{dllBytesPath}
                    continue;
                }

                var dllPath = $"{hotfixDllSrcDir}/{dll}";
                var dllBytesPath = $"{hotfixAssembliesDstDir}/{dll}.bytes";
                File.Copy(dllPath, dllBytesPath, true);
                Debug.Log($"[CopyHotUpdateAssembliesToStreamingAssets] copy hotfix dll {dllPath} -> {dllBytesPath}");
            }
        }

        [MenuItem("Tools/GenConfig", priority = -9998)]
        public static void GenConfig()
        {
            var gentPath = $"{Application.dataPath}/../Config/Luban";
            var pStartInfo = new System.Diagnostics.ProcessStartInfo
            {
                WorkingDirectory = gentPath,
                FileName = "gen_json.bat"
            };
            var process = System.Diagnostics.Process.Start(pStartInfo);
            process?.WaitForExit();
            
            var pStartInfo2 = new System.Diagnostics.ProcessStartInfo
            {
                WorkingDirectory = gentPath,
                FileName = "gen_bin.bat"
            };
            var process2 = System.Diagnostics.Process.Start(pStartInfo2);
            process2?.WaitForExit();
            
            var bytesPath = $"{Application.dataPath}/..\\Config\\Bytes";
            var toPath1 = $"{Application.dataPath}/GameRes/HotUpdateResources/Config/Bytes";
            var toPath2 = $"{Application.dataPath}/GameRes/HotUpdateResources/Config/Language";
            //只需把bytes文件copy到对应的文件夹里即可，不合并bytes了
            if (Directory.Exists(bytesPath))
            {
                var files = Directory.GetFiles(bytesPath);
                foreach (var file in files)
                {
                    var index = file.LastIndexOf('\\');
                    var fileName = file.Substring(index + 1);
                    if (fileName.EndsWith(".bytes"))
                    {
                        if (fileName.StartsWith("languagetable"))
                        {
                            File.Copy(file, $"{toPath2}/{fileName}", true);
                            Debug.Log($"[GenConfig] copy config {file} -> {toPath2}/{fileName}");
                        }
                        else
                        {
                            File.Copy(file, $"{toPath1}/{fileName}", true);
                            Debug.Log($"[GenConfig] copy config {file} -> {toPath1}/{fileName}");
                        }
                    }
                }
            }
            AssetDatabase.Refresh();
        }

        [MenuItem("Tools/GenProtobuf", priority = -9997)]
        public static void GenProtobuf()
        {
            var gentPath = $"{Application.dataPath}/../Tools/Protobuf";
            var pStartInfo = new System.Diagnostics.ProcessStartInfo
            {
                WorkingDirectory = gentPath,
                FileName = "genproto.bat"
            };
            var process = System.Diagnostics.Process.Start(pStartInfo);
            process?.WaitForExit();
            AssetDatabase.Refresh();
        }
    }
}