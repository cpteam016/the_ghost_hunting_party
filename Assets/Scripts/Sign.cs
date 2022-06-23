using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour
{
    public GameObject sign;
    // Start is called before the first frame update
    void Start()
    {
        sign.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "Enemy")
        {
           sign.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision) 
    {
        if (collision.tag == "Enemy")
        {
           sign.SetActive(false);
        }
    }

    // IEnumerator ShowChat()
    // {
    //     yield return new  WaitForSeconds(5);
    //     sign.SetActive(true);
        
    // }
}
