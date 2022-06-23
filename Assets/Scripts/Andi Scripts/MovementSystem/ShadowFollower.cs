using System;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class ShadowFollower : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        SetActive(false);
    }
    
    public void SetActive(bool visible)
    {
        gameObject.SetActive(visible);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Entered! " + col.tag);
        if (col.CompareTag("Player"))
        {
            SetActive(false);
        }
    }
}