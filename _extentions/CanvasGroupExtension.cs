using UnityEngine;

public static class CanvasGroupExtension
{
    
    /// <summary>
    /// CanvasGroupをアクティブにする
    /// </summary>
	public static void Active (this CanvasGroup ui)
	{
        ui.alpha = 1;
		ui.interactable = true;
        ui.blocksRaycasts = true;
	}

    /// <summary>
    /// CanvasGroupを非アクティブにする
    /// </summary>
	public static void InActive (this CanvasGroup ui)
	{
		ui.alpha = 0;
        ui.interactable = false;
        ui.blocksRaycasts = false;
	}
}
