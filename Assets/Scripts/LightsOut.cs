using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightsOut : MonoBehaviour
{
    private Image image;
    private Color lights;
    // Start is called before the first frame update
    void Start()
    {
        image = gameObject.GetComponent<Image>();
        lights = image.color;
        StartCoroutine(alphaChange());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator alphaChange(){
        while (true){
        yield return new WaitForSeconds(2f);
        yield return new WaitForSeconds(0.1f);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0.6f);
        yield return new WaitForSeconds(0.1f);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0.7f);
        yield return new WaitForSeconds(0.1f);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0.8f);
        yield return new WaitForSeconds(0.1f);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0.9f);
        yield return new WaitForSeconds(0.1f);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 1f);
        yield return new WaitForSeconds(0.1f);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0.9f);
        yield return new WaitForSeconds(0.1f);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0.8f);
        yield return new WaitForSeconds(0.1f);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0.7f);
        yield return new WaitForSeconds(0.1f);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0.6f);
        yield return new WaitForSeconds(0.1f);
        image.color = new Color(image.color.r, image.color.g, image.color.b, 0.5f);
        }
    }
}
