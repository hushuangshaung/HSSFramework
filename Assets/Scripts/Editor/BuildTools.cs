using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using YIUIFramework.Editor;
using YooAsset;
using YooAsset.Editor;

/// <summary>
/// 打包助手
/// </summary>
public class BuildTools
{
    private static string _pkgPath = Application.dataPath + "/../Html";

    /// <summary>
    /// Jenkins里调用打包示例：WebGL
    /// </summary>
    public static void Build()
    {
        Debug.LogError("1.设置Jenkins传过来的参数");
        var args = Environment.GetCommandLineArgs();
        string version;
        string channel;
        bool stipAOT = false;
        foreach (var s in args)
        {
            if (s.Contains("--version"))
            {
                version = s.Split(':')[1];
                Debug.LogError($"version__:{version}");
                //设置版本号
                PlayerSettings.bundleVersion = version;
            }
            else if (s.Contains("--channel"))
            {
                channel = s.Split(':')[1];
                Debug.LogError($"channel__:{channel}");
            }
            else if (s.Contains("--stripAOT"))
            {
                stipAOT = (s.Split(':')[1]) == "true";
            }
        }
        Debug.LogError("2.YIUI自动生成绑定替代反射代码");
        UIPublishModule.CreateUIBindProvider();
        Debug.LogError("3.如有必要，剔除AOT");
        if (stipAOT)
        {
            Editor.Tools.StripAOTDllDllActiveBuildTarget();
        }

        Debug.LogError("Gen DLL");
        Editor.Tools.CompileDllActiveGenTarget();
        
        Debug.LogError("打包Bundle");
        BuildInternal(BuildTarget.WebGL);
        
        Debug.LogError("设置WebGL平台相关信息");
        // PlayerSettings.WebGL.template = $"PROJECT:{templateName}";
        PlayerSettings.WebGL.compressionFormat = WebGLCompressionFormat.Gzip;
        PlayerSettings.WebGL.initialMemorySize = 448;

        Debug.LogError("开始打包");
        var options = new BuildPlayerOptions();
        options.scenes = GetBuildScenes();
        options.locationPathName = _pkgPath;
        options.target = BuildTarget.WebGL;
        options.options = BuildOptions.None;

        BuildPipeline.BuildPlayer(options);
    }


    private static void BuildInternal(BuildTarget buildTarget)
    {
        Debug.Log($"开始构建 : {buildTarget}");

        var buildoutputRoot = AssetBundleBuilderHelper.GetDefaultBuildOutputRoot();
        var streamingAssetsRoot = AssetBundleBuilderHelper.GetStreamingAssetsRoot();

        // 构建参数
        BuiltinBuildParameters buildParameters = new BuiltinBuildParameters();
        buildParameters.BuildOutputRoot = buildoutputRoot;
        buildParameters.BuildinFileRoot = streamingAssetsRoot;
        buildParameters.BuildPipeline = EBuildPipeline.BuiltinBuildPipeline.ToString();
        buildParameters.BuildTarget = buildTarget;
        buildParameters.BuildMode = EBuildMode.IncrementalBuild;
        buildParameters.PackageName = "DefaultPackage";
        buildParameters.PackageVersion = GetBuildPackageVersion();
        buildParameters.VerifyBuildingResult = true;
        buildParameters.EnableSharePackRule = true; //启用共享资源构建模式，兼容1.5x版本
        buildParameters.FileNameStyle = EFileNameStyle.BundleName;
        buildParameters.BuildinFileCopyOption = EBuildinFileCopyOption.ClearAndCopyAll;
        buildParameters.BuildinFileCopyParams = string.Empty;
        buildParameters.EncryptionServices = CreateEncryptionServicesInstance(0);
        buildParameters.CompressOption = ECompressOption.LZ4;


        // 执行构建
        BuiltinBuildPipeline pipeline = new BuiltinBuildPipeline();
        var buildResult = pipeline.Run(buildParameters, true);
        if (buildResult.Success)
        {
            Debug.Log($"构建成功 : {buildResult.OutputPackageDirectory}");
        }
        else
        {
            Debug.LogError($"构建失败 : {buildResult.ErrorInfo}");
        }
    }

    // 构建版本相关
    private static string GetBuildPackageVersion()
    {
        int totalMinutes = DateTime.Now.Hour * 60 + DateTime.Now.Minute;
        return DateTime.Now.ToString("yyyy-MM-dd") + "-" + totalMinutes;
    }

    private static string[] GetBuildScenes()
    {
        var names = new List<string>();
        foreach (EditorBuildSettingsScene e in EditorBuildSettings.scenes)
        {
            if (e == null)
            {
                continue;
            }

            if (e.enabled)
            {
                names.Add(e.path);
            }
        }

        return names.ToArray();
    }
    
    private static IEncryptionServices CreateEncryptionServicesInstance(int index)
    {
        var encryptionServicesClassTypes = EditorTools.GetAssignableTypes(typeof(IEncryptionServices));
        var classType = encryptionServicesClassTypes[index];
        return (IEncryptionServices)Activator.CreateInstance(classType);
    }
}