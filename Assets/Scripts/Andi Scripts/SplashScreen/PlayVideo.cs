using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    [SerializeField] private RawImage rawImage;
    [SerializeField] private VideoPlayer videoPlayer;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private int delay = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (Application.platform != RuntimePlatform.WebGLPlayer)
            Invoke("StartDelay", delay);
    }

    void StartDelay()
    {
        StartCoroutine(Play());
    }

    IEnumerator Play()
    {
        if (videoPlayer.clip == null)
            throw new NullReferenceException("Video Player Tidak Ditemukan!");

        videoPlayer.Prepare();
        WaitForSeconds WaitForSeconds = new WaitForSeconds(1);
        while (!videoPlayer.isPrepared)
        {
            yield return WaitForSeconds;
            break;
        }

        rawImage.transform.localScale = Vector3.one;
        rawImage.texture = videoPlayer.texture;

        videoPlayer.Play();
        if (audioSource.clip != null)
            audioSource.Play();
    }
}