using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class MenuScript : MonoBehaviour
{
    public GameObject book;
    public GameObject craft;
    public bool boolBook;
    public bool boolCraft;
    public Canvas mainCanvas;

    // Start is called before the first frame update
    void Start()
    {
     boolCraft = false;
     boolBook = false;
    }

    public void bookMenuOpen(){
        boolCraft = false;
        boolBook = true;
    }

    public void craftMenuOpen(){
        boolCraft = true;
        boolBook = false;
    }

    public void monitorMenuOpen(){
        boolCraft = false;
        boolBook = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (boolBook == true){
            book.SetActive(true);
        } else {
            book.SetActive(false);
        }

        if (boolCraft == true){
            craft.SetActive(true);
        } else {
            craft.SetActive(false);
        }

    }
}
