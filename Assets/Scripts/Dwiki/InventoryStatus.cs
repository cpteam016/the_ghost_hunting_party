using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

public class InventoryStatus : MonoBehaviour
{
    public PauseMenu pauseManager;
    public GameObject Panel1;
    public GameObject Panel21;
    public GameObject Panel31;
    public GameObject Panel41;
    public GameObject Panel2;
    public TextMeshProUGUI panelText;
    public TextMeshProUGUI panelText2;
    public TextMeshProUGUI panelText3;
    public TextMeshProUGUI panelText4;
    public GameObject playerObjek;
    public GameObject playerObjek1;
    public GameObject playerObjek2;
    public GameObject playerObjek3;
    public SpriteRenderer playerSprite;
    public SpriteRenderer playerSprite1;
    public SpriteRenderer playerSprite2;
    public SpriteRenderer playerSprite3;
    private ItemChecker players;
    private ItemChecker players1;
    private ItemChecker players2;
    private ItemChecker players3;
    public PlayerStatus capturedStatus;
    public string toolsAcquired;
    public string toolsAcquired1;
    public string toolsAcquired2;
    public string toolsAcquired3;
    public GameObject hideButton;
    public GameObject hideButton1;
    public GameObject hideButton2;
    public GameObject hideButton3;
    public bool searchingItem;
    public bool searchingItem1;
    public bool searchingItem2;
    public bool searchingItem3;
    public bool hidingPlayer;
    public bool hidingPlayer1;
    public bool hidingPlayer2;
    public bool hidingPlayer3;
    public Slider searchingSlider;
    public Slider searchingSlider1;
    public Slider searchingSlider2;
    public Slider searchingSlider3;
    public float randomValue;
    public float randomValue1;
    public float randomValue2;
    public float randomValue3;
    public int coinAmounts;
    public TextMeshPro statusPlayer;
    public TextMeshPro statusPlayer1;
    public TextMeshPro statusPlayer2;
    public TextMeshPro statusPlayer3;
    public TextMeshProUGUI buyInformation;
    public bool buyMenu;
    public Canvas mainCanvas;
    public string itemName;
    public string craftCombination;
    public string craftName;
    public TextMeshProUGUI craftList;
    public TextMeshProUGUI currentCoin;
    public TextMeshProUGUI resultCraft;
    public string tools1;
    public string tools2;
    public GameObject toolsCrafted;
    public GameObject toolsCrafted1;
    public bool toolsbool;
    public bool toolsbool1;
    public int stickAmount;
    public int onionAmount;

    public int nailAmount;

    public int garlicAmount;

    public int moringaleavesAmount;

    public int gooseeggAmount;

    public int broomAmount;

    public int knifeAmount;

    public int clamshellAmount;

    public int waterAmount;

    public int panAmount;

    public int bottleAmount;

    public int onionCraft;

    public int nailCraft;

    public int garlicCraft;
    public int moringaleavesCraft;

    public int gooseeggCraft;

    public int broomCraft;

    public int knifeCraft;

    public int clamshellCraft;

    public int waterCraft;

    public int panCraft;

    public int bottleCraft;
    public int stickCraft;
    public TextMeshProUGUI nailText;
    public TextMeshProUGUI onionText;
    public TextMeshProUGUI garlicText;
    public TextMeshProUGUI moringaleavesText;
    public TextMeshProUGUI panText;
    public TextMeshProUGUI clamshellText;
    public TextMeshProUGUI gooseeggText;
    public TextMeshProUGUI waterText;
    public TextMeshProUGUI broomText;
    public TextMeshProUGUI knifeText;
    public TextMeshProUGUI bottleText;
    public TextMeshProUGUI stickText;
    public bool o1;
    public bool o2;
    public bool o3;
    public bool o4;
    public bool o5;
    public bool o6;
    public bool o7;
    public bool o8;
    public bool o9;
    public bool o10;
    public bool o11;

    [SerializeField] private AudioClip searchingSfx;

    // Start is called before the first frame update
    void Start()
    {
        players = playerObjek.GetComponent<ItemChecker>();
        players1 = playerObjek1.GetComponent<ItemChecker>();
        players2 = playerObjek2.GetComponent<ItemChecker>();
        players3 = playerObjek3.GetComponent<ItemChecker>();
        searchingSlider.value = 0f;
        searchingSlider1.value = 0f;
        searchingSlider2.value = 0f;
        searchingSlider3.value = 0f;
        o1 = true;
        o2 = true;
        o3 = true;
        o4 = true;
        o5 = true;
        o6 = true;
        o7 = true;
        o8 = true;
        o9 = true;
        o10 = true;
        o11 = true;
    }


