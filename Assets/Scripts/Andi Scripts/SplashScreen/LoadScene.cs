using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Class <c>LoadScene</c> akan memanggil scene lain masuk ke layar aktif
/// </summary>
public class LoadScene : MonoBehaviour
{
    [Header("Main Settings")] public string targetScene;
    
    public float delay;

    public bool isDelay;
    
    void Load()
    {
        // Melakukan perpindahan antar scene yang aktif pada build settings.
        SceneManager.LoadScene(targetScene);
    }

    public void LoadClick()
    {
        // Melakukan perpindahan antar scene yang aktif pada build settings.
        SceneManager.LoadScene(targetScene);
    }

    private void Start()
    {
        if (isDelay)
        {
            Invoke(nameof(Load), delay);
        }
    }
}