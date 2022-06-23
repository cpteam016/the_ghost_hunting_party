using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class ImageUrl : MonoBehaviour
{
    public string url = "https://statics.indozone.news/content/2021/05/19/9Ds60zm/banner-eula-resmi-hadir-di-genshin-impact-seperti-ini-gameplay-nya72_700.jpg";
    public Renderer thisRenderer;
    
    // automatically called when game started
    void Start()
    {
        StartCoroutine(LoadFromLikeCoroutine()); // execute the section independently
        
        // the following will be called even before the load finished
        thisRenderer.material.color = Color.red;
    }

    [Obsolete("Obsolete")]
    // this section will be run independently
    private IEnumerator LoadFromLikeCoroutine()
    {
        Debug.Log("Loading...");
        WWW wwwLoader = new WWW(url); // create WWW object pointing to the url
        yield return wwwLoader; // start loading whatever in that url (delay happens here)
        
        Debug.Log("Loaded");
        thisRenderer.material.color = Color.white; // set white
        thisRenderer.material.mainTexture = wwwLoader.texture; // set loaded image.
    }
}
