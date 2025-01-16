using UnityEngine;
using UnityEngine.UI;

public class CanvasScaler_External: CanvasScaler
{
    protected override void HandleScaleWithScreenSize()
    {
        //1080，1920
        // if (Screen.width / m_ReferenceResolution.x < Screen.height / m_ReferenceResolution.y)
        //     matchWidthOrHeight = 1f;
        // else
        //     matchWidthOrHeight = 0f;
        //
        // Debug.LogError(Screen.width + "--" + m_ReferenceResolution.x);
        // Debug.LogError(Screen.height + "--" + m_ReferenceResolution.y);
        base.HandleScaleWithScreenSize();
    }
}