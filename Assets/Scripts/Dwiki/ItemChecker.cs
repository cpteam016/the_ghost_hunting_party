using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemChecker : MonoBehaviour
{
    public string objectString;
    public bool isChecking;
    public string playerName;
    public InventoryStatus inventoryStatus;
    public PlayerStatus playerStatus;
    public GameObject bedObjek;
    public GameObject bed1Objek;
    public GameObject bed2Objek;
    public GameObject masterbedroomSink;
    public GameObject carGarage;
    public GameObject bathroomSink;
    public GameObject boxStorage;
    public GameObject sofaLiving;
    public GameObject cabinetKitchen;
    public GameObject tableDining;
    public GameObject plant;
    public GameObject tools1;
    public GameObject tools2;
    private float parameterBed;
    private float parameterBed1;
    private float parameterBed2;
    private float parameterBed3;
    private float parameterBed4;
    private float parameterBed5;
    private float parameterBed6;
    private float parameterBed7;
    private float parameterBed8;
    private float parameterBed9;
    private float parameterBed10;
    private float parameterBed11;
    private float parameterBed12;
    public string playername;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        parameterBed = Vector2.Distance(gameObject.transform.position, bedObjek.transform.position);
        parameterBed1 = Vector2.Distance(gameObject.transform.position, bed1Objek.transform.position);
        parameterBed2 = Vector2.Distance(gameObject.transform.position, bed2Objek.transform.position);
        parameterBed3 = Vector2.Distance(gameObject.transform.position, masterbedroomSink.transform.position);
        parameterBed4 = Vector2.Distance(gameObject.transform.position, carGarage.transform.position);
        parameterBed5 = Vector2.Distance(gameObject.transform.position, bathroomSink.transform.position);
        parameterBed6 = Vector2.Distance(gameObject.transform.position, boxStorage.transform.position);
        parameterBed7 = Vector2.Distance(gameObject.transform.position, sofaLiving.transform.position);
        parameterBed8 = Vector2.Distance(gameObject.transform.position, cabinetKitchen.transform.position);
        parameterBed9 = Vector2.Distance(gameObject.transform.position, tableDining.transform.position);
        parameterBed10 = Vector2.Distance(gameObject.transform.position, plant.transform.position);
        parameterBed11 = Vector2.Distance(gameObject.transform.position, tools1.transform.position);
        parameterBed12 = Vector2.Distance(gameObject.transform.position, tools2.transform.position);

            if (playername == "P1"){
                if(playerStatus.captured == false){
            if (parameterBed < 2){
                isChecking = true;
                objectString = "Master Bed";
            }else if (parameterBed1 < 2){
                isChecking = true;
                objectString = "Leftside Room Bed";
            }else if (parameterBed2 < 2){
                isChecking = true;
                objectString = "Rightside Room Bed";
            }else if (parameterBed3 < 2){
                isChecking = true;
                objectString = "Master Bathroom Medicine Cabinet";
            }else if (parameterBed4 < 2){
                isChecking = true;
                objectString = "Car";
            }else if (parameterBed5 < 2){
                isChecking = true;
                objectString = "Bathroom Medicine Cabinet";
            }else if (parameterBed6 < 2){
                isChecking = true;
                objectString = "Box";
            }else if (parameterBed7 < 2){
                isChecking = true;
                objectString = "Large Sofa";
            }else if (parameterBed8 < 2){
                isChecking = true;
                objectString = "Kitchen Drawer";
            }else if (parameterBed9 < 2){
                isChecking = true;
                objectString = "Table";
            }else if (parameterBed10 < 2){
                isChecking = true;
                objectString = "Plant";
            }else if (parameterBed11 < 2){
                if (inventoryStatus.toolsbool == true){
                isChecking = true;
                objectString = inventoryStatus.tools1.ToString();
                }
            }else if (parameterBed12 < 2){
                if (inventoryStatus.toolsbool1 == true){
                isChecking = true;
                objectString = inventoryStatus.tools2.ToString();
                }
            } else {
                isChecking = false;
            }
                } else {
                    isChecking = false;
                }
            }

            if (playername == "P2"){
                if(playerStatus.captured1 == false){
            if (parameterBed < 2){
                isChecking = true;
                objectString = "Master Bed";
            }else if (parameterBed1 < 2){
                isChecking = true;
                objectString = "Leftside Room Bed";
            }else if (parameterBed2 < 2){
                isChecking = true;
                objectString = "Rightside Room Bed";
            }else if (parameterBed3 < 2){
                isChecking = true;
                objectString = "Master Bathroom Medicine Cabinet";
            }else if (parameterBed4 < 2){
                isChecking = true;
                objectString = "Car";
            }else if (parameterBed5 < 2){
                isChecking = true;
                objectString = "Bathroom Medicine Cabinet";
            }else if (parameterBed6 < 2){
                isChecking = true;
                objectString = "Box";
            }else if (parameterBed7 < 2){
                isChecking = true;
                objectString = "Large Sofa";
            }else if (parameterBed8 < 2){
                isChecking = true;
                objectString = "Kitchen Drawer";
            }else if (parameterBed9 < 2){
                isChecking = true;
                objectString = "Table";
            }else if (parameterBed10 < 2){
                isChecking = true;
                objectString = "Plant";
            }else if (parameterBed11 < 2){
                if (inventoryStatus.toolsbool == true){
                isChecking = true;
                objectString = inventoryStatus.tools1.ToString();
                }
            }else if (parameterBed12 < 2){
                if (inventoryStatus.toolsbool1 == true){
                isChecking = true;
                objectString = inventoryStatus.tools2.ToString();
                }
            } else {
                isChecking = false;
            }
                } else {
                    isChecking = false;
                }
            }

            if (playername == "P3"){
                if(playerStatus.captured2 == false){
            if (parameterBed < 2){
                isChecking = true;
                objectString = "Master Bed";
            }else if (parameterBed1 < 2){
                isChecking = true;
                objectString = "Leftside Room Bed";
            }else if (parameterBed2 < 2){
                isChecking = true;
                objectString = "Rightside Room Bed";
            }else if (parameterBed3 < 2){
                isChecking = true;
                objectString = "Master Bathroom Medicine Cabinet";
            }else if (parameterBed4 < 2){
                isChecking = true;
                objectString = "Car";
            }else if (parameterBed5 < 2){
                isChecking = true;
                objectString = "Bathroom Medicine Cabinet";
            }else if (parameterBed6 < 2){
                isChecking = true;
                objectString = "Box";
            }else if (parameterBed7 < 2){
                isChecking = true;
                objectString = "Large Sofa";
            }else if (parameterBed8 < 2){
                isChecking = true;
                objectString = "Kitchen Drawer";
            }else if (parameterBed9 < 2){
                isChecking = true;
                objectString = "Table";
            }else if (parameterBed10 < 2){
                isChecking = true;
                objectString = "Plant";
            }else if (parameterBed11 < 2){
                if (inventoryStatus.toolsbool == true){
                isChecking = true;
                objectString = inventoryStatus.tools1.ToString();
                }
            }else if (parameterBed12 < 2){
                if (inventoryStatus.toolsbool1 == true){
                isChecking = true;
                objectString = inventoryStatus.tools2.ToString();
                }
            } else {
                isChecking = false;
            }
                } else {
                    isChecking = false;
                }
            }

            if (playername == "P4"){
                if(playerStatus.captured3 == false){
            if (parameterBed < 2){
                isChecking = true;
                objectString = "Master Bed";
            }else if (parameterBed1 < 2){
                isChecking = true;
                objectString = "Leftside Room Bed";
            }else if (parameterBed2 < 2){
                isChecking = true;
                objectString = "Rightside Room Bed";
            }else if (parameterBed3 < 2){
                isChecking = true;
                objectString = "Master Bathroom Medicine Cabinet";
            }else if (parameterBed4 < 2){
                isChecking = true;
                objectString = "Car";
            }else if (parameterBed5 < 2){
                isChecking = true;
                objectString = "Bathroom Medicine Cabinet";
            }else if (parameterBed6 < 2){
                isChecking = true;
                objectString = "Box";
            }else if (parameterBed7 < 2){
                isChecking = true;
                objectString = "Large Sofa";
            }else if (parameterBed8 < 2){
                isChecking = true;
                objectString = "Kitchen Drawer";
            }else if (parameterBed9 < 2){
                isChecking = true;
                objectString = "Table";
            }else if (parameterBed10 < 2){
                isChecking = true;
                objectString = "Plant";
            }else if (parameterBed11 < 2){
                if (inventoryStatus.toolsbool == true){
                isChecking = true;
                objectString = inventoryStatus.tools1.ToString();
                }
            }else if (parameterBed12 < 2){
                if (inventoryStatus.toolsbool1 == true){
                isChecking = true;
                objectString = inventoryStatus.tools2.ToString();
                }
            } else {
                isChecking = false;
            }
                } else {
                    isChecking = false;
                }
            }

    }

}
