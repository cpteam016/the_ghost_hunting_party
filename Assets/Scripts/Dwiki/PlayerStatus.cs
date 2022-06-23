using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStatus : MonoBehaviour
{
    public PauseMenu pauseManager;
    public EnemyType enemyType;
    public GameObject player;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject pointer;
    public GameObject pointer1;
    public GameObject pointer2;
    public GameObject pointer3;
    public SpriteRenderer playerSprite;
    public SpriteRenderer playerSprite1;
    public SpriteRenderer playerSprite2;
    public SpriteRenderer playerSprite3;
    public SpriteRenderer ghostImage;
    public GameObject enemy;
    public Vector3 playerlastLocation;
    public Vector3 playerlastLocation1;
    public Vector3 playerlastLocation2;
    public Vector3 playerlastLocation3;
    public InventoryStatus inventoryStatus;
    public float distance;
    public float distance1;
    public float distance2;
    public float distance3;
    public bool captured;
    public bool captured1;
    public bool captured2;
    public bool captured3;
    public bool waiting;
    public bool waiting1;
    public bool waiting2;
    public bool waiting3;
    public bool jumpScarebool;
    public float durationAppear;
    public Image jumpScare;
    public Image playerImage;
    public Image playerImage1;
    public Image playerImage2;
    public Image playerImage3;
    public Slider playerSlider;
    public Slider playerSlider1;
    public Slider playerSlider2;
    public Slider playerSlider3;
    public bool scared;
    public bool scared1;
    public bool scared2;
    public bool scared3;
    public TextMeshProUGUI sign1;
    public TextMeshProUGUI sign2;
    public TextMeshProUGUI sign3;
    public TextMeshProUGUI sign4;
    public TextMeshProUGUI howTo;
    public float randomValue;
    public float signCount;
    public GameObject endPanel;
    public TextMeshProUGUI endResult;

    [SerializeField] private  AudioClip capturedSfx;
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(alphaChange()); 
      StartCoroutine(signChange());
      playerlastLocation = player.transform.position; 
      playerlastLocation1 = player1.transform.position; 
      playerlastLocation2 = player2.transform.position; 
      playerlastLocation3 = player3.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {

        if (enemyType.banished == true){
            endPanel.SetActive(true);
            endResult.text = "The ghost has been banished";
            Time.timeScale = 0;
        } else {
            endPanel.SetActive(false);
        }

        if (signCount > 10) {
            if (enemyType.ghostType == "Kuntilanak"){
                howTo.text = "Craft 1 Nail and attack close enough of Kuntilanak";
            } if (enemyType.ghostType == "Genderuwo"){
                howTo.text = "Craft 1 Moringa leaves and attack.";
            } if (enemyType.ghostType == "Begu Ganjang"){
                howTo.text = "Craft 1 Broom and attack.";
            } if (enemyType.ghostType == "Kuyang"){
                howTo.text = "Craft 1 Knife and attack.";
            } if (enemyType.ghostType == "Kisut"){
                howTo.text = "Craft 1 Flashlight and attack.";
            } if (enemyType.ghostType == "Pocong"){
                howTo.text = "Craft 1 Onion, 1 Garlic and 1 Stick, and place it in a area when pocong pass it.";
            } if (enemyType.ghostType == "Wewe Gombel"){
                howTo.text = "Craft 1 Goose Egg and place it in a area when wewe gombel pass it.";
            } if (enemyType.ghostType == "Sundel Bolong"){
                howTo.text = "Craft 1 Goose Egg and place it in a area when Sundel Bolong pass it.";
            } if (enemyType.ghostType == "Banaspati"){
                howTo.text = "Craft 1 Whiting and place it in a area when banaspati pass it.";
            }
        }

        distance = Vector2.Distance(player.transform.position, enemy.transform.position);
        distance1 = Vector2.Distance(player1.transform.position, enemy.transform.position);
        distance2 = Vector2.Distance(player2.transform.position, enemy.transform.position);
        distance3 = Vector2.Distance(player3.transform.position, enemy.transform.position);

        playerlastLocation = player.transform.position;
        playerlastLocation1 = player1.transform.position;
        playerlastLocation2 = player2.transform.position;
        playerlastLocation3 = player3.transform.position;

        if (durationAppear < 10){
           durationAppear = durationAppear + 0.01f;
        } else if (durationAppear > 10){
          StartCoroutine(alphaChange());  
          durationAppear = 0;
        }

        if (distance < 0.5f){
            if (inventoryStatus.hidingPlayer == false){
                if (scared == true){
            captured = true;
            playerlastLocation = player.transform.position;
            jumpScarebool = true;
            StartCoroutine(alphaChange()); 
            }
            }
        }

        if (pauseManager.isGamePaused == false){
        if (distance < 10f){
           playerSlider.value = playerSlider.value + 0.001f;
           if (inventoryStatus.hidingPlayer == true){
            playerSlider.value = playerSlider.value - 0.0005f;    
           } 
        } else {
            playerSlider.value = playerSlider.value - 0.0005f;     
        }
        }
        

        if (playerSlider.value > 0.9f){
            scared = true;
            durationAppear = 0;
            ghostImage.color = new Color(ghostImage.color.r, ghostImage.color.g, ghostImage.color.b, 0.5f);
        } else {
            scared = false;
        }

        if (captured == true){
        waiting = true;
        sign1.text = "";
        scared = false;
        playerSlider.value = 0;
        player.transform.position = playerlastLocation;
        pointer.transform.position = player.transform.position;
        StartCoroutine(capturedAnimation());
        player.transform.Rotate(0,0,1);
        playerImage.color = new Color (1f, 0f, 0f, 0.5f);
        if (jumpScarebool == true){
            StartCoroutine(caughtSplash());
            Sound.instance.PlaySound(capturedSfx);
        } else {
        }
        } else {
        waiting = false;
        player.transform.position = player.transform.position;
        playerImage.color = new Color (1f, 1f, 1f, 1f);
        StopCoroutine(capturedAnimation());
        if (inventoryStatus.hidingPlayer == false){
        playerSprite.color = new Color(1, 1, 1, 1f);
        }  
        }

        if (distance1 < 0.5f){
            if (inventoryStatus.hidingPlayer1 == false){
                if (scared1 == true){
            captured1 = true;
            playerlastLocation1 = player1.transform.position;
            jumpScarebool = true;
            StartCoroutine(alphaChange()); 
            }
            }
        }

        if (pauseManager.isGamePaused == false){
        if (distance1 < 10f){
           playerSlider1.value = playerSlider1.value + 0.001f;
           if (inventoryStatus.hidingPlayer1 == true){
            playerSlider1.value = playerSlider1.value - 0.0005f;    
           } 
        } else {
            playerSlider1.value = playerSlider1.value - 0.0005f;     
        }
        }
        

        if (playerSlider1.value > 0.9f){
            scared1 = true;
            durationAppear = 0;
            ghostImage.color = new Color(ghostImage.color.r, ghostImage.color.g, ghostImage.color.b, 0.5f);
        } else {
            scared1 = false;
        }

        if (captured1 == true){
            waiting1 = true;
        sign2.text = "";
        scared1 = false;
        playerSlider1.value = 0;
        player1.transform.position = playerlastLocation1;
        pointer1.transform.position = player1.transform.position;
        StartCoroutine(capturedAnimation1());
        player1.transform.Rotate(0,0,1);
        playerImage1.color = new Color (1f, 0f, 0f, 0.5f);
        if (jumpScarebool == true){
            StartCoroutine(caughtSplash());
            Sound.instance.PlaySound(capturedSfx);
        } else {
        }
        } else {
            waiting1 = false;
        player1.transform.position = player1.transform.position;
        playerImage1.color = new Color (1f, 1f, 1f, 1f);
        StopCoroutine(capturedAnimation1());
        if (inventoryStatus.hidingPlayer1 == false){
        playerSprite1.color = new Color(1, 1, 1, 1f);
        }  
        }

        if (distance2 < 0.5f){
            if (inventoryStatus.hidingPlayer2 == false){
                if (scared2 == true){
            captured2 = true;
            playerlastLocation2 = player2.transform.position;
            jumpScarebool = true;
            StartCoroutine(alphaChange()); 
            }
            }
        }

        if (pauseManager.isGamePaused != true){
        if (distance2 < 10f){
           playerSlider2.value = playerSlider2.value + 0.001f;
           if (inventoryStatus.hidingPlayer2 == true){
            playerSlider2.value = playerSlider2.value - 0.0005f;    
           } 
        } else {
            playerSlider2.value = playerSlider2.value - 0.0005f;     
        }
        }
        

        if (playerSlider2.value > 0.9f){
            scared2 = true;
            durationAppear = 0;
            ghostImage.color = new Color(ghostImage.color.r, ghostImage.color.g, ghostImage.color.b, 0.5f);
        } else {
            scared2 = false;
        }

        if (captured2 == true){
            waiting2 = true;
        sign3.text = "";
        scared2 = false;
        playerSlider2.value = 0;
        player2.transform.position = playerlastLocation2;
        pointer2.transform.position = player2.transform.position;
        StartCoroutine(capturedAnimation2());
        player2.transform.Rotate(0,0,1);
        playerImage2.color = new Color (1f, 0f, 0f, 0.5f);
        if (jumpScarebool == true){
            StartCoroutine(caughtSplash());
            Sound.instance.PlaySound(capturedSfx);
        } else {
        }
        } else {
            waiting2 = false;
        player2.transform.position = player2.transform.position;
        playerImage2.color = new Color (1f, 1f, 1f, 1f);
        StopCoroutine(capturedAnimation2());
        if (inventoryStatus.hidingPlayer2 == false){
        playerSprite2.color = new Color(1, 1, 1, 1f);
        }  
        }

        if (distance3 < 0.5f){
            if (inventoryStatus.hidingPlayer3 == false){
                if (scared3 == true){
            captured3 = true;
            playerlastLocation3 = player3.transform.position;
            jumpScarebool = true;
            StartCoroutine(alphaChange()); 
            }
            }
        }

        if (pauseManager.isGamePaused == false){
        if (distance3 < 10f){
           playerSlider3.value = playerSlider3.value + 0.001f;
           if (inventoryStatus.hidingPlayer3 == true){
            playerSlider3.value = playerSlider3.value - 0.0005f;    
           } 
        } else {
            playerSlider3.value = playerSlider3.value - 0.0005f;     
        }
        }
        

        if (playerSlider3.value > 0.9f){
            scared3 = true;
            durationAppear = 0;
            ghostImage.color = new Color(ghostImage.color.r, ghostImage.color.g, ghostImage.color.b, 0.5f);
        } else {
            scared3 = false;
        }

        if (captured3 == true){
            waiting3 = true;
        sign4.text = "";
        scared3 = false;
        playerSlider3.value = 0;
        player3.transform.position = playerlastLocation3;
        pointer3.transform.position = player3.transform.position;
        StartCoroutine(capturedAnimation3());
        player3.transform.Rotate(0,0,1);
        playerImage3.color = new Color (1f, 0f, 0f, 0.5f);
        if (jumpScarebool == true){
            StartCoroutine(caughtSplash());
            Sound.instance.PlaySound(capturedSfx);
        } else {
        }
        } else {
            waiting3 = false;
        player3.transform.position = player3.transform.position;
        playerImage3.color = new Color (1f, 1f, 1f, 1f);
        StopCoroutine(capturedAnimation3());
        if (inventoryStatus.hidingPlayer3 == false){
        playerSprite3.color = new Color(1, 1, 1, 1f);
        }  
        }

        if (waiting == true){
            if (waiting1 == true){
                if (waiting2 == true){
                    if (waiting3 == true){
                        endPanel.SetActive(true);
                        endResult.text = "All of your teammates has been possessed";
                        Time.timeScale = 0;
                    }
                }
            }
        }

    }

    public IEnumerator capturedAnimation(){
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.1f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.2f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.3f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.4f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.6f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.7f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.8f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.9f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 1f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.9f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.8f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.7f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.6f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.4f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.3f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.2f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0.1f);
        yield return new WaitForSeconds(0.1f);
        playerSprite.color = new Color(1, 1, 1, 0f);
    }

    public IEnumerator capturedAnimation1(){
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.1f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.2f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.3f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.4f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.6f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.7f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.8f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.9f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 1f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.9f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.8f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.7f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.6f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.4f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.3f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.2f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0.1f);
        yield return new WaitForSeconds(0.1f);
        playerSprite1.color = new Color(1, 1, 1, 0f);
    }

    public IEnumerator capturedAnimation2(){
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.1f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.2f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.3f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.4f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.6f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.7f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.8f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.9f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 1f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.9f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.8f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.7f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.6f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.4f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.3f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.2f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0.1f);
        yield return new WaitForSeconds(0.1f);
        playerSprite2.color = new Color(1, 1, 1, 0f);
    }

    public IEnumerator capturedAnimation3(){
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.1f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.2f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.3f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.4f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.6f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.7f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.8f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.9f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 1f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.9f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.8f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.7f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.6f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.5f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.4f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.3f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.2f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0.1f);
        yield return new WaitForSeconds(0.1f);
        playerSprite3.color = new Color(1, 1, 1, 0f);
    }

    public IEnumerator caughtSplash(){
    jumpScarebool = false;
    jumpScare.color = new Color(1,1,1, 0.1f);
    yield return new WaitForSeconds(0.05f);
    jumpScare.color = new Color(1,1,1, 0.2f);
    yield return new WaitForSeconds(0.05f); 
    jumpScare.color = new Color(1,1,1, 0.3f);
    yield return new WaitForSeconds(0.05f);
    jumpScare.color = new Color(1,1,1, 0.4f);
    yield return new WaitForSeconds(0.05f);
    jumpScare.color = new Color(1,1,1, 0.5f);
    yield return new WaitForSeconds(0.05f);  
    jumpScare.color = new Color(1,1,1, 0.6f);
    yield return new WaitForSeconds(0.05f);   
    jumpScare.color = new Color(1,1,1, 0.7f);
    yield return new WaitForSeconds(0.05f);   
    jumpScare.color = new Color(1,1,1, 0.8f);
    yield return new WaitForSeconds(0.05f);   
    jumpScare.color = new Color(1,1,1, 0.9f);
    yield return new WaitForSeconds(0.05f);   
    jumpScare.color = new Color(1,1,1, 1f);
    yield return new WaitForSeconds(0.05f);
    jumpScare.color = new Color(1,1,1, 0.9f);
    yield return new WaitForSeconds(0.05f);
    jumpScare.color = new Color(1,1,1, 0.8f);
    yield return new WaitForSeconds(0.05f);   
    jumpScare.color = new Color(1,1,1, 0.7f);
    yield return new WaitForSeconds(0.05f);   
    jumpScare.color = new Color(1,1,1, 0.6f);
    yield return new WaitForSeconds(0.05f);   
    jumpScare.color = new Color(1,1,1, 0.5f);
    yield return new WaitForSeconds(0.05f);   
    jumpScare.color = new Color(1,1,1, 0.4f);
    yield return new WaitForSeconds(0.05f);   
    jumpScare.color = new Color(1,1,1, 0.3f);
    yield return new WaitForSeconds(0.05f);   
    jumpScare.color = new Color(1,1,1, 0.2f);
    yield return new WaitForSeconds(0.05f);   
    jumpScare.color = new Color(1,1,1, 0.1f);
    yield return new WaitForSeconds(0.05f);   
    jumpScare.color = new Color(1,1,1, 0f);      
    }

    IEnumerator alphaChange(){
        yield return new WaitForSeconds(0.1f);
        ghostImage.color = new Color(ghostImage.color.r, ghostImage.color.g, ghostImage.color.b, 0.1f);
        yield return new WaitForSeconds(0.1f);
        ghostImage.color = new Color(ghostImage.color.r, ghostImage.color.g, ghostImage.color.b, 0.2f);
        yield return new WaitForSeconds(0.1f);
        ghostImage.color = new Color(ghostImage.color.r, ghostImage.color.g, ghostImage.color.b, 0.3f);
        yield return new WaitForSeconds(0.1f);
        ghostImage.color = new Color(ghostImage.color.r, ghostImage.color.g, ghostImage.color.b, 0.4f);
        yield return new WaitForSeconds(0.1f);
        ghostImage.color = new Color(ghostImage.color.r, ghostImage.color.g, ghostImage.color.b, 0.5f);
        yield return new WaitForSeconds(0.1f);
        ghostImage.color = new Color(ghostImage.color.r, ghostImage.color.g, ghostImage.color.b, 0.4f);
        yield return new WaitForSeconds(0.1f);
        ghostImage.color = new Color(ghostImage.color.r, ghostImage.color.g, ghostImage.color.b, 0.3f);
        yield return new WaitForSeconds(0.1f);
        ghostImage.color = new Color(ghostImage.color.r, ghostImage.color.g, ghostImage.color.b, 0.2f);
        yield return new WaitForSeconds(0.1f);
        ghostImage.color = new Color(ghostImage.color.r, ghostImage.color.g, ghostImage.color.b, 0.1f);
        yield return new WaitForSeconds(0.1f);
        ghostImage.color = new Color(ghostImage.color.r, ghostImage.color.g, ghostImage.color.b, 0f);
    }

    IEnumerator signChange(){
    while (true){
        yield return new WaitForSeconds (10f);

        if(enemyType.ghostType == "Kuntilanak"){
        randomValue = Random.Range(0,40);    
        if (randomValue < 10) {
        sign1.text = "EVP giving laughing sound";
        sign2.text = "Smell Detector detecting Red Color";
        sign3.text = "Jelangkung showing movement";  
        sign4.text = "Room Temperature detecting Freezing Temperature";
        } else if (randomValue > 10 && randomValue < 20){
        sign2.text = "EVP giving laughing sound";
        sign3.text = "Smell Detector detecting Red Color";
        sign4.text = "Jelangkung showing movement";  
        sign1.text = "Room Temperature detecting Freezing Temperature";
        } else if (randomValue > 20 && randomValue < 30){
        sign3.text = "EVP giving laughing sound";
        sign4.text = "Smell Detector detecting Red Color";
        sign1.text = "Jelangkung showing movement";  
        sign2.text = "Room Temperature detecting Freezing Temperature";             
        } else if (randomValue > 30 && randomValue < 40){
        sign4.text = "EVP giving laughing sound";
        sign1.text = "Smell Detector detecting Red Color";
        sign2.text = "Jelangkung showing movement";  
        sign3.text = "Room Temperature detecting Freezing Temperature";
        }
        }

        if(enemyType.ghostType == "Pocong"){
        randomValue = Random.Range(0,40);    
        if (randomValue < 10) {
        sign1.text = "EVP giving laughing sound";
        sign2.text = "Smell Detector detecting Yellow Color";
        sign3.text = "Jelangkung showing no movement";  
        sign4.text = "Room Temperature detecting Freezing Temperature";
        } else if (randomValue > 10 && randomValue < 20){
        sign2.text = "EVP giving laughing sound";
        sign3.text = "Smell Detector detecting Yellow Color";
        sign4.text = "Jelangkung showing no movement";  
        sign1.text = "Room Temperature detecting Freezing Temperature";
        } else if (randomValue > 20 && randomValue < 30){
        sign3.text = "EVP giving laughing sound";
        sign4.text = "Smell Detector detecting Yellow Color";
        sign1.text = "Jelangkung showing no movement";  
        sign2.text = "Room Temperature detecting Freezing Temperature";        
        } else if (randomValue > 30 && randomValue < 40){
        sign4.text = "EVP giving laughing sound";
        sign1.text = "Smell Detector detecting Yellow Color";
        sign2.text = "Jelangkung showing no movement";  
        sign3.text = "Room Temperature detecting Freezing Temperature";
        }
        }

        if(enemyType.ghostType == "Genderuwo"){
        randomValue = Random.Range(0,40);    
        if (randomValue < 10) {
        sign1.text = "EVP giving laughing sound";
        sign2.text = "Smell Detector detecting Yellow Color";
        sign3.text = "Jelangkung showing no movement";  
        sign4.text = "Room Temperature detecting Freezing Temperature"; 
        } else if (randomValue > 10 && randomValue < 20){
        sign2.text = "EVP giving laughing sound";
        sign3.text = "Smell Detector detecting Yellow Color";
        sign4.text = "Jelangkung showing no movement";  
        sign1.text = "Room Temperature detecting Freezing Temperature";
        } else if (randomValue > 20 && randomValue < 30){
        sign3.text = "EVP giving laughing sound";
        sign4.text = "Smell Detector detecting Yellow Color";
        sign1.text = "Jelangkung showing no movement";  
        sign2.text = "Room Temperature detecting Freezing Temperature";           
        } else if (randomValue > 30 && randomValue < 40){
        sign4.text = "EVP giving laughing sound";
        sign1.text = "Smell Detector detecting Yellow Color";
        sign2.text = "Jelangkung showing no movement";  
        sign3.text = "Room Temperature detecting Freezing Temperature";
        }
        }

        if(enemyType.ghostType == "Sundel Bolong"){
        randomValue = Random.Range(0,40);    
        if (randomValue < 10) {
        sign1.text = "EVP giving singing sound";
        sign2.text = "Smell Detector detecting Red Color";
        sign3.text = "Jelangkung showing movement";  
        sign4.text = "Room Temperature detecting Freezing Temperature";
        } else if (randomValue > 10 && randomValue < 20){
        sign2.text = "EVP giving singing sound";
        sign3.text = "Smell Detector detecting Red Color";
        sign4.text = "Jelangkung showing movement";  
        sign1.text = "Room Temperature detecting Freezing Temperature";
        } else if (randomValue > 20 && randomValue < 30){
        sign3.text = "EVP giving singing sound";
        sign4.text = "Smell Detector detecting Red Color";
        sign1.text = "Jelangkung showing movement";  
        sign2.text = "Room Temperature detecting Freezing Temperature";            
        } else if (randomValue > 30 && randomValue < 40){
        sign4.text = "EVP giving singing sound";
        sign1.text = "Smell Detector detecting Red Color";
        sign2.text = "Jelangkung showing movement";  
        sign3.text = "Room Temperature detecting Freezing Temperature";
        }
        }

        if(enemyType.ghostType == "Wewe Gombel"){
        randomValue = Random.Range(0,40);    
        if (randomValue < 10) {
        sign1.text = "EVP giving singing sound";
        sign2.text = "Smell Detector detecting Red Color"; 
        sign3.text = "Jelangkung showing movement"; 
        sign4.text = "Room Temperature detecting Normal Temperature"; 
        } else if (randomValue > 10 && randomValue < 20){
        sign2.text = "EVP giving singing sound";
        sign3.text = "Smell Detector detecting Red Color"; 
        sign4.text = "Jelangkung showing movement"; 
        sign1.text = "Room Temperature detecting Normal Temperature";
        } else if (randomValue > 20 && randomValue < 30){
        sign3.text = "EVP giving singing sound";
        sign4.text = "Smell Detector detecting Red Color"; 
        sign1.text = "Jelangkung showing movement"; 
        sign2.text = "Room Temperature detecting Normal Temperature";      
        } else if (randomValue > 30 && randomValue < 40){
        sign4.text = "EVP giving singing sound";
        sign1.text = "Smell Detector detecting Red Color"; 
        sign2.text = "Jelangkung showing movement"; 
        sign3.text = "Room Temperature detecting Normal Temperature";
        }
        }

        if(enemyType.ghostType == "Kuyang"){
        randomValue = Random.Range(0,40);    
        if (randomValue < 10) {
        sign1.text = "EVP giving laughing sound";
        sign2.text = "Smell Detector detecting Red Color"; 
        sign3.text = "Jelangkung showing no movement"; 
        sign4.text = "Room Temperature detecting Normal Temperature"; 
        } else if (randomValue > 10 && randomValue < 20){
        sign2.text = "EVP giving laughing sound";
        sign3.text = "Smell Detector detecting Red Color"; 
        sign4.text = "Jelangkung showing no movement"; 
        sign1.text = "Room Temperature detecting Normal Temperature";
        } else if (randomValue > 20 && randomValue < 30){
        sign3.text = "EVP giving laughing sound";
        sign4.text = "Smell Detector detecting Red Color"; 
        sign1.text = "Jelangkung showing no movement"; 
        sign2.text = "Room Temperature detecting Normal Temperature";          
        } else if (randomValue > 30 && randomValue < 40){
        sign4.text = "EVP giving laughing sound";
        sign1.text = "Smell Detector detecting Red Color"; 
        sign2.text = "Jelangkung showing no movement"; 
        sign3.text = "Room Temperature detecting Normal Temperature";
        }
        }

        if(enemyType.ghostType == "Banaspati"){
        randomValue = Random.Range(0,40);    
        if (randomValue < 10) {
        sign1.text = "EVP giving laughing sound";
        sign2.text = "Smell Detector detecting Yellow Color"; 
        sign3.text = "Jelangkung showing movement"; 
        sign4.text = "Room Temperature detecting Normal Temperature";
        } else if (randomValue > 10 && randomValue < 20){
        sign2.text = "EVP giving laughing sound";
        sign3.text = "Smell Detector detecting Yellow Color"; 
        sign4.text = "Jelangkung showing movement"; 
        sign1.text = "Room Temperature detecting Normal Temperature";
        } else if (randomValue > 20 && randomValue < 30){
        sign3.text = "EVP giving laughing sound";
        sign4.text = "Smell Detector detecting Yellow Color"; 
        sign1.text = "Jelangkung showing movement"; 
        sign2.text = "Room Temperature detecting Normal Temperature";       
        } else if (randomValue > 30 && randomValue < 40){
        sign4.text = "EVP giving laughing sound";
        sign1.text = "Smell Detector detecting Yellow Color"; 
        sign2.text = "Jelangkung showing movement"; 
        sign3.text = "Room Temperature detecting Normal Temperature";
        }
        }

        if(enemyType.ghostType == "Begu Ganjang"){
        randomValue = Random.Range(0,40);    
        if (randomValue < 10) {
        sign1.text = "EVP is quiet";
        sign2.text = "Smell Detector detecting Red Color";
        sign3.text = "Jelangkung is Wrecked";  
        sign4.text = "Room Temperature detecting Freezing Temperature";
        } else if (randomValue > 10 && randomValue < 20){
        sign2.text = "EVP is quiet";
        sign3.text = "Smell Detector detecting Red Color";
        sign4.text = "Jelangkung is Wrecked";  
        sign1.text = "Room Temperature detecting Freezing Temperature";
        } else if (randomValue > 20 && randomValue < 30){
        sign3.text = "EVP is quiet";
        sign4.text = "Smell Detector detecting Red Color";
        sign1.text = "Jelangkung is Wrecked";  
        sign2.text = "Room Temperature detecting Freezing Temperature";             
        } else if (randomValue > 30 && randomValue < 40){
        sign4.text = "EVP is quiet";
        sign1.text = "Smell Detector detecting Red Color";
        sign2.text = "Jelangkung is Wrecked";  
        sign3.text = "Room Temperature detecting Freezing Temperature";
        }
        }

        if(enemyType.ghostType == "Kisut"){
        randomValue = Random.Range(0,40);    
        if (randomValue < 10) {
        sign1.text = "EVP giving singing sound";
        sign2.text = "Smell Detector detecting Yellow Color"; 
        sign3.text = "Jelangkung showing no movement"; 
        sign4.text = "Room Temperature detecting Normal Temperature";
        } else if (randomValue > 10 && randomValue < 20){
        sign2.text = "EVP giving singing sound";
        sign3.text = "Smell Detector detecting Yellow Color"; 
        sign4.text = "Jelangkung showing no movement"; 
        sign1.text = "Room Temperature detecting Normal Temperature";
        } else if (randomValue > 20 && randomValue < 30){
        sign3.text = "EVP giving singing sound";
        sign4.text = "Smell Detector detecting Yellow Color"; 
        sign1.text = "Jelangkung showing no movement"; 
        sign2.text = "Room Temperature detecting Normal Temperature";       
        } else if (randomValue > 30 && randomValue < 40){
        sign4.text = "EVP giving singing sound";
        sign1.text = "Smell Detector detecting Yellow Color"; 
        sign2.text = "Jelangkung showing no movement"; 
        sign3.text = "Room Temperature detecting Normal Temperature";
        }
        }

        if (pauseManager.isGamePaused == false){
        signCount = signCount + 1;
        }

        yield return new WaitForSeconds (5f);
        sign1.text = "";
        sign2.text = "";
        sign3.text = "";
        sign4.text = "";
        }
}
    }
