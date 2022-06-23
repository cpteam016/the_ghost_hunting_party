using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public static Sound instance {get; private set;}
    private AudioSource source;

    private void Awake() 
    {
        instance = this;
        source =GetComponent<AudioSource>();  
        
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

        }  
        else if (instance != null &&  instance != this)
        Destroy(gameObject);
    }

    public void PlaySound (AudioClip _sound)
    {
        source.PlayOneShot(_sound);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
