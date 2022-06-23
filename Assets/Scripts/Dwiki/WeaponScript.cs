using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WeaponScript : MonoBehaviour
{
    public InventoryStatus inventoryStatus;
    public PlayerStatus playerStatus;
    public string attackname;
    public string placename;
    public string attackname1;
    public string placename1;
    public string attackname2;
    public string placename2;
    public string attackname3;
    public string placename3;
    public TextMeshProUGUI text;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public GameObject player;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public float distancea;
    public float distanceb;
    public float distancec;
    public float distance1a;
    public float distance1b;
    public float distance1c;
    public float distance2a;
    public float distance2b;
    public float distance2c;
    public float distance3a;
    public float distance3b;
    public float distance3c;
    public GameObject attackArea;
    public GameObject placeArea;
    public GameObject placeObject;
    public GameObject attackArea1;
    public GameObject placeArea1;
    public GameObject placeObject1;
    public GameObject attackArea2;
    public GameObject placeArea2;
    public GameObject placeObject2;
    public GameObject attackArea3;
    public GameObject placeArea3;
    public GameObject placeObject3;
    public GameObject offensiveButton;
    public GameObject reviveButton;
    public GameObject offensiveButton1;
    public GameObject reviveButton1;
    public GameObject offensiveButton2;
    public GameObject reviveButton2;
    public GameObject offensiveButton3;
    public GameObject reviveButton3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        distancea = Vector2.Distance(attackArea.transform.position, player1.transform.position);
        distanceb = Vector2.Distance(attackArea.transform.position, player2.transform.position);
        distancec = Vector2.Distance(attackArea.transform.position, player3.transform.position);
        distance1a = Vector2.Distance(attackArea1.transform.position, player.transform.position);
        distance1b = Vector2.Distance(attackArea1.transform.position, player2.transform.position);
        distance1c = Vector2.Distance(attackArea1.transform.position, player3.transform.position);
        distance2a = Vector2.Distance(attackArea2.transform.position, player.transform.position);
        distance2b = Vector2.Distance(attackArea2.transform.position, player1.transform.position);
        distance2c = Vector2.Distance(attackArea2.transform.position, player3.transform.position);
        distance3a = Vector2.Distance(attackArea3.transform.position, player.transform.position);
        distance3b = Vector2.Distance(attackArea3.transform.position, player1.transform.position);
        distance3c = Vector2.Distance(attackArea3.transform.position, player2.transform.position);

        if (inventoryStatus.toolsAcquired == "Moringa Leaves"){
        reviveButton.SetActive(false);
        text.text = "Attack";
        offensiveButton.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired == "Metal Nails"){
        reviveButton.SetActive(false);
        text.text = "Attack";
        offensiveButton.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired == "Broom"){
        reviveButton.SetActive(false);
        text.text = "Attack";
        offensiveButton.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired == "Knife"){
        reviveButton.SetActive(false);
        text.text = "Attack";
        offensiveButton.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired == "Flashlight"){
        reviveButton.SetActive(false);
        text.text = "Attack";
        offensiveButton.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired == "Onion Skewer"){
        reviveButton.SetActive(false);
        text.text = "Place";
        offensiveButton.SetActive(true);
        placeArea.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired == "Goose Egg"){
        reviveButton.SetActive(false);
        text.text = "Place";
        offensiveButton.SetActive(true);  
        placeArea.SetActive(true);  
        } else if (inventoryStatus.toolsAcquired == "Whiting"){
        reviveButton.SetActive(false);
        text.text = "Place";
        offensiveButton.SetActive(true);
        placeArea.SetActive(true);    
        } else if (inventoryStatus.toolsAcquired == "Water Bottle"){
        offensiveButton.SetActive(false);
        reviveButton.SetActive(true);
        } else {
        reviveButton.SetActive(false);
        offensiveButton.SetActive(false);
        placeArea.SetActive(false);     
        }

        if (inventoryStatus.toolsAcquired1 == "Moringa Leaves"){
        reviveButton1.SetActive(false);
        text1.text = "Attack";
        offensiveButton1.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired1 == "Metal Nails"){
        reviveButton1.SetActive(false);
        text1.text = "Attack";
        offensiveButton1.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired1 == "Broom"){
        reviveButton1.SetActive(false);
        text1.text = "Attack";
        offensiveButton1.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired1 == "Knife"){
        reviveButton1.SetActive(false);
        text1.text = "Attack";
        offensiveButton1.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired1 == "Flashlight"){
        reviveButton1.SetActive(false);
        text1.text = "Attack";
        offensiveButton1.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired1 == "Onion Skewer"){
        reviveButton1.SetActive(false);
        text1.text = "Place";
        offensiveButton1.SetActive(true);
        placeArea1.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired1 == "Goose Egg"){
        reviveButton1.SetActive(false);
        text1.text = "Place";
        offensiveButton1.SetActive(true);  
        placeArea1.SetActive(true);  
        } else if (inventoryStatus.toolsAcquired1 == "Whiting"){
        reviveButton1.SetActive(false);
        text1.text = "Place";
        offensiveButton1.SetActive(true);
        placeArea1.SetActive(true);    
        } else if (inventoryStatus.toolsAcquired1 == "Water Bottle"){
        offensiveButton1.SetActive(false);
        reviveButton1.SetActive(true);
        } else {
        reviveButton1.SetActive(false);
        offensiveButton1.SetActive(false);
        placeArea1.SetActive(false);     
        }

        if (inventoryStatus.toolsAcquired2 == "Moringa Leaves"){
        reviveButton2.SetActive(false);
        text2.text = "Attack";
        offensiveButton2.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired2 == "Metal Nails"){
        reviveButton2.SetActive(false);
        text2.text = "Attack";
        offensiveButton2.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired2 == "Broom"){
        reviveButton2.SetActive(false);
        text2.text = "Attack";
        offensiveButton2.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired2 == "Knife"){
        reviveButton2.SetActive(false);
        text2.text = "Attack";
        offensiveButton2.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired2 == "Flashlight"){
        reviveButton2.SetActive(false);
        text2.text = "Attack";
        offensiveButton2.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired2 == "Onion Skewer"){
        reviveButton2.SetActive(false);
        text2.text = "Place";
        offensiveButton2.SetActive(true);
        placeArea2.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired2 == "Goose Egg"){
        reviveButton2.SetActive(false);
        text2.text = "Place";
        offensiveButton2.SetActive(true);  
        placeArea2.SetActive(true);  
        } else if (inventoryStatus.toolsAcquired2 == "Whiting"){
        reviveButton2.SetActive(false);
        text2.text = "Place";
        offensiveButton2.SetActive(true);
        placeArea2.SetActive(true);    
        } else if (inventoryStatus.toolsAcquired2 == "Water Bottle"){
        offensiveButton2.SetActive(false);
        reviveButton2.SetActive(true);
        } else {
        reviveButton2.SetActive(false);
        offensiveButton2.SetActive(false);
        placeArea2.SetActive(false);     
        }

        if (inventoryStatus.toolsAcquired3 == "Moringa Leaves"){
        reviveButton3.SetActive(false);
        text3.text = "Attack";
        offensiveButton3.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired3 == "Metal Nails"){
        reviveButton3.SetActive(false);
        text3.text = "Attack";
        offensiveButton3.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired3 == "Broom"){
        reviveButton3.SetActive(false);
        text3.text = "Attack";
        offensiveButton3.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired3 == "Knife"){
        reviveButton3.SetActive(false);
        text3.text = "Attack";
        offensiveButton3.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired3 == "Flashlight"){
        reviveButton3.SetActive(false);
        text3.text = "Attack";
        offensiveButton3.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired3 == "Onion Skewer"){
        reviveButton3.SetActive(false);
        text3.text = "Place";
        offensiveButton3.SetActive(true);
        placeArea3.SetActive(true);   
        } else if (inventoryStatus.toolsAcquired3 == "Goose Egg"){
        reviveButton3.SetActive(false);
        text3.text = "Place";
        offensiveButton3.SetActive(true);  
        placeArea3.SetActive(true);  
        } else if (inventoryStatus.toolsAcquired3 == "Whiting"){
        reviveButton3.SetActive(false);
        text3.text = "Place";
        offensiveButton3.SetActive(true);
        placeArea3.SetActive(true);    
        } else if (inventoryStatus.toolsAcquired3 == "Water Bottle"){
        offensiveButton3.SetActive(false);
        reviveButton3.SetActive(true);
        } else {
        reviveButton3.SetActive(false);
        offensiveButton3.SetActive(false);
        placeArea3.SetActive(false);     
        }
    }

    public void revivePeople(){
        StartCoroutine(ReviveCooldown());
        if (distancea < 3){
            playerStatus.captured1 = false;
        } else if (distanceb < 3){
            playerStatus.captured2 = false;
        } else if (distancec < 3){
            playerStatus.captured3 = false;
        } else if (distance1a < 3){
            playerStatus.captured = false;
        } else if (distance1b < 3){
            playerStatus.captured2 = false;
        } else if (distance1c < 3){
            playerStatus.captured3 = false;
        } else if (distance2a < 3){
            playerStatus.captured = false;
        } else if (distance2b < 3){
            playerStatus.captured1 = false;
        } else if (distance2c < 3){
            playerStatus.captured3 = false;
        } else if (distance3a < 3){
            playerStatus.captured = false;
        } else if (distance3b < 3){
            playerStatus.captured1 = false;
        } else if (distance3c < 3){
            playerStatus.captured2 = false;
        }
    }

    public void revivePeople1(){
        StartCoroutine(ReviveCooldown1());
        if (distancea < 3){
            playerStatus.captured1 = false;
        } else if (distanceb < 3){
            playerStatus.captured2 = false;
        } else if (distancec < 3){
            playerStatus.captured3 = false;
        } else if (distance1a < 3){
            playerStatus.captured = false;
        } else if (distance1b < 3){
            playerStatus.captured2 = false;
        } else if (distance1c < 3){
            playerStatus.captured3 = false;
        } else if (distance2a < 3){
            playerStatus.captured = false;
        } else if (distance2b < 3){
            playerStatus.captured1 = false;
        } else if (distance2c < 3){
            playerStatus.captured3 = false;
        } else if (distance3a < 3){
            playerStatus.captured = false;
        } else if (distance3b < 3){
            playerStatus.captured1 = false;
        } else if (distance3c < 3){
            playerStatus.captured2 = false;
        }
    }

    public void revivePeople2(){
        StartCoroutine(ReviveCooldown2());
        if (distancea < 3){
            playerStatus.captured1 = false;
        } else if (distanceb < 3){
            playerStatus.captured2 = false;
        } else if (distancec < 3){
            playerStatus.captured3 = false;
        } else if (distance1a < 3){
            playerStatus.captured = false;
        } else if (distance1b < 3){
            playerStatus.captured2 = false;
        } else if (distance1c < 3){
            playerStatus.captured3 = false;
        } else if (distance2a < 3){
            playerStatus.captured = false;
        } else if (distance2b < 3){
            playerStatus.captured1 = false;
        } else if (distance2c < 3){
            playerStatus.captured3 = false;
        } else if (distance3a < 3){
            playerStatus.captured = false;
        } else if (distance3b < 3){
            playerStatus.captured1 = false;
        } else if (distance3c < 3){
            playerStatus.captured2 = false;
        }
    }

    public void revivePeople3(){
        StartCoroutine(ReviveCooldown());
        if (distancea < 3){
            playerStatus.captured1 = false;
        } else if (distanceb < 3){
            playerStatus.captured2 = false;
        } else if (distancec < 3){
            playerStatus.captured3 = false;
        } else if (distance1a < 3){
            playerStatus.captured = false;
        } else if (distance1b < 3){
            playerStatus.captured2 = false;
        } else if (distance1c < 3){
            playerStatus.captured3 = false;
        } else if (distance2a < 3){
            playerStatus.captured = false;
        } else if (distance2b < 3){
            playerStatus.captured1 = false;
        } else if (distance2c < 3){
            playerStatus.captured3 = false;
        } else if (distance3a < 3){
            playerStatus.captured = false;
        } else if (distance3b < 3){
            playerStatus.captured1 = false;
        } else if (distance3c < 3){
            playerStatus.captured2 = false;
        }
    }


    public void AreaAttack(){
        if (inventoryStatus.toolsAcquired == "Moringa Leaves"){
        attackname = "Moringa Leaves";
        StartCoroutine(WeaponCooldown());
        } else if (inventoryStatus.toolsAcquired == "Metal Nails"){
        attackname = "Metal Nails";
        StartCoroutine(WeaponCooldown());
        } else if (inventoryStatus.toolsAcquired == "Broom"){
        attackname = "Broom";
        StartCoroutine(WeaponCooldown()); 
        } else if (inventoryStatus.toolsAcquired == "Knife"){
        attackname = "Knife";
        StartCoroutine(WeaponCooldown());  
        } else if (inventoryStatus.toolsAcquired == "Flashlight"){
        attackname = "Flashlight";
        StartCoroutine(WeaponCooldown());  
        } else if (inventoryStatus.toolsAcquired == "Onion Skewer"){
        placename = "Onion Skewer";
        placeObject.SetActive(true);
        placeObject.transform.position = player.transform.position;
        inventoryStatus.toolsAcquired = "";
        } else if (inventoryStatus.toolsAcquired == "Goose Egg"){
        placename = "Goose Egg";
        placeObject.SetActive(true);
        placeObject.transform.position = player.transform.position;
        inventoryStatus.toolsAcquired = "";
        } else if (inventoryStatus.toolsAcquired == "Whiting"){
        placename = "Whiting";
        placeObject.SetActive(true);
        placeObject.transform.position = player.transform.position;
        inventoryStatus.toolsAcquired = "";
        } else {
        }
    }

    public void AreaAttack1(){
        if (inventoryStatus.toolsAcquired1 == "Moringa Leaves"){
        attackname1 = "Moringa Leaves";
        StartCoroutine(WeaponCooldown1());
        } else if (inventoryStatus.toolsAcquired1 == "Metal Nails"){
        attackname1 = "Metal Nails";
        StartCoroutine(WeaponCooldown1());
        } else if (inventoryStatus.toolsAcquired1 == "Broom"){
        attackname1 = "Broom";
        StartCoroutine(WeaponCooldown1()); 
        } else if (inventoryStatus.toolsAcquired1 == "Knife"){
        attackname1 = "Knife";
        StartCoroutine(WeaponCooldown1());  
        } else if (inventoryStatus.toolsAcquired1 == "Flashlight"){
        attackname1 = "Flashlight";
        StartCoroutine(WeaponCooldown1());  
        } else if (inventoryStatus.toolsAcquired1 == "Onion Skewer"){
        placename1 = "Onion Skewer";
        placeObject1.SetActive(true);
        placeObject1.transform.position = player1.transform.position;
        inventoryStatus.toolsAcquired1 = "";
        } else if (inventoryStatus.toolsAcquired1 == "Goose Egg"){
        placename1 = "Goose Egg";
        placeObject1.SetActive(true);
        placeObject1.transform.position = player1.transform.position;
        inventoryStatus.toolsAcquired1 = "";
        } else if (inventoryStatus.toolsAcquired1 == "Whiting"){
        placename1 = "Whiting";
        placeObject1.SetActive(true);
        placeObject1.transform.position = player1.transform.position;
        inventoryStatus.toolsAcquired1 = "";
        } else {
        }
    }

    public void AreaAttack2(){
        if (inventoryStatus.toolsAcquired2 == "Moringa Leaves"){
        attackname2 = "Moringa Leaves";
        StartCoroutine(WeaponCooldown2());
        } else if (inventoryStatus.toolsAcquired2 == "Metal Nails"){
        attackname2 = "Metal Nails";
        StartCoroutine(WeaponCooldown2());
        } else if (inventoryStatus.toolsAcquired2 == "Broom"){
        attackname2 = "Broom";
        StartCoroutine(WeaponCooldown2()); 
        } else if (inventoryStatus.toolsAcquired2 == "Knife"){
        attackname2 = "Knife";
        StartCoroutine(WeaponCooldown2());  
        } else if (inventoryStatus.toolsAcquired2 == "Flashlight"){
        attackname2 = "Flashlight";
        StartCoroutine(WeaponCooldown2());  
        } else if (inventoryStatus.toolsAcquired2 == "Onion Skewer"){
        placename2 = "Onion Skewer";
        placeObject2.SetActive(true);
        placeObject2.transform.position = player2.transform.position;
        inventoryStatus.toolsAcquired2 = "";
        } else if (inventoryStatus.toolsAcquired2 == "Goose Egg"){
        placename2 = "Goose Egg";
        placeObject2.SetActive(true);
        placeObject2.transform.position = player2.transform.position;
        inventoryStatus.toolsAcquired2 = "";
        } else if (inventoryStatus.toolsAcquired2 == "Whiting"){
        placename2 = "Whiting";
        placeObject2.SetActive(true);
        placeObject2.transform.position = player2.transform.position;
        inventoryStatus.toolsAcquired2 = "";
        } else {
        }
    }

    public void AreaAttack3(){
        if (inventoryStatus.toolsAcquired3 == "Moringa Leaves"){
        attackname3 = "Moringa Leaves";
        StartCoroutine(WeaponCooldown3());
        } else if (inventoryStatus.toolsAcquired3 == "Metal Nails"){
        attackname3 = "Metal Nails";
        StartCoroutine(WeaponCooldown3());
        } else if (inventoryStatus.toolsAcquired3 == "Broom"){
        attackname3 = "Broom";
        StartCoroutine(WeaponCooldown3()); 
        } else if (inventoryStatus.toolsAcquired3 == "Knife"){
        attackname3 = "Knife";
        StartCoroutine(WeaponCooldown3());  
        } else if (inventoryStatus.toolsAcquired3 == "Flashlight"){
        attackname3 = "Flashlight";
        StartCoroutine(WeaponCooldown3());  
        } else if (inventoryStatus.toolsAcquired3 == "Onion Skewer"){
        placename3 = "Onion Skewer";
        placeObject3.SetActive(true);
        placeObject3.transform.position = player3.transform.position;
        inventoryStatus.toolsAcquired3 = "";
        } else if (inventoryStatus.toolsAcquired3 == "Goose Egg"){
        placename3 = "Goose Egg";
        placeObject3.SetActive(true);
        placeObject3.transform.position = player3.transform.position;
        inventoryStatus.toolsAcquired3 = "";
        } else if (inventoryStatus.toolsAcquired3 == "Whiting"){
        placename3 = "Whiting";
        placeObject3.SetActive(true);
        placeObject3.transform.position = player3.transform.position;
        inventoryStatus.toolsAcquired3 = "";
        } else {
        }
    }

    public IEnumerator ReviveCooldown(){
        attackArea.SetActive(true);
        reviveButton.SetActive(false);
        yield return new WaitForSeconds(2.0f);
        attackArea.SetActive(false);
        inventoryStatus.toolsAcquired = "";
    }

    public IEnumerator ReviveCooldown1(){
        attackArea1.SetActive(true);
        reviveButton1.SetActive(false);
        yield return new WaitForSeconds(2.0f);
        attackArea1.SetActive(false);
        inventoryStatus.toolsAcquired1 = "";
    }

    public IEnumerator ReviveCooldown2(){
        attackArea2.SetActive(true);
        reviveButton2.SetActive(false);
        yield return new WaitForSeconds(2.0f);
        attackArea2.SetActive(false);
        inventoryStatus.toolsAcquired2 = "";
    }

    public IEnumerator ReviveCooldown3(){
        attackArea3.SetActive(true);
        reviveButton3.SetActive(false);
        yield return new WaitForSeconds(2.0f);
        attackArea3.SetActive(false);
        inventoryStatus.toolsAcquired3 = "";
    }

    public IEnumerator WeaponCooldown(){
        attackArea.SetActive(true);
        offensiveButton.SetActive(false);
        yield return new WaitForSeconds(2.0f);
        attackArea.SetActive(false);
        inventoryStatus.toolsAcquired = "";
    }

    public IEnumerator WeaponCooldown1(){
        attackArea1.SetActive(true);
        offensiveButton1.SetActive(false);
        yield return new WaitForSeconds(2.0f);
        attackArea1.SetActive(false);
        inventoryStatus.toolsAcquired1 = "";
    }

    public IEnumerator WeaponCooldown2(){
        attackArea2.SetActive(true);
        offensiveButton2.SetActive(false);
        yield return new WaitForSeconds(2.0f);
        attackArea2.SetActive(false);
        inventoryStatus.toolsAcquired2 = "";
    }

    public IEnumerator WeaponCooldown3(){
        attackArea3.SetActive(true);
        offensiveButton3.SetActive(false);
        yield return new WaitForSeconds(2.0f);
        attackArea3.SetActive(false);
        inventoryStatus.toolsAcquired3 = "";
    }

}
