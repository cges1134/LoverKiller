using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 選單場景的管理器
/// </summary>
public class MenuManager : MonoBehaviour
{
    /// <summary>
    /// 開始遊戲
    /// </summary>
    public void StartGame()
    {
        // 場景管理 的 載入場景("場景名稱")
        SceneManager.LoadScene("");
    }
    /// <summary>
    /// 離開遊戲
    /// </summary>
    public void QuitGame()
    {
        // 應用程式 的 離開遊戲
        Application.Quit();
    }
}

