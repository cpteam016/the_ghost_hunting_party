using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyType : MonoBehaviour
{   
    public Image imageHolder;
    public TextMeshProUGUI ghostName;
    public GameObject kuntilanakT;
    public GameObject wewegombelT;
    public GameObject pocongT;
    public GameObject genderuwoT;
    public GameObject beguganjangT;
    public GameObject kisutT;
    public GameObject kuyangT;
    public GameObject sundelbolongT;
    public GameObject banaspatiT;
    public TextMeshProUGUI howTo;
    public GameObject enemy;
    public GameObject melee;
    public GameObject range;
    public GameObject melee1;
    public GameObject range1;
    public GameObject melee2;
    public GameObject range2;
    public GameObject melee3;
    public GameObject range3;
    public float distancemelee;
    public float distancerange;
    public float distancemelee1;
    public float distancerange1;
    public float distancemelee2;
    public float distancerange2;
    public float distancemelee3;
    public float distancerange3;
    public SpriteRenderer enemySprite;
    public WeaponScript weaponType;
    public string ghostType;
    public int randomValue;
    public Sprite kuntilanak;
    public Sprite pocong;
    public Sprite genderuwo;
    public Sprite sundelBolong;
    public Sprite weweGombel;
    public Sprite banaspati;
    public Sprite beguGanjang;
    public Sprite kisut;
    public Sprite kuyang;
    public bool banished;

    // Start is called before the first frame update
    void Start()
    {
        randomValue = Random.Range(0, 80);

        if (randomValue < 10){
        enemySprite.sprite = kuntilanak;   
        ghostType = "Kuntilanak";
        ghostName.text = "Kuntilanak"; 
        } else if (randomValue < 20 && randomValue > 10){
        enemySprite.sprite = pocong;   
        ghostType = "Pocong"; 
        ghostName.text = "Pocong"; 
        } else if (randomValue < 30 && randomValue > 20){
        enemySprite.sprite = genderuwo;   
        ghostType = "Genderuwo";   
        ghostName.text = "Genderuwo";   
        } else if (randomValue < 40 && randomValue > 30){
        enemySprite.sprite = sundelBolong;     
        ghostType = "Sundel Bolong"; 
        ghostName.text = "Sundel Bolong";   
        } else if (randomValue < 50 && randomValue > 40){
        enemySprite.sprite = weweGombel;   
        ghostType = "Wewe Gombel";   
        ghostName.text = "Wewe Gombel";   
        } else if (randomValue < 60 && randomValue > 50){
        enemySprite.sprite = kisut;     
        ghostType = "Kisut"; 
        ghostName.text = "Kisut";   
        } else if (randomValue < 70 && randomValue > 60){
        enemySprite.sprite = banaspati;   
        ghostType = "Banaspati";  
        ghostName.text = "Banaspati";    
        } else if (randomValue < 80 && randomValue > 70){
        enemySprite.sprite = beguGanjang;    
        ghostType = "Begu Ganjang";   
        ghostName.text = "Begu Ganjang";  
        } else if (randomValue < 90 && randomValue > 80){
        enemySprite.sprite = kuyang;    
        ghostType = "Kuyang";    
        ghostName.text = "Kuyang"; 
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (ghostType == "Kuntilanak"){
            imageHolder.sprite = kuntilanak;
            kuntilanakT.SetActive(true);
            wewegombelT.SetActive(false);
            pocongT.SetActive(false);
            beguganjangT.SetActive(false);
            banaspatiT.SetActive(false);
            sundelbolongT.SetActive(false);
            kisutT.SetActive(false);
            genderuwoT.SetActive(false);
            kuyangT.SetActive(false);
        } else if (ghostType == "Wewe Gombel"){
            imageHolder.sprite = weweGombel;
          kuntilanakT.SetActive(false);
            wewegombelT.SetActive(true);
            pocongT.SetActive(false);
            beguganjangT.SetActive(false);
            banaspatiT.SetActive(false);
            sundelbolongT.SetActive(false);
            kisutT.SetActive(false);
            genderuwoT.SetActive(false);
            kuyangT.SetActive(false);  
        } else if (ghostType == "Pocong"){
            imageHolder.sprite = pocong;
          kuntilanakT.SetActive(false);
            wewegombelT.SetActive(false);
            pocongT.SetActive(true);
            beguganjangT.SetActive(false);
            banaspatiT.SetActive(false);
            sundelbolongT.SetActive(false);
            kisutT.SetActive(false);
            genderuwoT.SetActive(false);
            kuyangT.SetActive(false);  
        } else if (ghostType == "Begu Ganjang"){
            imageHolder.sprite = beguGanjang;
          kuntilanakT.SetActive(false);
            wewegombelT.SetActive(false);
            pocongT.SetActive(false);
            beguganjangT.SetActive(true);
            banaspatiT.SetActive(false);
            sundelbolongT.SetActive(false);
            kisutT.SetActive(false);
            genderuwoT.SetActive(false);
            kuyangT.SetActive(false);  
        } else if (ghostType == "Banaspati"){
            imageHolder.sprite = banaspati;
          kuntilanakT.SetActive(false);
            wewegombelT.SetActive(false);
            pocongT.SetActive(false);
            beguganjangT.SetActive(false);
            banaspatiT.SetActive(true);
            sundelbolongT.SetActive(false);
            kisutT.SetActive(false);
            genderuwoT.SetActive(false);
            kuyangT.SetActive(false);  
        } else if (ghostType == "Sundel Bolong"){
            imageHolder.sprite = sundelBolong;
          kuntilanakT.SetActive(false);
            wewegombelT.SetActive(false);
            pocongT.SetActive(false);
            beguganjangT.SetActive(false);
            banaspatiT.SetActive(false);
            sundelbolongT.SetActive(true);
            kisutT.SetActive(false);
            genderuwoT.SetActive(false);
            kuyangT.SetActive(false);  
        } else if (ghostType == "Kisut"){
            imageHolder.sprite = kisut;
          kuntilanakT.SetActive(false);
            wewegombelT.SetActive(false);
            pocongT.SetActive(false);
            beguganjangT.SetActive(false);
            banaspatiT.SetActive(false);
            sundelbolongT.SetActive(false);
            kisutT.SetActive(true);
            genderuwoT.SetActive(false);
            kuyangT.SetActive(false);  
        } else if (ghostType == "Genderuwo"){
            imageHolder.sprite = genderuwo;
          kuntilanakT.SetActive(false);
            wewegombelT.SetActive(false);
            pocongT.SetActive(false);
            beguganjangT.SetActive(false);
            banaspatiT.SetActive(false);
            sundelbolongT.SetActive(false);
            kisutT.SetActive(false);
            genderuwoT.SetActive(true);
            kuyangT.SetActive(false);  
        } else if (ghostType == "Kuyang"){
            imageHolder.sprite = sundelBolong;
          kuntilanakT.SetActive(false);
            wewegombelT.SetActive(false);
            pocongT.SetActive(false);
            beguganjangT.SetActive(false);
            banaspatiT.SetActive(false);
            sundelbolongT.SetActive(false);
            kisutT.SetActive(false);
            genderuwoT.SetActive(false);
            kuyangT.SetActive(true);  
        } else {
            kuntilanakT.SetActive(false);
            wewegombelT.SetActive(false);
            pocongT.SetActive(false);
            beguganjangT.SetActive(false);
            banaspatiT.SetActive(false);
            sundelbolongT.SetActive(false);
            kisutT.SetActive(false);
            genderuwoT.SetActive(false);
            kuyangT.SetActive(false);  
        }

        distancemelee = Vector2.Distance(melee.transform.position, enemy.transform.position);
        distancerange = Vector2.Distance(range.transform.position, enemy.transform.position);
        distancemelee1 = Vector2.Distance(melee1.transform.position, enemy.transform.position);
        distancerange1 = Vector2.Distance(range1.transform.position, enemy.transform.position);
        distancemelee2 = Vector2.Distance(melee2.transform.position, enemy.transform.position);
        distancerange2 = Vector2.Distance(range2.transform.position, enemy.transform.position);
        distancemelee3 = Vector2.Distance(melee3.transform.position, enemy.transform.position);
        distancerange3 = Vector2.Distance(range3.transform.position, enemy.transform.position);

        if (distancemelee < 3){
        if (ghostType == "Kuntilanak"){
            if (weaponType.attackname == "Metal Nails"){
            enemy.SetActive(false);
            banished = true;    
            }
        } else if (ghostType == "Genderuwo"){
            if (weaponType.attackname == "Moringa Leaves"){
                enemy.SetActive(false);
            banished = true; 
            }
        } else if (ghostType == "Begu Ganjang"){
            if (weaponType.attackname == "Broom"){
            enemy.SetActive(false);
            banished = true;     
            }
        }  else if (ghostType == "Kuyang"){
            if (weaponType.attackname == "Knife"){
            enemy.SetActive(false);
            banished = true;     
            }
        }  else if (ghostType == "Kisut"){
            if (weaponType.attackname == "Flashlight"){
            enemy.SetActive(false);
            banished = true;     
            }
        }   
        } else if (distancemelee1 < 3){
        if (ghostType == "Kuntilanak"){
            if (weaponType.attackname1 == "Metal Nails"){
            enemy.SetActive(false);
            banished = true;    
            }
        } else if (ghostType == "Genderuwo"){
            if (weaponType.attackname1 == "Moringa Leaves"){
            enemy.SetActive(false);
            banished = true; 
            }
        } else if (ghostType == "Begu Ganjang"){
            if (weaponType.attackname1 == "Broom"){
            enemy.SetActive(false);
            banished = true;     
            }
        }  else if (ghostType == "Kuyang"){
            if (weaponType.attackname1 == "Knife"){
            enemy.SetActive(false);
            banished = true;     
            }
        }  else if (ghostType == "Kisut"){
            if (weaponType.attackname1 == "Flashlight"){
            enemy.SetActive(false);
            banished = true;     
            }
        }   
        } else if (distancemelee2 < 3){
        if (ghostType == "Kuntilanak"){
            if (weaponType.attackname2 == "Metal Nails"){
            enemy.SetActive(false);
            banished = true;    
            }
        } else if (ghostType == "Genderuwo"){
            if (weaponType.attackname2 == "Moringa Leaves"){
                enemy.SetActive(false);
            banished = true; 
            }
        } else if (ghostType == "Begu Ganjang"){
            if (weaponType.attackname2 == "Broom"){
            enemy.SetActive(false);
            banished = true;     
            }
        }  else if (ghostType == "Kuyang"){
            if (weaponType.attackname2 == "Knife"){
            enemy.SetActive(false);
            banished = true;     
            }
        }  else if (ghostType == "Kisut"){
            if (weaponType.attackname2 == "Flashlight"){
            enemy.SetActive(false);
            banished = true;     
            }
        }   
        } else if (distancemelee3 < 3){
        if (ghostType == "Kuntilanak"){
            if (weaponType.attackname3 == "Metal Nails"){
            enemy.SetActive(false);
            banished = true;    
            }
        } else if (ghostType == "Genderuwo"){
            if (weaponType.attackname3 == "Moringa Leaves"){
                enemy.SetActive(false);
            banished = true; 
            }
        } else if (ghostType == "Begu Ganjang"){
            if (weaponType.attackname3 == "Broom"){
            enemy.SetActive(false);
            banished = true;     
            }
        }  else if (ghostType == "Kuyang"){
            if (weaponType.attackname3 == "Knife"){
            enemy.SetActive(false);
            banished = true;     
            }
        }  else if (ghostType == "Kisut"){
            if (weaponType.attackname3 == "Flashlight"){
            enemy.SetActive(false);
            banished = true;     
            }
        }   
        }

        if (distancerange < 5){
            if (ghostType == "Pocong"){
            if (weaponType.placename == "Onion Skewer"){
            enemy.SetActive(false);
            banished = true;     
            }
            } else if (ghostType == "Wewe Gombel"){
            if (weaponType.placename == "Goose Egg"){
            enemy.SetActive(false);
            banished = true;     
            } 
            } else if (ghostType == "Sundel Bolong"){
            if (weaponType.placename == "Goose Egg"){
            enemy.SetActive(false);
            banished = true;     
            } 
            }  else if (ghostType == "Banaspati"){
            if (weaponType.placename == "Whiting"){
            enemy.SetActive(false);
            banished = true;     
            } 
            }
        } else if (distancerange1 < 5){
            if (ghostType == "Pocong"){
            if (weaponType.placename1 == "Onion Skewer"){
            enemy.SetActive(false);
            banished = true;     
            }
            } else if (ghostType == "Wewe Gombel"){
            if (weaponType.placename1 == "Goose Egg"){
            enemy.SetActive(false);
            banished = true;     
            } 
            } else if (ghostType == "Sundel Bolong"){
            if (weaponType.placename1 == "Goose Egg"){
            enemy.SetActive(false);
            banished = true;     
            } 
            }  else if (ghostType == "Banaspati"){
            if (weaponType.placename1 == "Whiting"){
            enemy.SetActive(false);
            banished = true;     
            } 
            }
        } else if (distancerange2 < 5){
            if (ghostType == "Pocong"){
            if (weaponType.placename2 == "Onion Skewer"){
            enemy.SetActive(false);
            banished = true;     
            }
            } else if (ghostType == "Wewe Gombel"){
            if (weaponType.placename2 == "Goose Egg"){
            enemy.SetActive(false);
            banished = true;     
            } 
            } else if (ghostType == "Sundel Bolong"){
            if (weaponType.placename2 == "Goose Egg"){
            enemy.SetActive(false);
            banished = true;     
            } 
            }  else if (ghostType == "Banaspati"){
            if (weaponType.placename2 == "Whiting"){
            enemy.SetActive(false);
            banished = true;     
            } 
            }
        } else if (distancerange3 < 5){
            if (ghostType == "Pocong"){
            if (weaponType.placename3 == "Onion Skewer"){
            enemy.SetActive(false);
            banished = true;     
            }
            } else if (ghostType == "Wewe Gombel"){
            if (weaponType.placename3 == "Goose Egg"){
            enemy.SetActive(false);
            banished = true;     
            } 
            } else if (ghostType == "Sundel Bolong"){
            if (weaponType.placename3 == "Goose Egg"){
            enemy.SetActive(false);
            banished = true;     
            } 
            }  else if (ghostType == "Banaspati"){
            if (weaponType.placename3 == "Whiting"){
            enemy.SetActive(false);
            banished = true;     
            } 
            }
        }


    }

}
