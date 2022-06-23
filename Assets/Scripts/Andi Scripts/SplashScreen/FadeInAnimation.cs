using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// Class <c>FadeIn</c> membuat item akan menggelapkan nilai aplha color sehingga menjadi gelap.
/// </summary>
public class FadeInAnimation : MonoBehaviour
{
    [Header("Main Settings")] public Image targetImage;
    public float fadeSpeed;
    public float delay = 0;
    private bool _isStartFadeIn;
    public UnityEvent OnFadeFinished;
    void Awake()
    {
        // Membuat ukuran TargetImage sesuai dengan ukuran layar
        targetImage.rectTransform.localScale = new Vector2(Screen.width, Screen.height);
    }

    private void Start()
    {
        Invoke("StartFadeIn", delay);
    }

    void StartFadeIn()
    {
        // Mengubah nilai StartFadeOut menjadi true
        _isStartFadeIn = true;
    }

    void FadeIn()
    {
        // Membuat warna TargetImage Menggunakan transisi Lerp dari warna awal ke warna transparan
        targetImage.color = Color.Lerp(targetImage.color, Color.clear, fadeSpeed * Time.deltaTime);
    }

    void Update()
    {
        if (_isStartFadeIn)
        {
            FadeIn();
        }

        if (targetImage.color == Color.clear)
        {
            OnFadeFinished?.Invoke();
        }
    }
}