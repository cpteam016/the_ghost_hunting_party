using UnityEditor;
using UnityEngine;

public class Exit : MonoBehaviour
{
    public void QuitGame()
    {
        // Mematikan Game saat dalam editor
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif

        // Mematikan Game setelah game di build
        Application.Quit();
    }
}