    public void buyActivation()
    {
        if (buyMenu == false)
        {
            buyMenu = true;
        }
        else
        {
            buyMenu = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentCoin.text = "Coin : " + coinAmounts.ToString();
        nailText.text = nailAmount.ToString();
        onionText.text = onionAmount.ToString();
        garlicText.text = garlicAmount.ToString();
        moringaleavesText.text = moringaleavesAmount.ToString();
        panText.text = panAmount.ToString();
        clamshellText.text = clamshellAmount.ToString();
        gooseeggText.text = gooseeggAmount.ToString();
        waterText.text = waterAmount.ToString();
        broomText.text = broomAmount.ToString();
        knifeText.text = knifeAmount.ToString();
        bottleText.text = bottleAmount.ToString();
        stickText.text = stickAmount.ToString();

        statusPlayer.transform.position = playerObjek.transform.position + new Vector3(0, -2, 0);
        statusPlayer1.transform.position = playerObjek1.transform.position + new Vector3(0, -2, 0);
        statusPlayer2.transform.position = playerObjek2.transform.position + new Vector3(0, -2, 0);
        statusPlayer3.transform.position = playerObjek3.transform.position + new Vector3(0, -2, 0);

        if (toolsbool == true)
        {
            toolsCrafted.SetActive(true);
        }
        else
        {
            toolsCrafted.SetActive(false);
        }

        if (toolsbool1 == true)
        {
            toolsCrafted1.SetActive(true);
        }
        else
        {
            toolsCrafted1.SetActive(false);
        }

        if (players.objectString == tools1){
            hideButton.SetActive(false);
        } else if (players.objectString == tools2){
            hideButton.SetActive(false);
        } else {
            hideButton.SetActive(true);
        }

        if (players1.objectString == tools1){
            hideButton1.SetActive(false);
        } else if (players1.objectString == tools2){
            hideButton1.SetActive(false);
        } else {
            hideButton1.SetActive(true);
        }

        if (players2.objectString == tools1){
            hideButton2.SetActive(false);
        } else if (players2.objectString == tools2){
            hideButton2.SetActive(false);
        } else {
            hideButton2.SetActive(true);
        }

        if (players3.objectString == tools1){
            hideButton3.SetActive(false);
        } else if (players3.objectString == tools2){
            hideButton3.SetActive(false);
        } else {
            hideButton3.SetActive(true);
        }

        if (buyMenu == true)
        {
            Panel2.SetActive(true);
        } else {
            Panel2.SetActive(false);
        }

        if (players.isChecking == true)
        {
            Panel1.SetActive(true);
            panelText.text = players.objectString;
        }
        else
        {
            Panel1.SetActive(false);
            panelText.text = "";
        }

        if (players1.isChecking == true)
        {
            Panel21.SetActive(true);
            panelText2.text = players1.objectString;
        }
        else
        {
            Panel21.SetActive(false);
            panelText2.text = "";
        }

        if (players2.isChecking == true)
        {
            Panel31.SetActive(true);
            panelText3.text = players2.objectString;
        }
        else
        {
            Panel31.SetActive(false);
            panelText3.text = "";
        }

        if (players3.isChecking == true)
        {
            Panel41.SetActive(true);
            panelText4.text = players3.objectString;
        }
        else
        {
            Panel41.SetActive(false);
            panelText4.text = "";
        }

        if (pauseManager.isGamePaused == false){
        if (searchingItem == true)
        {
            if (searchingSlider.value < 1.0f)
            {
                searchingSlider.value = searchingSlider.value + 0.001f;
                Sound.instance.PlaySound(searchingSfx);
            }
            else if (searchingSlider.value == 1.0f)
            {
                searchingSlider.value = 0f;
                searchingItem = false;
                StartCoroutine(coinAmount());
            }
        }
        else
        {
            searchingSlider.value = 0f;
        }
        }

        if (pauseManager.isGamePaused == false){
        if (searchingItem1 == true)
        {
            if (searchingSlider1.value < 1.0f)
            {
                searchingSlider1.value = searchingSlider1.value + 0.001f;
                Sound.instance.PlaySound(searchingSfx);
            }
            else if (searchingSlider1.value == 1.0f)
            {
                searchingSlider1.value = 0f;
                searchingItem1 = false;
                StartCoroutine(coinAmount1());
            }
        }
        else
        {
            searchingSlider1.value = 0f;
        }
        }

        if (pauseManager.isGamePaused == false){
        if (searchingItem2 == true)
        {
            if (searchingSlider2.value < 1.0f)
            {
                searchingSlider2.value = searchingSlider2.value + 0.001f;
                Sound.instance.PlaySound(searchingSfx);
            }
            else if (searchingSlider2.value == 1.0f)
            {
                searchingSlider2.value = 0f;
                searchingItem2 = false;
                StartCoroutine(coinAmount2());
            }
        }
        else
        {
            searchingSlider2.value = 0f;
        }
        }

        if (pauseManager.isGamePaused == false){
        if (searchingItem3 == true)
        {
            if (searchingSlider3.value < 1.0f)
            {
                searchingSlider3.value = searchingSlider3.value + 0.001f;
                Sound.instance.PlaySound(searchingSfx);
            }
            else if (searchingSlider3.value == 1.0f)
            {
                searchingSlider3.value = 0f;
                searchingItem3 = false;
                StartCoroutine(coinAmount3());
            }
        }
        else
        {
            searchingSlider3.value = 0f;
        }
        }

        if (players.isChecking == false)
        {
            hidingPlayer = false;
            playerSprite.color = new Color(1f, 1f, 1f, 1f);
        }

        if (players1.isChecking == false)
        {
            hidingPlayer1 = false;
            playerSprite1.color = new Color(1f, 1f, 1f, 1f);
        }

        if (players2.isChecking == false)
        {
            hidingPlayer2 = false;
            playerSprite2.color = new Color(1f, 1f, 1f, 1f);
        }

        if (players3.isChecking == false)
        {
            hidingPlayer3 = false;
            playerSprite3.color = new Color(1f, 1f, 1f, 1f);
        }


    }

    public void SearchRandomizer()
    {
        if (capturedStatus.captured == false)
        {
            if (players.isChecking == true)
            {
                if (players.objectString == "Master Bed")
                {
                    if (o1 == true)
                    {
                        searchingItem = true;
                        hidingPlayer = false;
                    }
                    else
                    {
                        searchingItem = false;
                        statusPlayer.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage());
                    }
                }
                if (players.objectString == "Leftside Room Bed")
                {
                    if (o2 == true)
                    {
                        searchingItem = true;
                        hidingPlayer = false;
                    }
                    else
                    {
                        searchingItem = false;
                        statusPlayer.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage());
                    }
                }
                if (players.objectString == "Rightside Room Bed")
                {
                    if (o3 == true)
                    {
                        searchingItem = true;
                        hidingPlayer = false;
                    }
                    else
                    {
                        searchingItem = false;
                        statusPlayer.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage());
                    }
                }
                if (players.objectString == "Master Bathroom Medicine Cabinet")
                {
                    if (o4 == true)
                    {
                        searchingItem = true;
                        hidingPlayer = false;
                    }
                    else
                    {
                        searchingItem = false;
                        statusPlayer.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage());
                    }
                }
                if (players.objectString == "Car")
                {
                    if (o5 == true)
                    {
                        searchingItem = true;
                        hidingPlayer = false;
                    }
                    else
                    {
                        searchingItem = false;
                        statusPlayer.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage());
                    }
                }
                if (players.objectString == "Bathroom Medicine Cabinet")
                {
                    if (o6 == true)
                    {
                        searchingItem = true;
                        hidingPlayer = false;
                    }
                    else
                    {
                        searchingItem = false;
                        statusPlayer.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage());
                    }
                }
                if (players.objectString == "Box")
                {
                    if (o7 == true)
                    {
                        searchingItem = true;
                        hidingPlayer = false;
                    }
                    else
                    {
                        searchingItem = false;
                        statusPlayer.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage());
                    }
                }
                if (players.objectString == "Large Sofa")
                {
                    if (o8 == true)
                    {
                        searchingItem = true;
                        hidingPlayer = false;
                    }
                    else
                    {
                        searchingItem = false;
                        statusPlayer.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage());
                    }
                }
                if (players.objectString == "Kitchen Drawer")
                {
                    if (o9 == true)
                    {
                        searchingItem = true;
                        hidingPlayer = false;
                    }
                    else
                    {
                        searchingItem = false;
                        statusPlayer.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage());
                    }
                }
                if (players.objectString == "Table")
                {
                    if (o10 == true)
                    {
                        searchingItem = true;
                        hidingPlayer = false;
                    }
                    else
                    {
                        searchingItem = false;
                        statusPlayer.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage());
                    }
                }
                if (players.objectString == "Plant")
                {
                    if (o11 == true)
                    {
                        searchingItem = true;
                        hidingPlayer = false;
                    }
                    else
                    {
                        searchingItem = false;
                        statusPlayer.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage());
                    }
                }
                if (players.objectString == tools1.ToString())
                {
                    toolsbool = false;
                    toolsAcquired = tools1.ToString();
                    tools1 = "";
                    players.isChecking = false;
                }
                if (players.objectString == tools2.ToString())
                {
                    toolsbool1 = false;
                    toolsAcquired = tools1.ToString();
                    tools2 = "";
                    players.isChecking = false;
                }
            }
            else
            {
                searchingItem = false;
                statusPlayer.text = "Wait for 15 seconds ";
                StartCoroutine(buyMessage());
            }
        }
    }

    public void SearchRandomizer1()
    {
        if (capturedStatus.captured1 == false)
        {
            if (players1.isChecking == true)
            {
                if (players1.objectString == "Master Bed")
                {
                    if (o1 == true)
                    {
                        searchingItem1 = true;
                        hidingPlayer1 = false;
                    }
                    else
                    {
                        searchingItem1 = false;
                        statusPlayer1.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage1());
                    }
                }
                if (players1.objectString == "Leftside Room Bed")
                {
                    if (o2 == true)
                    {
                        searchingItem1 = true;
                        hidingPlayer1 = false;
                    }
                    else
                    {
                        searchingItem1 = false;
                        statusPlayer1.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage1());
                    }
                }
                if (players1.objectString == "Rightside Room Bed")
                {
                    if (o3 == true)
                    {
                        searchingItem1 = true;
                        hidingPlayer1 = false;
                    }
                    else
                    {
                        searchingItem1 = false;
                        statusPlayer1.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage1());
                    }
                }
                if (players1.objectString == "Master Bathroom Medicine Cabinet")
                {
                    if (o4 == true)
                    {
                        searchingItem1 = true;
                        hidingPlayer1 = false;
                    }
                    else
                    {
                        searchingItem1 = false;
                        statusPlayer1.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage1());
                    }
                }
                if (players1.objectString == "Car")
                {
                    if (o5 == true)
                    {
                        searchingItem1 = true;
                        hidingPlayer1 = false;
                    }
                    else
                    {
                        searchingItem1 = false;
                        statusPlayer1.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage1());
                    }
                }
                if (players1.objectString == "Bathroom Medicine Cabinet")
                {
                    if (o6 == true)
                    {
                        searchingItem1 = true;
                        hidingPlayer1 = false;
                    }
                    else
                    {
                        searchingItem1 = false;
                        statusPlayer1.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage1());
                    }
                }
                if (players1.objectString == "Box")
                {
                    if (o7 == true)
                    {
                        searchingItem1 = true;
                        hidingPlayer1 = false;
                    }
                    else
                    {
                        searchingItem1 = false;
                        statusPlayer1.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage1());
                    }
                }
                if (players1.objectString == "Large Sofa")
                {
                    if (o8 == true)
                    {
                        searchingItem1 = true;
                        hidingPlayer1 = false;
                    }
                    else
                    {
                        searchingItem1 = false;
                        statusPlayer1.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage1());
                    }
                }
                if (players1.objectString == "Kitchen Drawer")
                {
                    if (o9 == true)
                    {
                        searchingItem1 = true;
                        hidingPlayer1 = false;
                    }
                    else
                    {
                        searchingItem1 = false;
                        statusPlayer1.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage1());
                    }
                }
                if (players1.objectString == "Table")
                {
                    if (o10 == true)
                    {
                        searchingItem1 = true;
                        hidingPlayer1 = false;
                    }
                    else
                    {
                        searchingItem1 = false;
                        statusPlayer1.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage1());
                    }
                }
                if (players1.objectString == "Plant")
                {
                    if (o11 == true)
                    {
                        searchingItem1 = true;
                        hidingPlayer1 = false;
                    }
                    else
                    {
                        searchingItem1 = false;
                        statusPlayer1.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage1());
                    }
                }
                if (players1.objectString == tools1.ToString())
                {
                    toolsbool = false;
                    toolsAcquired1 = tools1.ToString();
                    tools1 = "";
                    players1.isChecking = false;
                }
                if (players1.objectString == tools2.ToString())
                {
                    toolsbool1 = false;
                    toolsAcquired1 = tools1.ToString();
                    tools2 = "";
                    players1.isChecking = false;
                }
            }
            else
            {
                searchingItem1 = false;
                statusPlayer1.text = "Wait for 15 seconds ";
                StartCoroutine(buyMessage1());
            }
        }
    }

    public void SearchRandomizer2()
    {
        if (capturedStatus.captured2 == false)
        {
            if (players2.isChecking == true)
            {
                if (players2.objectString == "Master Bed")
                {
                    if (o1 == true)
                    {
                        searchingItem2 = true;
                        hidingPlayer2 = false;
                    }
                    else
                    {
                        searchingItem2 = false;
                        statusPlayer2.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage2());
                    }
                }
                if (players2.objectString == "Leftside Room Bed")
                {
                    if (o2 == true)
                    {
                        searchingItem2 = true;
                        hidingPlayer2 = false;
                    }
                    else
                    {
                        searchingItem2 = false;
                        statusPlayer2.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage2());
                    }
                }
                if (players2.objectString == "Rightside Room Bed")
                {
                    if (o3 == true)
                    {
                        searchingItem2 = true;
                        hidingPlayer2 = false;
                    }
                    else
                    {
                        searchingItem2 = false;
                        statusPlayer2.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage2());
                    }
                }
                if (players2.objectString == "Master Bathroom Medicine Cabinet")
                {
                    if (o4 == true)
                    {
                        searchingItem2 = true;
                        hidingPlayer2 = false;
                    }
                    else
                    {
                        searchingItem2 = false;
                        statusPlayer2.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage2());
                    }
                }
                if (players2.objectString == "Car")
                {
                    if (o5 == true)
                    {
                        searchingItem2 = true;
                        hidingPlayer2 = false;
                    }
                    else
                    {
                        searchingItem2 = false;
                        statusPlayer2.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage2());
                    }
                }
                if (players2.objectString == "Bathroom Medicine Cabinet")
                {
                    if (o6 == true)
                    {
                        searchingItem2 = true;
                        hidingPlayer2 = false;
                    }
                    else
                    {
                        searchingItem2 = false;
                        statusPlayer2.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage2());
                    }
                }
                if (players2.objectString == "Box")
                {
                    if (o7 == true)
                    {
                        searchingItem2 = true;
                        hidingPlayer2 = false;
                    }
                    else
                    {
                        searchingItem2 = false;
                        statusPlayer2.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage2());
                    }
                }
                if (players2.objectString == "Large Sofa")
                {
                    if (o8 == true)
                    {
                        searchingItem2 = true;
                        hidingPlayer2 = false;
                    }
                    else
                    {
                        searchingItem2 = false;
                        statusPlayer2.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage2());
                    }
                }
                if (players2.objectString == "Kitchen Drawer")
                {
                    if (o9 == true)
                    {
                        searchingItem2 = true;
                        hidingPlayer2 = false;
                    }
                    else
                    {
                        searchingItem2 = false;
                        statusPlayer2.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage2());
                    }
                }
                if (players2.objectString == "Table")
                {
                    if (o10 == true)
                    {
                        searchingItem2 = true;
                        hidingPlayer2 = false;
                    }
                    else
                    {
                        searchingItem2 = false;
                        statusPlayer2.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage2());
                    }
                }
                if (players2.objectString == "Plant")
                {
                    if (o11 == true)
                    {
                        searchingItem2 = true;
                        hidingPlayer2 = false;
                    }
                    else
                    {
                        searchingItem2 = false;
                        statusPlayer2.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage2());
                    }
                }
                if (players2.objectString == tools1.ToString())
                {
                    toolsbool = false;
                    toolsAcquired2 = tools1.ToString();
                    tools1 = "";
                    players2.isChecking = false;
                }
                if (players2.objectString == tools2.ToString())
                {
                    toolsbool1 = false;
                    toolsAcquired2 = tools1.ToString();
                    tools2 = "";
                    players2.isChecking = false;
                }
            }
            else
            {
                searchingItem2 = false;
                statusPlayer2.text = "Wait for 15 seconds ";
                StartCoroutine(buyMessage2());
            }
        }
    }

    public void SearchRandomizer3()
    {
        if (capturedStatus.captured3 == false)
        {
            if (players3.isChecking == true)
            {
                if (players3.objectString == "Master Bed")
                {
                    if (o1 == true)
                    {
                        searchingItem3 = true;
                        hidingPlayer3 = false;
                    }
                    else
                    {
                        searchingItem3 = false;
                        statusPlayer3.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage3());
                    }
                }
                if (players3.objectString == "Leftside Room Bed")
                {
                    if (o2 == true)
                    {
                        searchingItem3 = true;
                        hidingPlayer3 = false;
                    }
                    else
                    {
                        searchingItem3 = false;
                        statusPlayer3.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage3());
                    }
                }
                if (players3.objectString == "Rightside Room Bed")
                {
                    if (o3 == true)
                    {
                        searchingItem3 = true;
                        hidingPlayer3 = false;
                    }
                    else
                    {
                        searchingItem3 = false;
                        statusPlayer3.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage3());
                    }
                }
                if (players3.objectString == "Master Bathroom Medicine Cabinet")
                {
                    if (o4 == true)
                    {
                        searchingItem3 = true;
                        hidingPlayer3 = false;
                    }
                    else
                    {
                        searchingItem3 = false;
                        statusPlayer3.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage3());
                    }
                }
                if (players3.objectString == "Car")
                {
                    if (o5 == true)
                    {
                        searchingItem3 = true;
                        hidingPlayer3 = false;
                    }
                    else
                    {
                        searchingItem3 = false;
                        statusPlayer3.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage3());
                    }
                }
                if (players3.objectString == "Bathroom Medicine Cabinet")
                {
                    if (o6 == true)
                    {
                        searchingItem3 = true;
                        hidingPlayer3 = false;
                    }
                    else
                    {
                        searchingItem3 = false;
                        statusPlayer3.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage3());
                    }
                }
                if (players3.objectString == "Box")
                {
                    if (o7 == true)
                    {
                        searchingItem3 = true;
                        hidingPlayer3 = false;
                    }
                    else
                    {
                        searchingItem3 = false;
                        statusPlayer3.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage3());
                    }
                }
                if (players3.objectString == "Large Sofa")
                {
                    if (o8 == true)
                    {
                        searchingItem3 = true;
                        hidingPlayer3 = false;
                    }
                    else
                    {
                        searchingItem3 = false;
                        statusPlayer3.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage3());
                    }
                }
                if (players3.objectString == "Kitchen Drawer")
                {
                    if (o9 == true)
                    {
                        searchingItem3 = true;
                        hidingPlayer3 = false;
                    }
                    else
                    {
                        searchingItem3 = false;
                        statusPlayer3.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage3());
                    }
                }
                if (players3.objectString == "Table")
                {
                    if (o10 == true)
                    {
                        searchingItem3 = true;
                        hidingPlayer3 = false;
                    }
                    else
                    {
                        searchingItem3 = false;
                        statusPlayer3.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage3());
                    }
                }
                if (players3.objectString == "Plant")
                {
                    if (o11 == true)
                    {
                        searchingItem3 = true;
                        hidingPlayer3 = false;
                    }
                    else
                    {
                        searchingItem3 = false;
                        statusPlayer3.text = "Wait for 15 seconds ";
                        StartCoroutine(buyMessage3());
                    }
                }
                if (players3.objectString == tools1.ToString())
                {
                    toolsbool = false;
                    toolsAcquired3 = tools1.ToString();
                    tools1 = "";
                    players3.isChecking = false;
                }
                if (players3.objectString == tools2.ToString())
                {
                    toolsbool1 = false;
                    toolsAcquired3 = tools1.ToString();
                    tools2 = "";
                    players3.isChecking = false;
                }
            }
            else
            {
                searchingItem3 = false;
                statusPlayer3.text = "Wait for 15 seconds ";
                StartCoroutine(buyMessage3());
            }
        }
    }


    public void transaction()
    {
        if (itemName == "Nail")
        {
            if (coinAmounts >= 50)
            {
                coinAmounts = coinAmounts - 50;
                buyInformation.text = "1 Nail Bought";
                nailAmount = nailAmount + 1;
            }
            else
            {
                buyInformation.text = "Not Enough Coin";
            }
        }

        if (itemName == "Garlic")
        {
            if (coinAmounts >= 10)
            {
                coinAmounts = coinAmounts - 10;
                buyInformation.text = "1 Garlic Bought";
                garlicAmount = garlicAmount + 1;
            }
            else
            {
                buyInformation.text = "Not Enough Coin";
            }
        }

        if (itemName == "Onion")
        {
            if (coinAmounts >= 10)
            {
                coinAmounts = coinAmounts - 10;
                buyInformation.text = "1 Onion Bought";
                onionAmount = onionAmount + 1;
            }
            else
            {
                buyInformation.text = "Not Enough Coin";
            }
        }

        if (itemName == "Broom")
        {
            if (coinAmounts >= 90)
            {
                coinAmounts = coinAmounts - 90;
                buyInformation.text = "1 Broom Bought";
                broomAmount = broomAmount + 1;
            }
            else
            {
                buyInformation.text = "Not Enough Coin";
            }
        }

        if (itemName == "Knife")
        {
            if (coinAmounts >= 90)
            {
                coinAmounts = coinAmounts - 90;
                buyInformation.text = "1 Knife Bought";
                knifeAmount = knifeAmount + 1;
            }
            else
            {
                buyInformation.text = "Not Enough Coin";
            }
        }

        if (itemName == "Bottle")
        {
            if (coinAmounts >= 100)
            {
                coinAmounts = coinAmounts - 100;
                buyInformation.text = "1 Bottle Bought";
                bottleAmount = bottleAmount + 1;
            }
            else
            {
                buyInformation.text = "Not Enough Coin";
            }
        }

        if (itemName == "Pan")
        {
            if (coinAmounts >= 110)
            {
                coinAmounts = coinAmounts - 110;
                buyInformation.text = "1 Flashlight Bought";
                panAmount = panAmount + 1;
            }
            else
            {
                buyInformation.text = "Not Enough Coin";
            }
        }

        if (itemName == "MoringaLeaves")
        {
            if (coinAmounts >= 30)
            {
                coinAmounts = coinAmounts - 30;
                buyInformation.text = "1 Moringa Leaves Bought";
                moringaleavesAmount = moringaleavesAmount + 1;
            }
            else
            {
                buyInformation.text = "Not Enough Coin";
            }
        }

        if (itemName == "GooseEgg")
        {
            if (coinAmounts >= 30)
            {
                coinAmounts = coinAmounts - 30;
                buyInformation.text = "1 Goose Egg Bought";
                gooseeggAmount = gooseeggAmount + 1;
            }
            else
            {
                buyInformation.text = "Not Enough Coin";
            }
        }

        if (itemName == "Water")
        {
            if (coinAmounts >= 15)
            {
                coinAmounts = coinAmounts - 15;
                buyInformation.text = "1 Water Bought";
                waterAmount = waterAmount + 1;
            }
            else
            {
                buyInformation.text = "Not Enough Coin";
            }
        }

        if (itemName == "Clam Shell")
        {
            if (coinAmounts >= 70)
            {
                coinAmounts = coinAmounts - 70;
                buyInformation.text = "1 Clam Shell Bought";
                clamshellAmount = clamshellAmount + 1;
            }
            else
            {
                buyInformation.text = "Not Enough Coin";
            }
        }

        if (itemName == "Stick")
        {
            if (coinAmounts >= 5)
            {
                coinAmounts = coinAmounts - 5;
                buyInformation.text = "1 Stick Bought";
                stickAmount = stickAmount + 1;
            }
            else
            {
                buyInformation.text = "Not Enough Coin";
            }
        }

        StartCoroutine(buyInfoDelay());

    }

    public void buyNail()
    {
        itemName = "Nail";
        transaction();
    }

    public void buyGarlic()
    {
        itemName = "Garlic";
        transaction();

    }

    public void buyOnion()
    {
        itemName = "Onion";
        transaction();

    }

    public void buyGooseEgg()
    {
        itemName = "GooseEgg";
        transaction();

    }

    public void buyMoringaLeaves()
    {
        itemName = "MoringaLeaves";
        transaction();

    }

    public void buyBroom()
    {
        itemName = "Broom";
        transaction();

    }

    public void buyKnife()
    {
        itemName = "Knife";
        transaction();

    }

    public void buyClamShell()
    {
        itemName = "Clam Shell";
        transaction();

    }

    public void buyWater()
    {
        itemName = "Water";
        transaction();

    }

    public void buyPan()
    {
        itemName = "Pan";
        transaction();

    }

    public void buyBottle()
    {
        itemName = "Bottle";
        transaction();
    }

    public void buyStick()
    {
        itemName = "Stick";
        transaction();
    }

    public void crafting()
    {
        craftCombination = craftCombination + " " + craftName + " +";
        craftList.text = craftCombination;
    }

    public void craftActivation()
    {
        if (onionCraft == 1)
        {
            if (garlicCraft == 1)
            {
                if (stickCraft == 1)
                {
                    if (nailCraft == 0)
                    {
                        if (waterCraft == 0)
                        {
                            if (bottleCraft == 0)
                            {
                                if (clamshellCraft == 0)
                                {
                                    if (moringaleavesCraft == 0)
                                    {
                                        if (gooseeggCraft == 0)
                                        {
                                            if (broomCraft == 0)
                                            {
                                                if (knifeCraft == 0)
                                                {
                                                    if (panCraft == 0)
                                                    {
                                                        resultCraft.text = "Onion Skewer Crafted!";
                                                        craftList.text = "";
                                                        craftCombination = "";
                                                        craftRemoval();
                                                        if (tools1 == "")
                                                        {
                                                            tools1 = "Onion Skewer";
                                                            toolsbool = true;
                                                        }
                                                        else
                                                        {
                                                            tools2 = "Onion Skewer";
                                                            toolsbool1 = true;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        resultCraft.text = "Failed!";
                                                        craftList.text = "";
                                                        craftCombination = "";
                                                        craftRemoval();
                                                    }
                                                }
                                                else
                                                {
                                                    resultCraft.text = "Failed!";
                                                    craftList.text = "";
                                                    craftCombination = "";
                                                    craftRemoval();
                                                }
                                            }
                                            else
                                            {
                                                resultCraft.text = "Failed!";
                                                craftList.text = "";
                                                craftCombination = "";
                                                craftRemoval();
                                            }
                                        }
                                        else
                                        {
                                            resultCraft.text = "Failed!";
                                            craftList.text = "";
                                            craftCombination = "";
                                            craftRemoval();
                                        }
                                    }
                                    else
                                    {
                                        resultCraft.text = "Failed!";
                                        craftList.text = "";
                                        craftCombination = "";
                                        craftRemoval();
                                    }
                                }
                                else
                                {
                                    resultCraft.text = "Failed!";
                                    craftList.text = "";
                                    craftCombination = "";
                                    craftRemoval();
                                }
                            }
                            else
                            {
                                resultCraft.text = "Failed!";
                                craftList.text = "";
                                craftCombination = "";
                                craftRemoval();
                            }
                        }
                        else
                        {
                            resultCraft.text = "Failed!";
                            craftList.text = "";
                            craftCombination = "";
                            craftRemoval();
                        }
                    }
                    else
                    {
                        resultCraft.text = "Failed!";
                        craftList.text = "";
                        craftCombination = "";
                        craftRemoval();
                    }
                }
                else
                {
                    resultCraft.text = "Failed!";
                    craftList.text = "";
                    craftCombination = "";
                    craftRemoval();
                }
            }
            else
            {
                resultCraft.text = "Failed!";
                craftList.text = "";
                craftCombination = "";
                craftRemoval();
            }
        }
        else if (clamshellCraft == 1)
        {
            if (waterCraft == 1)
            {
                if (onionCraft == 0)
                {
                    if (garlicCraft == 0)
                    {
                        if (stickCraft == 0)
                        {
                            if (nailCraft == 0)
                            {
                                if (bottleCraft == 0)
                                {
                                    if (moringaleavesCraft == 0)
                                    {
                                        if (gooseeggCraft == 0)
                                        {
                                            if (broomCraft == 0)
                                            {
                                                if (knifeCraft == 0)
                                                {
                                                    if (panCraft == 0)
                                                    {
                                                        resultCraft.text = "Whiting Crafted!";
                                                        craftList.text = "";
                                                        craftCombination = "";
                                                        craftRemoval();
                                                        if (tools1 == "")
                                                        {
                                                            tools1 = "Whiting";
                                                            toolsbool = true;
                                                        }
                                                        else
                                                        {
                                                            tools2 = "Whiting";
                                                            toolsbool1 = true;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        resultCraft.text = "Failed!";
                                                        craftList.text = "";
                                                        craftCombination = "";
                                                        craftRemoval();
                                                    }
                                                }
                                                else
                                                {
                                                    resultCraft.text = "Failed!";
                                                    craftList.text = "";
                                                    craftCombination = "";
                                                    craftRemoval();
                                                }
                                            }
                                            else
                                            {
                                                resultCraft.text = "Failed!";
                                                craftList.text = "";
                                                craftCombination = "";
                                                craftRemoval();
                                            }
                                        }
                                        else
                                        {
                                            resultCraft.text = "Failed!";
                                            craftList.text = "";
                                            craftCombination = "";
                                            craftRemoval();
                                        }
                                    }
                                    else
                                    {
                                        resultCraft.text = "Failed!";
                                        craftList.text = "";
                                        craftCombination = "";
                                        craftRemoval();
                                    }
                                }
                                else
                                {
                                    resultCraft.text = "Failed!";
                                    craftList.text = "";
                                    craftCombination = "";
                                    craftRemoval();
                                }
                            }
                            else
                            {
                                resultCraft.text = "Failed!";
                                craftList.text = "";
                                craftCombination = "";
                                craftRemoval();
                            }
                        }
                        else
                        {
                            resultCraft.text = "Failed!";
                            craftList.text = "";
                            craftCombination = "";
                            craftRemoval();
                        }
                    }
                    else
                    {
                        resultCraft.text = "Failed!";
                        craftList.text = "";
                        craftCombination = "";
                        craftRemoval();
                    }
                }
                else
                {
                    resultCraft.text = "Failed!";
                    craftList.text = "";
                    craftCombination = "";
                    craftRemoval();
                }
            }
            else
            {
                resultCraft.text = "Failed!";
                craftList.text = "";
                craftCombination = "";
                craftRemoval();
            }
        }
        else if (waterCraft == 1)
        {
            if (bottleCraft == 1)
            {
                if (onionCraft == 0)
                {
                    if (garlicCraft == 0)
                    {
                        if (nailCraft == 0)
                        {
                            if (stickCraft == 0)
                            {
                                if (moringaleavesCraft == 0)
                                {
                                    if (gooseeggCraft == 0)
                                    {
                                        if (knifeCraft == 0)
                                        {
                                            if (panCraft == 0)
                                            {
                                                if (broomCraft == 0)
                                                {
                                                    resultCraft.text = "Water Bottle Crafted!";
                                                    craftList.text = "";
                                                    craftCombination = "";
                                                    craftRemoval();
                                                    if (tools1 == "")
                                                    {
                                                        tools1 = "Water Bottle";
                                                        toolsbool = true;
                                                    }
                                                    else
                                                    {
                                                        tools2 = "Water Bottle";
                                                        toolsbool1 = true;
                                                    }
                                                }
                                                else
                                                {
                                                    resultCraft.text = "Failed!";
                                                    craftList.text = "";
                                                    craftCombination = "";
                                                    craftRemoval();
                                                }
                                            }
                                            else
                                            {
                                                resultCraft.text = "Failed!";
                                                craftList.text = "";
                                                craftCombination = "";
                                                craftRemoval();
                                            }
                                        }
                                        else
                                        {
                                            resultCraft.text = "Failed!";
                                            craftList.text = "";
                                            craftCombination = "";
                                            craftRemoval();
                                        }
                                    }
                                    else
                                    {
                                        resultCraft.text = "Failed!";
                                        craftList.text = "";
                                        craftCombination = "";
                                        craftRemoval();
                                    }
                                }
                                else
                                {
                                    resultCraft.text = "Failed!";
                                    craftList.text = "";
                                    craftCombination = "";
                                    craftRemoval();
                                }
                            }
                            else
                            {
                                resultCraft.text = "Failed!";
                                craftList.text = "";
                                craftCombination = "";
                                craftRemoval();
                            }
                        }
                        else
                        {
                            resultCraft.text = "Failed!";
                            craftList.text = "";
                            craftCombination = "";
                            craftRemoval();
                        }
                    }
                    else
                    {
                        resultCraft.text = "Failed!";
                        craftList.text = "";
                        craftCombination = "";
                        craftRemoval();
                    }
                }
                else
                {
                    resultCraft.text = "Failed!";
                    craftList.text = "";
                    craftCombination = "";
                    craftRemoval();
                }
            }
            else
            {
                resultCraft.text = "Failed!";
                craftList.text = "";
                craftCombination = "";
                craftRemoval();
            }
        }
        else if (nailCraft == 1)
        {
            if (bottleCraft == 0)
            {
                if (onionCraft == 0)
                {
                    if (garlicCraft == 0)
                    {
                        if (waterCraft == 0)
                        {
                            if (stickCraft == 0)
                            {
                                if (moringaleavesCraft == 0)
                                {
                                    if (gooseeggCraft == 0)
                                    {
                                        if (knifeCraft == 0)
                                        {
                                            if (panCraft == 0)
                                            {
                                                if (broomCraft == 0)
                                                {
                                                    resultCraft.text = "Metal Nails Crafted!";
                                                    craftList.text = "";
                                                    craftCombination = "";
                                                    craftRemoval();
                                                    if (tools1 == "")
                                                    {
                                                        tools1 = "Metal Nails";
                                                        toolsbool = true;
                                                    }
                                                    else
                                                    {
                                                        tools2 = "Metal Nails";
                                                        toolsbool1 = true;
                                                    }
                                                }
                                                else
                                                {
                                                    resultCraft.text = "Failed!";
                                                    craftList.text = "";
                                                    craftCombination = "";
                                                    craftRemoval();
                                                }
                                            }
                                            else
                                            {
                                                resultCraft.text = "Failed!";
                                                craftList.text = "";
                                                craftCombination = "";
                                                craftRemoval();
                                            }
                                        }
                                        else
                                        {
                                            resultCraft.text = "Failed!";
                                            craftList.text = "";
                                            craftCombination = "";
                                            craftRemoval();
                                        }
                                    }
                                    else
                                    {
                                        resultCraft.text = "Failed!";
                                        craftList.text = "";
                                        craftCombination = "";
                                        craftRemoval();
                                    }
                                }
                                else
                                {
                                    resultCraft.text = "Failed!";
                                    craftList.text = "";
                                    craftCombination = "";
                                    craftRemoval();
                                }
                            }
                            else
                            {
                                resultCraft.text = "Failed!";
                                craftList.text = "";
                                craftCombination = "";
                                craftRemoval();
                            }
                        }
                        else
                        {
                            resultCraft.text = "Failed!";
                            craftList.text = "";
                            craftCombination = "";
                            craftRemoval();
                        }
                    }
                    else
                    {
                        resultCraft.text = "Failed!";
                        craftList.text = "";
                        craftCombination = "";
                        craftRemoval();
                    }
                }
                else
                {
                    resultCraft.text = "Failed!";
                    craftList.text = "";
                    craftCombination = "";
                    craftRemoval();
                }
            }
            else
            {
                resultCraft.text = "Failed!";
                craftList.text = "";
                craftCombination = "";
                craftRemoval();
            }
        }
        else if (moringaleavesCraft == 1)
        {
            if (bottleCraft == 0)
            {
                if (onionCraft == 0)
                {
                    if (garlicCraft == 0)
                    {
                        if (nailCraft == 0)
                        {
                            if (stickCraft == 0)
                            {
                                if (waterCraft == 0)
                                {
                                    if (gooseeggCraft == 0)
                                    {
                                        if (knifeCraft == 0)
                                        {
                                            if (panCraft == 0)
                                            {
                                                if (broomCraft == 0)
                                                {
                                                    resultCraft.text = "Moringa Leaves Crafted!";
                                                    craftList.text = "";
                                                    craftCombination = "";
                                                    craftRemoval();
                                                    if (tools1 == "")
                                                    {
                                                        tools1 = "Moringa Leaves";
                                                        toolsbool = true;
                                                    }
                                                    else
                                                    {
                                                        tools2 = "Moringa Leaves";
                                                        toolsbool1 = true;
                                                    }
                                                }
                                                else
                                                {
                                                    resultCraft.text = "Failed!";
                                                    craftList.text = "";
                                                    craftCombination = "";
                                                    craftRemoval();
                                                }
                                            }
                                            else
                                            {
                                                resultCraft.text = "Failed!";
                                                craftList.text = "";
                                                craftCombination = "";
                                                craftRemoval();
                                            }
                                        }
                                        else
                                        {
                                            resultCraft.text = "Failed!";
                                            craftList.text = "";
                                            craftCombination = "";
                                            craftRemoval();
                                        }
                                    }
                                    else
                                    {
                                        resultCraft.text = "Failed!";
                                        craftList.text = "";
                                        craftCombination = "";
                                        craftRemoval();
                                    }
                                }
                                else
                                {
                                    resultCraft.text = "Failed!";
                                    craftList.text = "";
                                    craftCombination = "";
                                    craftRemoval();
                                }
                            }
                            else
                            {
                                resultCraft.text = "Failed!";
                                craftList.text = "";
                                craftCombination = "";
                                craftRemoval();
                            }
                        }
                        else
                        {
                            resultCraft.text = "Failed!";
                            craftList.text = "";
                            craftCombination = "";
                            craftRemoval();
                        }
                    }
                    else
                    {
                        resultCraft.text = "Failed!";
                        craftList.text = "";
                        craftCombination = "";
                        craftRemoval();
                    }
                }
                else
                {
                    resultCraft.text = "Failed!";
                    craftList.text = "";
                    craftCombination = "";
                    craftRemoval();
                }
            }
            else
            {
                resultCraft.text = "Failed!";
                craftList.text = "";
                craftCombination = "";
                craftRemoval();
            }
        }
        else if (gooseeggCraft == 1)
        {
            if (bottleCraft == 0)
            {
                if (onionCraft == 0)
                {
                    if (garlicCraft == 0)
                    {
                        if (nailCraft == 0)
                        {
                            if (stickCraft == 0)
                            {
                                if (moringaleavesCraft == 0)
                                {
                                    if (waterCraft == 0)
                                    {
                                        if (knifeCraft == 0)
                                        {
                                            if (panCraft == 0)
                                            {
                                                if (broomCraft == 0)
                                                {
                                                    resultCraft.text = "Goose Egg Crafted!";
                                                    craftList.text = "";
                                                    craftCombination = "";
                                                    craftRemoval();
                                                    if (tools1 == "")
                                                    {
                                                        tools1 = "Goose Egg";
                                                        toolsbool = true;
                                                    }
                                                    else
                                                    {
                                                        tools2 = "Goose Egg";
                                                        toolsbool1 = true;
                                                    }
                                                }
                                                else
                                                {
                                                    resultCraft.text = "Failed!";
                                                    craftList.text = "";
                                                    craftCombination = "";
                                                    craftRemoval();
                                                }
                                            }
                                            else
                                            {
                                                resultCraft.text = "Failed!";
                                                craftList.text = "";
                                                craftCombination = "";
                                                craftRemoval();
                                            }
                                        }
                                        else
                                        {
                                            resultCraft.text = "Failed!";
                                            craftList.text = "";
                                            craftCombination = "";
                                            craftRemoval();
                                        }
                                    }
                                    else
                                    {
                                        resultCraft.text = "Failed!";
                                        craftList.text = "";
                                        craftCombination = "";
                                        craftRemoval();
                                    }
                                }
                                else
                                {
                                    resultCraft.text = "Failed!";
                                    craftList.text = "";
                                    craftCombination = "";
                                    craftRemoval();
                                }
                            }
                            else
                            {
                                resultCraft.text = "Failed!";
                                craftList.text = "";
                                craftCombination = "";
                                craftRemoval();
                            }
                        }
                        else
                        {
                            resultCraft.text = "Failed!";
                            craftList.text = "";
                            craftCombination = "";
                            craftRemoval();
                        }
                    }
                    else
                    {
                        resultCraft.text = "Failed!";
                        craftList.text = "";
                        craftCombination = "";
                        craftRemoval();
                    }
                }
                else
                {
                    resultCraft.text = "Failed!";
                    craftList.text = "";
                    craftCombination = "";
                    craftRemoval();
                }
            }
            else
            {
                resultCraft.text = "Failed!";
                craftList.text = "";
                craftCombination = "";
                craftRemoval();
            }
        }
        else if (broomCraft == 1)
        {
            if (bottleCraft == 0)
            {
                if (onionCraft == 0)
                {
                    if (garlicCraft == 0)
                    {
                        if (nailCraft == 0)
                        {
                            if (stickCraft == 0)
                            {
                                if (moringaleavesCraft == 0)
                                {
                                    if (gooseeggCraft == 0)
                                    {
                                        if (knifeCraft == 0)
                                        {
                                            if (panCraft == 0)
                                            {
                                                if (waterCraft == 0)
                                                {
                                                    resultCraft.text = "Broom Crafted!";
                                                    craftList.text = "";
                                                    craftCombination = "";
                                                    craftRemoval();
                                                    if (tools1 == "")
                                                    {
                                                        tools1 = "Broom";
                                                        toolsbool = true;
                                                    }
                                                    else
                                                    {
                                                        tools2 = "Broom";
                                                        toolsbool1 = true;
                                                    }
                                                }
                                                else
                                                {
                                                    resultCraft.text = "Failed!";
                                                    craftList.text = "";
                                                    craftCombination = "";
                                                    craftRemoval();
                                                }
                                            }
                                            else
                                            {
                                                resultCraft.text = "Failed!";
                                                craftList.text = "";
                                                craftCombination = "";
                                                craftRemoval();
                                            }
                                        }
                                        else
                                        {
                                            resultCraft.text = "Failed!";
                                            craftList.text = "";
                                            craftCombination = "";
                                            craftRemoval();
                                        }
                                    }
                                    else
                                    {
                                        resultCraft.text = "Failed!";
                                        craftList.text = "";
                                        craftCombination = "";
                                        craftRemoval();
                                    }
                                }
                                else
                                {
                                    resultCraft.text = "Failed!";
                                    craftList.text = "";
                                    craftCombination = "";
                                    craftRemoval();
                                }
                            }
                            else
                            {
                                resultCraft.text = "Failed!";
                                craftList.text = "";
                                craftCombination = "";
                                craftRemoval();
                            }
                        }
                        else
                        {
                            resultCraft.text = "Failed!";
                            craftList.text = "";
                            craftCombination = "";
                            craftRemoval();
                        }
                    }
                    else
                    {
                        resultCraft.text = "Failed!";
                        craftList.text = "";
                        craftCombination = "";
                        craftRemoval();
                    }
                }
                else
                {
                    resultCraft.text = "Failed!";
                    craftList.text = "";
                    craftCombination = "";
                    craftRemoval();
                }
            }
            else
            {
                resultCraft.text = "Failed!";
                craftList.text = "";
                craftCombination = "";
                craftRemoval();
            }
        }
        else if (knifeCraft == 1)
        {
            if (bottleCraft == 0)
            {
                if (onionCraft == 0)
                {
                    if (garlicCraft == 0)
                    {
                        if (nailCraft == 0)
                        {
                            if (stickCraft == 0)
                            {
                                if (moringaleavesCraft == 0)
                                {
                                    if (broomCraft == 0)
                                    {
                                        if (waterCraft == 0)
                                        {
                                            if (panCraft == 0)
                                            {
                                                if (gooseeggCraft == 0)
                                                {
                                                    resultCraft.text = "Knife Crafted!";
                                                    craftList.text = "";
                                                    craftCombination = "";
                                                    craftRemoval();
                                                    if (tools1 == "")
                                                    {
                                                        tools1 = "Knife";
                                                        toolsbool = true;
                                                    }
                                                    else
                                                    {
                                                        tools2 = "Knife";
                                                        toolsbool1 = true;
                                                    }
                                                }
                                                else
                                                {
                                                    resultCraft.text = "Failed!";
                                                    craftList.text = "";
                                                    craftCombination = "";
                                                    craftRemoval();
                                                }
                                            }
                                            else
                                            {
                                                resultCraft.text = "Failed!";
                                                craftList.text = "";
                                                craftCombination = "";
                                                craftRemoval();
                                            }
                                        }
                                        else
                                        {
                                            resultCraft.text = "Failed!";
                                            craftList.text = "";
                                            craftCombination = "";
                                            craftRemoval();
                                        }
                                    }
                                    else
                                    {
                                        resultCraft.text = "Failed!";
                                        craftList.text = "";
                                        craftCombination = "";
                                        craftRemoval();
                                    }
                                }
                                else
                                {
                                    resultCraft.text = "Failed!";
                                    craftList.text = "";
                                    craftCombination = "";
                                    craftRemoval();
                                }
                            }
                            else
                            {
                                resultCraft.text = "Failed!";
                                craftList.text = "";
                                craftCombination = "";
                                craftRemoval();
                            }
                        }
                        else
                        {
                            resultCraft.text = "Failed!";
                            craftList.text = "";
                            craftCombination = "";
                            craftRemoval();
                        }
                    }
                    else
                    {
                        resultCraft.text = "Failed!";
                        craftList.text = "";
                        craftCombination = "";
                        craftRemoval();
                    }
                }
                else
                {
                    resultCraft.text = "Failed!";
                    craftList.text = "";
                    craftCombination = "";
                    craftRemoval();
                }
            }
            else
            {
                resultCraft.text = "Failed!";
                craftList.text = "";
                craftCombination = "";
                craftRemoval();
            }
        }
        else if (panCraft == 1)
        {
            if (bottleCraft == 0)
            {
                if (onionCraft == 0)
                {
                    if (garlicCraft == 0)
                    {
                        if (nailCraft == 0)
                        {
                            if (stickCraft == 0)
                            {
                                if (moringaleavesCraft == 0)
                                {
                                    if (broomCraft == 0)
                                    {
                                        if (waterCraft == 0)
                                        {
                                            if (knifeCraft == 0)
                                            {
                                                if (gooseeggCraft == 0)
                                                {
                                                    resultCraft.text = "Flashlight";
                                                    craftList.text = "";
                                                    craftCombination = "";
                                                    craftRemoval();
                                                    if (tools1 == "")
                                                    {
                                                        tools1 = "Flashlight";
                                                        toolsbool = true;
                                                    }
                                                    else
                                                    {
                                                        tools2 = "Flashlight";
                                                        toolsbool1 = true;
                                                    }
                                                }
                                                else
                                                {
                                                    resultCraft.text = "Failed!";
                                                    craftList.text = "";
                                                    craftCombination = "";
                                                    craftRemoval();
                                                }
                                            }
                                            else
                                            {
                                                resultCraft.text = "Failed!";
                                                craftList.text = "";
                                                craftCombination = "";
                                                craftRemoval();
                                            }
                                        }
                                        else
                                        {
                                            resultCraft.text = "Failed!";
                                            craftList.text = "";
                                            craftCombination = "";
                                            craftRemoval();
                                        }
                                    }
                                    else
                                    {
                                        resultCraft.text = "Failed!";
                                        craftList.text = "";
                                        craftCombination = "";
                                        craftRemoval();
                                    }
                                }
                                else
                                {
                                    resultCraft.text = "Failed!";
                                    craftList.text = "";
                                    craftCombination = "";
                                    craftRemoval();
                                }
                            }
                            else
                            {
                                resultCraft.text = "Failed!";
                                craftList.text = "";
                                craftCombination = "";
                                craftRemoval();
                            }
                        }
                        else
                        {
                            resultCraft.text = "Failed!";
                            craftList.text = "";
                            craftCombination = "";
                            craftRemoval();
                        }
                    }
                    else
                    {
                        resultCraft.text = "Failed!";
                        craftList.text = "";
                        craftCombination = "";
                        craftRemoval();
                    }
                }
                else
                {
                    resultCraft.text = "Failed!";
                    craftList.text = "";
                    craftCombination = "";
                    craftRemoval();
                }
            }
            else
            {
                resultCraft.text = "Failed!";
                craftList.text = "";
                craftCombination = "";
                craftRemoval();
            }
        }
        else
        {
            resultCraft.text = "Failed!";
            craftList.text = "";
            craftCombination = "";
            craftRemoval();
        }
    }


    public void craftNail()
    {
        if (nailAmount > 0)
        {
            craftName = "Nail";
            nailCraft = nailCraft + 1;
            nailAmount = nailAmount - 1;
            crafting();
        }
    }

    public void craftGarlic()
    {
        if (garlicAmount > 0)
        {
            craftName = "Garlic";
            garlicCraft = garlicCraft + 1;
            garlicAmount = garlicAmount - 1;
            crafting();
        }
    }

    public void craftOnion()
    {
        if (onionAmount > 0)
        {
            craftName = "Onion";
            onionCraft = onionCraft + 1;
            onionAmount = onionAmount - 1;
            crafting();
        }
    }

    public void craftGooseEgg()
    {
        if (gooseeggAmount > 0)
        {
            craftName = "Goose Egg";
            gooseeggCraft = gooseeggCraft + 1;
            gooseeggAmount = gooseeggAmount - 1;
            crafting();
        }
    }

    public void craftMoringaLeaves()
    {
        if (moringaleavesAmount > 0)
        {
            craftName = "Moringa Leaves";
            moringaleavesCraft = moringaleavesCraft + 1;
            moringaleavesAmount = moringaleavesAmount - 1;
            crafting();
        }
    }

    public void craftBroom()
    {
        if (broomAmount > 0)
        {
            craftName = "Broom";
            broomCraft = broomCraft + 1;
            broomAmount = broomAmount - 1;
            crafting();
        }
    }

    public void craftKnife()
    {
        if (knifeAmount > 0)
        {
            craftName = "Knife";
            knifeCraft = knifeCraft + 1;
            knifeAmount = knifeAmount - 1;
            crafting();
        }
    }

    public void craftClamShell()
    {
        if (clamshellAmount > 0)
        {
            craftName = "Clam Shell";
            clamshellCraft = clamshellCraft + 1;
            clamshellAmount = clamshellAmount - 1;
            crafting();
        }
    }

    public void craftWater()
    {
        if (waterAmount > 0)
        {
            craftName = "Water";
            waterCraft = waterCraft + 1;
            waterAmount = waterAmount - 1;
            crafting();
        }
    }

    public void craftPan()
    {
        if (panAmount > 0)
        {
            craftName = "Flashlight";
            panCraft = panCraft + 1;
            panAmount = panAmount - 1;
            crafting();
        }
    }

    public void craftBottle()
    {
        if (bottleAmount > 0)
        {
            craftName = "Bottle";
            bottleCraft = bottleCraft + 1;
            bottleAmount = bottleAmount - 1;
            crafting();
        }
    }

    public void craftStick()
    {
        if (stickAmount > 0)
        {
            craftName = "Stick";
            stickCraft = stickCraft + 1;
            stickAmount = stickAmount - 1;
            crafting();
        }
    }

    public void hidingActivation()
    {

        if (capturedStatus.captured == false)
        {
            if (players.isChecking == true)
            {
                if (hidingPlayer == false)
                {
                    playerSprite.color = new Color(1f, 1f, 1f, 0.25f);
                    hidingPlayer = true;
                    searchingItem = false;
                }
                else
                {
                    hidingPlayer = false;
                    playerSprite.color = new Color(1f, 1f, 1f, 1f);
                }
            }
            else
            {
                hidingPlayer = false;
                playerSprite.color = new Color(1f, 1f, 1f, 1f);
            }
        }

    }

    public void hidingActivation1()
    {

        if (capturedStatus.captured1 == false)
        {
            if (players1.isChecking == true)
            {
                if (hidingPlayer1 == false)
                {
                    playerSprite1.color = new Color(1f, 1f, 1f, 0.25f);
                    hidingPlayer1 = true;
                    searchingItem1 = false;
                }
                else
                {
                    hidingPlayer1 = false;
                    playerSprite1.color = new Color(1f, 1f, 1f, 1f);
                }
            }
            else
            {
                hidingPlayer1 = false;
                playerSprite1.color = new Color(1f, 1f, 1f, 1f);
            }
        }

    }

    public void hidingActivation2()
    {

        if (capturedStatus.captured2 == false)
        {
            if (players2.isChecking == true)
            {
                if (hidingPlayer2 == false)
                {
                    playerSprite2.color = new Color(1f, 1f, 1f, 0.25f);
                    hidingPlayer2 = true;
                    searchingItem2 = false;
                }
                else
                {
                    hidingPlayer2 = false;
                    playerSprite2.color = new Color(1f, 1f, 1f, 1f);
                }
            }
            else
            {
                hidingPlayer2 = false;
                playerSprite2.color = new Color(1f, 1f, 1f, 1f);
            }
        }

    }

    public void hidingActivation3()
    {

        if (capturedStatus.captured3 == false)
        {
            if (players3.isChecking == true)
            {
                if (hidingPlayer3 == false)
                {
                    playerSprite3.color = new Color(1f, 1f, 1f, 0.25f);
                    hidingPlayer3 = true;
                    searchingItem2 = false;
                }
                else
                {
                    hidingPlayer3 = false;
                    playerSprite3.color = new Color(1f, 1f, 1f, 1f);
                }
            }
            else
            {
                hidingPlayer3 = false;
                playerSprite3.color = new Color(1f, 1f, 1f, 1f);
            }
        }

    }

    public void craftRemoval()
    {
        onionCraft = 0;
        garlicCraft = 0;
        nailCraft = 0;
        knifeCraft = 0;
        panCraft = 0;
        waterCraft = 0;
        bottleCraft = 0;
        moringaleavesCraft = 0;
        gooseeggCraft = 0;
        clamshellCraft = 0;
        broomCraft = 0;
        stickCraft = 0;
    }


    public IEnumerator coinAmount()
    {
        randomValue = Random.Range(0, 100.0f);

        if (randomValue < 75f)
        {
            coinAmounts = coinAmounts + 15;
            statusPlayer.text = "You got 15 coin";
        }
        else if (randomValue > 75f && randomValue < 85f)
        {
            coinAmounts = coinAmounts + 20;
            statusPlayer.text = "You got 20 coin";
        }
        else if (randomValue > 85f && randomValue < 95f)
        {
            coinAmounts = coinAmounts + 25;
            statusPlayer.text = "You got 25 coin";
        }
        else if (randomValue > 95f && randomValue < 100f)
        {
            coinAmounts = coinAmounts + 30;
            statusPlayer.text = "You got 30 coin";
        }

        if (players.objectString == "Master Bed")
        {
            o1 = false;
        }
        else if (players.objectString == "Leftside Room Bed")
        {
            o2 = false;
        }
        else if (players.objectString == "Rightside Room Bed")
        {
            o3 = false;
        }
        else if (players.objectString == "Master Bedroom Medicine Cabinet")
        {
            o4 = false;
        }
        else if (players.objectString == "Car")
        {
            o5 = false;
        }
        else if (players.objectString == "Bathroom Medicine Cabinet")
        {
            o6 = false;
        }
        else if (players.objectString == "Box")
        {
            o7 = false;
        }
        else if (players.objectString == "Large Sofa")
        {
            o8 = false;
        }
        else if (players.objectString == "Kitchen Drawer")
        {
            o9 = false;
        }
        else if (players.objectString == "Table")
        {
            o10 = false;
        }
        else if (players.objectString == "Plant")
        {
            o11 = false;
        }
        else
        {

        }

        StartCoroutine(cooldownSearch());

        statusPlayer.enabled = true;
        yield return new WaitForSeconds(2.0f);
        statusPlayer.enabled = false;
    }

    public IEnumerator coinAmount1()
    {
        randomValue1 = Random.Range(0, 100.0f);

        if (randomValue1 < 75f)
        {
            coinAmounts = coinAmounts + 15;
            statusPlayer1.text = "You got 15 coin";
        }
        else if (randomValue1 > 75f && randomValue1 < 85f)
        {
            coinAmounts = coinAmounts + 20;
            statusPlayer1.text = "You got 20 coin";
        }
        else if (randomValue1 > 85f && randomValue1 < 95f)
        {
            coinAmounts = coinAmounts + 25;
            statusPlayer1.text = "You got 25 coin";
        }
        else if (randomValue1 > 95f && randomValue1 < 100f)
        {
            coinAmounts = coinAmounts + 30;
            statusPlayer1.text = "You got 30 coin";
        }

        if (players1.objectString == "Master Bed")
        {
            o1 = false;
        }
        else if (players1.objectString == "Leftside Room Bed")
        {
            o2 = false;
        }
        else if (players1.objectString == "Rightside Room Bed")
        {
            o3 = false;
        }
        else if (players1.objectString == "Master Bedroom Medicine Cabinet")
        {
            o4 = false;
        }
        else if (players1.objectString == "Car")
        {
            o5 = false;
        }
        else if (players1.objectString == "Bathroom Medicine Cabinet")
        {
            o6 = false;
        }
        else if (players1.objectString == "Box")
        {
            o7 = false;
        }
        else if (players1.objectString == "Large Sofa")
        {
            o8 = false;
        }
        else if (players1.objectString == "Kitchen Drawer")
        {
            o9 = false;
        }
        else if (players1.objectString == "Table")
        {
            o10 = false;
        }
        else if (players1.objectString == "Plant")
        {
            o11 = false;
        }
        else
        {

        }

        StartCoroutine(cooldownSearch());

        statusPlayer1.enabled = true;
        yield return new WaitForSeconds(2.0f);
        statusPlayer1.enabled = false;
    }

    public IEnumerator coinAmount2()
    {
        randomValue2 = Random.Range(0, 100.0f);

        if (randomValue2 < 75f)
        {
            coinAmounts = coinAmounts + 15;
            statusPlayer2.text = "You got 15 coin";
        }
        else if (randomValue2 > 75f && randomValue2 < 85f)
        {
            coinAmounts = coinAmounts + 20;
            statusPlayer2.text = "You got 20 coin";
        }
        else if (randomValue2 > 85f && randomValue2 < 95f)
        {
            coinAmounts = coinAmounts + 25;
            statusPlayer2.text = "You got 25 coin";
        }
        else if (randomValue2 > 95f && randomValue2 < 100f)
        {
            coinAmounts = coinAmounts + 30;
            statusPlayer2.text = "You got 30 coin";
        }

        if (players2.objectString == "Master Bed")
        {
            o1 = false;
        }
        else if (players2.objectString == "Leftside Room Bed")
        {
            o2 = false;
        }
        else if (players2.objectString == "Rightside Room Bed")
        {
            o3 = false;
        }
        else if (players2.objectString == "Master Bedroom Medicine Cabinet")
        {
            o4 = false;
        }
        else if (players2.objectString == "Car")
        {
            o5 = false;
        }
        else if (players2.objectString == "Bathroom Medicine Cabinet")
        {
            o6 = false;
        }
        else if (players2.objectString == "Box")
        {
            o7 = false;
        }
        else if (players2.objectString == "Large Sofa")
        {
            o8 = false;
        }
        else if (players2.objectString == "Kitchen Drawer")
        {
            o9 = false;
        }
        else if (players2.objectString == "Table")
        {
            o10 = false;
        }
        else if (players2.objectString == "Plant")
        {
            o11 = false;
        }
        else
        {

        }

        StartCoroutine(cooldownSearch());

        statusPlayer2.enabled = true;
        yield return new WaitForSeconds(2.0f);
        statusPlayer2.enabled = false;
    }

    public IEnumerator coinAmount3()
    {
        randomValue3 = Random.Range(0, 100.0f);

        if (randomValue3 < 75f)
        {
            coinAmounts = coinAmounts + 15;
            statusPlayer3.text = "You got 15 coin";
        }
        else if (randomValue3 > 75f && randomValue3 < 85f)
        {
            coinAmounts = coinAmounts + 20;
            statusPlayer3.text = "You got 20 coin";
        }
        else if (randomValue3 > 85f && randomValue3 < 95f)
        {
            coinAmounts = coinAmounts + 25;
            statusPlayer3.text = "You got 25 coin";
        }
        else if (randomValue3 > 95f && randomValue3 < 100f)
        {
            coinAmounts = coinAmounts + 30;
            statusPlayer3.text = "You got 30 coin";
        }

        if (players3.objectString == "Master Bed")
        {
            o1 = false;
        }
        else if (players3.objectString == "Leftside Room Bed")
        {
            o2 = false;
        }
        else if (players3.objectString == "Rightside Room Bed")
        {
            o3 = false;
        }
        else if (players3.objectString == "Master Bedroom Medicine Cabinet")
        {
            o4 = false;
        }
        else if (players3.objectString == "Car")
        {
            o5 = false;
        }
        else if (players3.objectString == "Bathroom Medicine Cabinet")
        {
            o6 = false;
        }
        else if (players3.objectString == "Box")
        {
            o7 = false;
        }
        else if (players3.objectString == "Large Sofa")
        {
            o8 = false;
        }
        else if (players3.objectString == "Kitchen Drawer")
        {
            o9 = false;
        }
        else if (players3.objectString == "Table")
        {
            o10 = false;
        }
        else if (players3.objectString == "Plant")
        {
            o11 = false;
        }
        else
        {

        }

        StartCoroutine(cooldownSearch());

        statusPlayer3.enabled = true;
        yield return new WaitForSeconds(2.0f);
        statusPlayer3.enabled = false;
    }

    public IEnumerator buyInfoDelay()
    {
        buyInformation.enabled = true;
        yield return new WaitForSeconds(2.0f);
        buyInformation.enabled = false;
    }

    public IEnumerator buyMessage()
    {
        statusPlayer.enabled = true;
        yield return new WaitForSeconds(2.0f);
        statusPlayer.enabled = false;
    }

    public IEnumerator buyMessage1()
    {
        statusPlayer1.enabled = true;
        yield return new WaitForSeconds(2.0f);
        statusPlayer1.enabled = false;
    }

    public IEnumerator buyMessage2()
    {
        statusPlayer2.enabled = true;
        yield return new WaitForSeconds(2.0f);
        statusPlayer2.enabled = false;
    }

    public IEnumerator buyMessage3()
    {
        statusPlayer3.enabled = true;
        yield return new WaitForSeconds(2.0f);
        statusPlayer3.enabled = false;
    }

    public IEnumerator cooldownSearch()
    {
        if (o1 == false)
        {
            yield return new WaitForSeconds(15f);
            o1 = true;
        }
        if (o2 == false)
        {
            yield return new WaitForSeconds(15f);
            o2 = true;
        }
        if (o3 == false)
        {
            yield return new WaitForSeconds(15f);
            o3 = true;
        }
        if (o4 == false)
        {
            yield return new WaitForSeconds(15f);
            o4 = true;
        }
        if (o5 == false)
        {
            yield return new WaitForSeconds(15f);
            o5 = true;
        }
        if (o6 == false)
        {
            yield return new WaitForSeconds(15f);
            o6 = true;
        }
        if (o7 == false)
        {
            yield return new WaitForSeconds(15f);
            o7 = true;
        }
        if (o8 == false)
        {
            yield return new WaitForSeconds(15f);
            o8 = true;
        }
        if (o9 == false)
        {
            yield return new WaitForSeconds(15f);
            o9 = true;
        }
        if (o10 == false)
        {
            yield return new WaitForSeconds(15f);
            o10 = true;
        }
        if (o11 == false)
        {
            yield return new WaitForSeconds(15f);
            o11 = true;
        }

        
    }
    
}
