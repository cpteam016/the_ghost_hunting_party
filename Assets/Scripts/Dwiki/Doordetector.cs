using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doordetector : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public GameObject door4;
    public GameObject door5;
    public GameObject door6;
    public GameObject door7;
    public GameObject door8;
    public GameObject door9;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public float distance1a;
    public float distance1b;
    public float distance1c;
    public float distance1d;
    public float distance1e;
    public float distance1f;
    public float distance1g;
    public float distance1h;
    public float distance1i;
    
    public float distance2a;
    public float distance2b;
    public float distance2c;
    public float distance2d;
    public float distance2e;
    public float distance2f;
    public float distance2g;
    public float distance2h;
    public float distance2i;
    
    public float distance3a;
    public float distance3b;
    public float distance3c;
    public float distance3d;
    public float distance3e;
    public float distance3f;
    public float distance3g;
    public float distance3h;
    public float distance3i;

    public float distance4a;
    public float distance4b;
    public float distance4c;
    public float distance4d;
    public float distance4e;
    public float distance4f;
    public float distance4g;
    public float distance4h;
    public float distance4i;

    public float rotation1;
    public float rotation2;
    public float rotation3;
    public float rotation4;
    public float rotation5;
    public float rotation6;
    public float rotation7;
    public float rotation8;
    public float rotation9;

    [SerializeField] private AudioClip doorSfx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance1a = Vector2.Distance(player1.transform.position, door1.transform.position);
        distance1b = Vector2.Distance(player1.transform.position, door2.transform.position);
        distance1c = Vector2.Distance(player1.transform.position, door3.transform.position);
        distance1d = Vector2.Distance(player1.transform.position, door4.transform.position);
        distance1e = Vector2.Distance(player1.transform.position, door5.transform.position);
        distance1f = Vector2.Distance(player1.transform.position, door6.transform.position);
        distance1g = Vector2.Distance(player1.transform.position, door7.transform.position);
        distance1h = Vector2.Distance(player1.transform.position, door8.transform.position);
        distance1i = Vector2.Distance(player1.transform.position, door9.transform.position);
        
        distance2a = Vector2.Distance(player2.transform.position, door1.transform.position);
        distance2b = Vector2.Distance(player2.transform.position, door2.transform.position);
        distance2c = Vector2.Distance(player2.transform.position, door3.transform.position);
        distance2d = Vector2.Distance(player2.transform.position, door4.transform.position);
        distance2e = Vector2.Distance(player2.transform.position, door5.transform.position);
        distance2f = Vector2.Distance(player2.transform.position, door6.transform.position);
        distance2g = Vector2.Distance(player2.transform.position, door7.transform.position);
        distance2h = Vector2.Distance(player2.transform.position, door8.transform.position);
        distance2i = Vector2.Distance(player2.transform.position, door9.transform.position);

        distance3a = Vector2.Distance(player3.transform.position, door1.transform.position);
        distance3b = Vector2.Distance(player3.transform.position, door2.transform.position);
        distance3c = Vector2.Distance(player3.transform.position, door3.transform.position);
        distance3d = Vector2.Distance(player3.transform.position, door4.transform.position);
        distance3e = Vector2.Distance(player3.transform.position, door5.transform.position);
        distance3f = Vector2.Distance(player3.transform.position, door6.transform.position);
        distance3g = Vector2.Distance(player3.transform.position, door7.transform.position);
        distance3h = Vector2.Distance(player3.transform.position, door8.transform.position);
        distance3i = Vector2.Distance(player3.transform.position, door9.transform.position);

        distance4a = Vector2.Distance(player4.transform.position, door1.transform.position);
        distance4b = Vector2.Distance(player4.transform.position, door2.transform.position);
        distance4c = Vector2.Distance(player4.transform.position, door3.transform.position);
        distance4d = Vector2.Distance(player4.transform.position, door4.transform.position);
        distance4e = Vector2.Distance(player4.transform.position, door5.transform.position);
        distance4f = Vector2.Distance(player4.transform.position, door6.transform.position);
        distance4g = Vector2.Distance(player4.transform.position, door7.transform.position);
        distance4h = Vector2.Distance(player4.transform.position, door8.transform.position);
        distance4i = Vector2.Distance(player4.transform.position, door9.transform.position);

        rotation1 = door1.transform.rotation.z;
        rotation2 = door2.transform.rotation.z;
        rotation3 = door3.transform.rotation.z;
        rotation4 = door4.transform.rotation.z;
        rotation5 = door5.transform.rotation.z;
        rotation6 = door6.transform.rotation.z;
        rotation7 = door7.transform.rotation.z;
        rotation8 = door8.transform.rotation.z;
        rotation9 = door9.transform.rotation.z;

        if (distance1a < 2f){
        door1.transform.Rotate(0, 0, 1f);
                    if (rotation1 > 0.9f)
                    {
                        Sound.instance.PlaySound(doorSfx);
                        door1.transform.Rotate(0, 0, 0);
                        door1.transform.rotation = Quaternion.Euler(0, 0, 145);
                        
                    }   
        } else if (distance2a < 2f){
        door1.transform.Rotate(0, 0, 1f);
                    if (rotation1 > 0.9f)
                    {
                         Sound.instance.PlaySound(doorSfx);
                        door1.transform.Rotate(0, 0, 0);
                        door1.transform.rotation = Quaternion.Euler(0, 0, 145);
                    }
        } else if (distance3a < 2f){
        door1.transform.Rotate(0, 0, 1f);
                    if (rotation1 > 0.9f)
                    {
                         Sound.instance.PlaySound(doorSfx);
                        door1.transform.Rotate(0, 0, 0);
                        door1.transform.rotation = Quaternion.Euler(0, 0, 145);
                    }    
        } else if (distance4a < 2f){
        door1.transform.Rotate(0, 0, 1f);
                    if (rotation1 > 0.9f)
                    {
                         Sound.instance.PlaySound(doorSfx);
                        door1.transform.Rotate(0, 0, 0);
                        door1.transform.rotation = Quaternion.Euler(0, 0, 145);
                    }    
        } else {
        door1.transform.Rotate(0, 0, -1f);
                if (rotation1 < 0.1f)
                {
                     Sound.instance.PlaySound(doorSfx);
                    door1.transform.Rotate(0, 0, 0);
                    door1.transform.rotation = Quaternion.Euler(0, 0, 0);
                }      
        }

        if (distance1b < 2f){
        door2.transform.Rotate(0, 0, -1f);
                    if (rotation2 < -0.9f)
                    {
                        door2.transform.Rotate(0, 0, 0);
                        door2.transform.rotation = Quaternion.Euler(0, 0, -145);
                    }  
        } else if (distance2b < 2f){
        door2.transform.Rotate(0, 0, -1f);
                    if (rotation2 < -0.9f)
                    {
                        door2.transform.Rotate(0, 0, 0);
                        door2.transform.rotation = Quaternion.Euler(0, 0, -145);
                    }  
        } else if (distance3b < 2f){
        door2.transform.Rotate(0, 0, -1f);
                    if (rotation2 < -0.9f)
                    {
                        door2.transform.Rotate(0, 0, 0);
                        door2.transform.rotation = Quaternion.Euler(0, 0, -145);
                    }    
        } else if (distance4b < 2f){
        door2.transform.Rotate(0, 0, -1f);
                    if (rotation2 < -0.9f)
                    {
                        door2.transform.Rotate(0, 0, 0);
                        door2.transform.rotation = Quaternion.Euler(0, 0, -145);
                    }       
        } else {
        door2.transform.Rotate(0, 0, 1f);
                if (rotation2 > -0.1f)
                {
                    door2.transform.Rotate(0, 0, 0);
                    door2.transform.rotation = Quaternion.Euler(0, 0, 0);
                }       
        }

        if (distance1c < 2f){
        door3.transform.Rotate(0, 0, 1f);
                    if (rotation3 > 0.9f)
                    {
                        door3.transform.Rotate(0, 0, 0);
                        door3.transform.rotation = Quaternion.Euler(0, 0, 145);
                    }   
        } else if (distance2c < 2f){
        door3.transform.Rotate(0, 0, 1f);
                    if (rotation3 > 0.9f)
                    {
                        door3.transform.Rotate(0, 0, 0);
                        door3.transform.rotation = Quaternion.Euler(0, 0, 145);
                    }  
        } else if (distance3c < 2f){
        door3.transform.Rotate(0, 0, 1f);
                    if (rotation3 > 0.9f)
                    {
                        door3.transform.Rotate(0, 0, 0);
                        door3.transform.rotation = Quaternion.Euler(0, 0, 145);
                    }  
        } else if (distance4c < 2f){
        door3.transform.Rotate(0, 0, 1f);
                    if (rotation3 > 0.9f)
                    {
                        door3.transform.Rotate(0, 0, 0);
                        door3.transform.rotation = Quaternion.Euler(0, 0, 145);
                    }     
        } else {
        door3.transform.Rotate(0, 0, -1f);
                if (rotation3 < 0.1f)
                {
                    door3.transform.Rotate(0, 0, 0);
                    door3.transform.rotation = Quaternion.Euler(0, 0, 0);
                }      
        }

        if (distance1d < 2f){
        door4.transform.Rotate(0, 0, -1f);
                    if (rotation4 < -0.9f)
                    {
                        door4.transform.Rotate(0, 0, 0);
                        door4.transform.rotation = Quaternion.Euler(0, 0, -145);
                    }   
        } else if (distance2d < 2f){
        door4.transform.Rotate(0, 0, -1f);
                    if (rotation4 < -0.9f)
                    {
                        door4.transform.Rotate(0, 0, 0);
                        door4.transform.rotation = Quaternion.Euler(0, 0, -145);
                    }
        } else if (distance3d < 2f){
        door4.transform.Rotate(0, 0, -1f);
                    if (rotation4 < -0.9f)
                    {
                        door4.transform.Rotate(0, 0, 0);
                        door4.transform.rotation = Quaternion.Euler(0, 0, -145);
                    }   
        } else if (distance4d < 2f){
        door4.transform.Rotate(0, 0, -1f);
                    if (rotation4 < -0.9f)
                    {
                        door4.transform.Rotate(0, 0, 0);
                        door4.transform.rotation = Quaternion.Euler(0, 0, -145);
                    }   
        } else {
        door4.transform.Rotate(0, 0, 1f);
                if (rotation4 > -0.1f)
                {
                    door4.transform.Rotate(0, 0, 0);
                    door4.transform.rotation = Quaternion.Euler(0, 0, 0);
                }        
        }

        if (distance1e < 2f){
        door5.transform.Rotate(0, 0, -1f);
                    if (rotation5 < -0.2f)
                    {
                        door5.transform.Rotate(0, 0, 0);
                        door5.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }    
        } else if (distance2e < 2f){
        door5.transform.Rotate(0, 0, -1f);
                    if (rotation5 < -0.2f)
                    {
                        door5.transform.Rotate(0, 0, 0);
                        door5.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }    
        } else if (distance3e < 2f){
        door5.transform.Rotate(0, 0, -1f);
                    if (rotation5 < -0.2f)
                    {
                        door5.transform.Rotate(0, 0, 0);
                        door5.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }       
        } else if (distance4e < 2f){
        door5.transform.Rotate(0, 0, -1f);
                    if (rotation5 < -0.2f)
                    {
                        door5.transform.Rotate(0, 0, 0);
                        door5.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }      
        } else {
        door5.transform.Rotate(0, 0, 1f);
                if (rotation5 > 0.7f)
                {
                    door5.transform.Rotate(0, 0, 0);
                    door5.transform.rotation = Quaternion.Euler(0, 0, 90);
                }   
        }

        if (distance2f < 2f){
        door6.transform.Rotate(0, 0, 1f);
                    if (rotation6 > 0.4f)
                    {
                        door6.transform.Rotate(0, 0, 0);
                        door6.transform.rotation = Quaternion.Euler(0, 0, 55);
                    } 
        } else if (distance2f < 2f){
        door6.transform.Rotate(0, 0, 1f);
                    if (rotation6 > 0.4f)
                    {
                        door6.transform.Rotate(0, 0, 0);
                        door6.transform.rotation = Quaternion.Euler(0, 0, 55);
                    }   
        } else if (distance3f < 2f){
        door6.transform.Rotate(0, 0, 1f);
                    if (rotation6 > 0.4f)
                    {
                        door6.transform.Rotate(0, 0, 0);
                        door6.transform.rotation = Quaternion.Euler(0, 0, 55);
                    }        
        } else if (distance4f < 2f){
        door6.transform.Rotate(0, 0, 1f);
                    if (rotation6 > 0.4f)
                    {
                        door6.transform.Rotate(0, 0, 0);
                        door6.transform.rotation = Quaternion.Euler(0, 0, 55);
                    }      
        } else {
        door6.transform.Rotate(0, 0, -1f);
                if (rotation6 < -0.7f)
                {
                    door6.transform.Rotate(0, 0, 0);
                    door6.transform.rotation = Quaternion.Euler(0, 0, -90);
                }
        }

        if (distance1g < 2f){
        door7.transform.Rotate(0, 0, -1f);
                    if (rotation7 < -0.2f)
                    {
                        door7.transform.Rotate(0, 0, 0);
                        door7.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }    
        } else if (distance2g < 2f){
        door7.transform.Rotate(0, 0, -1f);
                    if (rotation7 < -0.2f)
                    {
                        door7.transform.Rotate(0, 0, 0);
                        door7.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }    
        } else if (distance3g < 2f){
        door7.transform.Rotate(0, 0, -1f);
                    if (rotation7 < -0.2f)
                    {
                        door7.transform.Rotate(0, 0, 0);
                        door7.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }     
        } else if (distance4g < 2f){
        door7.transform.Rotate(0, 0, -1f);
                    if (rotation7 < -0.2f)
                    {
                        door7.transform.Rotate(0, 0, 0);
                        door7.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }        
        } else {
        door7.transform.Rotate(0, 0, 1f);
                if (rotation7 > 0.7f)
                {
                    door7.transform.Rotate(0, 0, 0);
                    door7.transform.rotation = Quaternion.Euler(0, 0, 90);
                }       
        }

        if (distance1h < 2f){
        door8.transform.Rotate(0, 0, -1f);
                    if (rotation8 < -0.2f)
                    {
                        door8.transform.Rotate(0, 0, 0);
                        door8.transform.rotation = Quaternion.Euler(0, 0, -55);
                    } 
        } else if (distance2h < 2f){
        door8.transform.Rotate(0, 0, -1f);
                    if (rotation8 < -0.2f)
                    {
                        door8.transform.Rotate(0, 0, 0);
                        door8.transform.rotation = Quaternion.Euler(0, 0, -55);
                    } 
        } else if (distance3h < 2f){
        door8.transform.Rotate(0, 0, -1f);
                    if (rotation8 < -0.2f)
                    {
                        door8.transform.Rotate(0, 0, 0);
                        door8.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }   
        } else if (distance4h < 2f){
        door8.transform.Rotate(0, 0, -1f);
                    if (rotation8 < -0.2f)
                    {
                        door8.transform.Rotate(0, 0, 0);
                        door8.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }     
        } else {
        door8.transform.Rotate(0, 0, 1f);
                if (rotation8 > 0.7f)
                {
                    door8.transform.Rotate(0, 0, 0);
                    door8.transform.rotation = Quaternion.Euler(0, 0, 90);
                }      
        }

        if (distance1i < 2f){
        door9.transform.Rotate(0, 0, -1f);
                    if (rotation9 < -0.2f)
                    {
                        door9.transform.Rotate(0, 0, 0);
                        door9.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }     
        } else if (distance2i < 2f){
        door9.transform.Rotate(0, 0, -1f);
                    if (rotation9 < -0.2f)
                    {
                        door9.transform.Rotate(0, 0, 0);
                        door9.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }     
        } else if (distance3i < 2f){
        door9.transform.Rotate(0, 0, -1f);
                    if (rotation9 < -0.2f)
                    {
                        door9.transform.Rotate(0, 0, 0);
                        door9.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }     
        } else if (distance4i < 2f){
        door9.transform.Rotate(0, 0, -1f);
                    if (rotation9 < -0.2f)
                    {
                        door9.transform.Rotate(0, 0, 0);
                        door9.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }         
        } else {
        door9.transform.Rotate(0, 0, 1f);
                if (rotation9 > 0.7f)
                {
                    door9.transform.Rotate(0, 0, 0);
                    door9.transform.rotation = Quaternion.Euler(0, 0, 90);
                }     
        }
    }
}
