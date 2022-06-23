using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    private float randomNumber;
    public Transform garageSpot;
    public Transform gardenSpot;
    public Transform livingroomSpot;
    public Transform storageSpot;
    public Transform bathroomSpot;
    public Transform masterbedroomSpot;
    public Transform masterbathroomSpot;
    public Transform bedroom1Spot;
    public Transform bedroom2Spot;
    public Transform dinnerSpot;
    public Transform kitchenSpot;
    public Transform randomizedSpot;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        randomNumber = Random.Range(0, 110);
        if (randomNumber < 10) {
        randomizedSpot = garageSpot;    
        } else if (randomNumber > 10 && randomNumber < 20){
        randomizedSpot = gardenSpot;    
        } else if (randomNumber > 20 && randomNumber < 30){
        randomizedSpot = storageSpot;    
        } else if (randomNumber > 30 && randomNumber < 40){
        randomizedSpot = livingroomSpot;    
        } else if (randomNumber > 40 && randomNumber < 50){
        randomizedSpot = kitchenSpot;    
        } else if (randomNumber > 50 && randomNumber < 60){
        randomizedSpot = masterbedroomSpot;    
        } else if (randomNumber > 60 && randomNumber < 70){
        randomizedSpot = masterbathroomSpot;    
        } else if (randomNumber > 70 && randomNumber < 80){
        randomizedSpot = bedroom1Spot;    
        } else if (randomNumber > 80 && randomNumber < 90){
        randomizedSpot = bedroom2Spot;    
        } else if (randomNumber > 90 && randomNumber < 100){
        randomizedSpot = bathroomSpot;    
        } else if (randomNumber > 100 && randomNumber < 110){
        randomizedSpot = dinnerSpot;    
        }

        enemy.transform.position = new Vector2(randomizedSpot.transform.position.x, randomizedSpot.transform.position.y) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
