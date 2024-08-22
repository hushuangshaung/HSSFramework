using System.Collections.Generic;
using HotUpdate.Code.Kernel.Network;
using HotUpdate.Code.Kernel.RedDot;

public static class ManagerRegister
{
    private static readonly List<IManager> List = new()
    {
        NetworkManager.Instance,
        RedDotManager.Instance,
    };
    
    
    
    public static void Register()
    {
        Manager.Initaialize(List);
    }
}