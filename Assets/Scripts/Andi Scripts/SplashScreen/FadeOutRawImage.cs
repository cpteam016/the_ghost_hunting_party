using UnityEngine;
using UnityEngine.UI;

namespace Andi_Scripts.SplashScreen
{
    public class FadeOutRawImage : MonoBehaviour
    {
        [SerializeField] private Image alternativeImage;
        [SerializeField] private RawImage targetImage;
        public float fadeSpeed;
        public float delay;
        public Color color = Color.black;
        private bool _isStartFadeOut;

        void Awake()
        {
            // Membuat TargetImage sesuai dengan ukuran layar
            targetImage.rectTransform.localScale = new Vector2(Screen.width, Screen.height);

            // Menyembunyikan TargetImage
            targetImage.enabled = false;
            targetImage.color = Color.clear;
            alternativeImage.enabled = false;
            alternativeImage.color = Color.clear;
        }

        void Start()
        {
            // Memanggil fungsi StartFadeOut berdasarkan delay
            Invoke("StartFadeOut", delay);

            Debug.Log("Platform" + Application.platform);
        }


        void StartFadeOut()
        {
            // Mengubah nilai StartFadeOut menjadi true
            _isStartFadeOut = true;

            if (Application.platform == RuntimePlatform.WebGLPlayer)
            {
                // Memunculkan TargetImage alternatif dari canvas;
                alternativeImage.enabled = true;
            }
            else
            {
                // Memunculkan TargetImage dari canvas;
                targetImage.enabled = true;
            }
        }

        void FadeOut()
        {
            if (Application.platform == RuntimePlatform.WebGLPlayer)
            {
                // Membuat warna dari TargetImage menggunakan transisi Lerp dari transparan ke warna dasar gambar;
                alternativeImage.color = Color.Lerp(alternativeImage.color, color, fadeSpeed * Time.deltaTime);
            }
            else
            {
                // Membuat warna dari TargetImage menggunakan transisi Lerp dari transparan ke warna dasar gambar;
                targetImage.color = Color.Lerp(targetImage.color, color, fadeSpeed * Time.deltaTime);
            }
        }

        void Update()
        {
            if (_isStartFadeOut)
            {
                FadeOut();
            }
        }
    }
}