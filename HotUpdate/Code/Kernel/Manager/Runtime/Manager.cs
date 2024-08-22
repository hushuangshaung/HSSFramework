using System.Collections.Generic;

public static class Manager
{
    private static readonly List<IManager> Managers = new ();
    public static void Initaialize(List<IManager> list)
    {
        foreach (var manager in list)
        {
            manager.Initialize();
            Managers.Add(manager);
        }
    }
    
    public static void SignIn()
    {
        foreach (var manager in Managers)
        {
            manager.SignIn();
        }
    }
    
    public static void SignOut()
    {
        foreach (var manager in Managers)
        {
            manager.SignOut();
        }
    }

    public static void Destroy()
    {
        foreach (var manager in Managers)
        {
            manager.Destroy();
        }
        Managers.Clear();
    }
}