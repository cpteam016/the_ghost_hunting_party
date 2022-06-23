using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private bool left;
    private bool right;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CameraShaking());
    }

    // Update is called once per frame
    void Update()
    {
        if (right == true){
        gameObject.transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime);
        }
        if (left == true){
            gameObject.transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime);
        }
    }

    IEnumerator CameraMovement(){
        while (true){
            right = true;
            left = false;
            yield return new WaitForSeconds(5f);
            right = false;
            left = true;
            yield return new WaitForSeconds(10f);
            right = true;
            left = false;
            yield return new WaitForSeconds(5f);
        }
    }

    IEnumerator CameraShaking(){
        while (true){
        yield return new WaitForSeconds(300f);
        gameObject.transform.position = new Vector3 (-4f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-3f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-4f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-3f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-3.5f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-4f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-3f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-4f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-3f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-3.5f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-4f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-3f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-4f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-3f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-3.5f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-4f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-3f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-4f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-3f, 1.3f, -10);
        yield return new WaitForSeconds(0.05f);
        gameObject.transform.position = new Vector3 (-3.5f, 1.3f, -10);
        }
    }
}
