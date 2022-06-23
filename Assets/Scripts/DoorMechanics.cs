using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMechanics : MonoBehaviour
{
    public float parameter;
    public float parameter1;
    public float parameter2;
    public float parameter21;
    public float parameter3;
    public float parameter31;
    public float parameter4;
    public float parameter41;
    public float rotation;
    public string position;
    public string doorLocation;
    public GameObject playerObject;
    public GameObject playerObject1;
    public GameObject playerObject2;
    public GameObject playerObject3;
    // Start is called before the first frame update
    void Start()
    {
        position = "";
    }

    // Update is called once per frame
    void Update()
    {
        rotation = transform.rotation.z;
        parameter = Vector3.Distance(playerObject.transform.position, gameObject.transform.position);
        parameter1 = Vector3.Distance(playerObject.transform.position, gameObject.transform.position);
        parameter2 = Vector3.Distance(playerObject1.transform.position, gameObject.transform.position);
        parameter21 = Vector3.Distance(playerObject1.transform.position, gameObject.transform.position);
        parameter3 = Vector3.Distance(playerObject2.transform.position, gameObject.transform.position);
        parameter31 = Vector3.Distance(playerObject2.transform.position, gameObject.transform.position);
        parameter4 = Vector3.Distance(playerObject3.transform.position, gameObject.transform.position);
        parameter41 = Vector3.Distance(playerObject3.transform.position, gameObject.transform.position);

        if (gameObject.transform.position.x > playerObject.transform.position.x)
        {
            parameter = parameter * -1;
        }

        if (gameObject.transform.position.y > playerObject.transform.position.y)
        {
            parameter1 = parameter1 * -1;
        }

        if (gameObject.transform.position.x > playerObject1.transform.position.x)
        {
            parameter2 = parameter2 * -1;
        }

        if (gameObject.transform.position.y > playerObject1.transform.position.y)
        {
            parameter21 = parameter21 * -1;
        }

        if (gameObject.transform.position.x > playerObject2.transform.position.x)
        {
            parameter3 = parameter3 * -1;
        }

        if (gameObject.transform.position.y > playerObject2.transform.position.y)
        {
            parameter31 = parameter31 * -1;
        }

        if (gameObject.transform.position.x > playerObject3.transform.position.x)
        {
            parameter4 = parameter4 * -1;
        }

        if (gameObject.transform.position.y > playerObject3.transform.position.y)
        {
            parameter41 = parameter41 * -1;
        }

        if (doorLocation == "OpenLeft")
        {
            if (parameter > 0 && parameter < 2)
            {
                if (position != "Left")
                {
                    position = "Right";
                }
                if (position == "Right")
                {
                    gameObject.transform.Rotate(0, 0, 1f);
                    if (rotation > 0.9f)
                    {
                        gameObject.transform.Rotate(0, 0, 0);
                        gameObject.transform.rotation = Quaternion.Euler(0, 0, 145);
                    }
                }
            }

            if (parameter < -2.5)
            {

                gameObject.transform.Rotate(0, 0, -1f);
                if (rotation < 0.1f)
                {
                    gameObject.transform.Rotate(0, 0, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                    position = "";
                }

            }

            if (parameter < 0 && parameter > -2)
            {
                if (position != "Right")
                {
                    position = "Left";
                }
                if (position == "Left")
                {
                    gameObject.transform.Rotate(0, 0, 1f);
                    if (rotation > 0.9f)
                    {
                        gameObject.transform.Rotate(0, 0, 0);
                        gameObject.transform.rotation = Quaternion.Euler(0, 0, 145);
                    }
                }
            }

            if (parameter > 2.5)
            {
                gameObject.transform.Rotate(0, 0, -1f);
                if (rotation < 0.1f)
                {
                    gameObject.transform.Rotate(0, 0, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                    position = "";
                }
            }
        }

        if (doorLocation == "OpenRight")
        {
            if (parameter > 0 && parameter < 2)
            {
                if (position != "Left")
                {
                    position = "Right";
                }
                if (position == "Right")
                {
                    gameObject.transform.Rotate(0, 0, -1f);
                    if (rotation < -0.9f)
                    {
                        gameObject.transform.Rotate(0, 0, 0);
                        gameObject.transform.rotation = Quaternion.Euler(0, 0, -145);
                    }
                }
            }

            if (parameter < -2.5)
            {

                gameObject.transform.Rotate(0, 0, 1f);
                if (rotation > -0.1f)
                {
                    gameObject.transform.Rotate(0, 0, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                    position = "";
                }

            }

            if (parameter < 0 && parameter > -2)
            {
                if (position != "Right")
                {
                    position = "Left";
                }
                if (position == "Left")
                {
                    gameObject.transform.Rotate(0, 0, -1f);
                    if (rotation < -0.9f)
                    {
                        gameObject.transform.Rotate(0, 0, 0);
                        gameObject.transform.rotation = Quaternion.Euler(0, 0, -145);
                    }
                }
            }

            if (parameter > 2.5)
            {
                gameObject.transform.Rotate(0, 0, 1f);
                if (rotation > -0.1f)
                {
                    gameObject.transform.Rotate(0, 0, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                    position = "";
                }
            }
        }

        if (doorLocation == "OpenUp")
        {
            if (parameter1 > 0 && parameter1 < 2)
            {
                if (position != "Left")
                {
                    position = "Right";
                }
                if (position == "Right")
                {
                    gameObject.transform.Rotate(0, 0, -1f);
                    if (rotation < -0.2f)
                    {
                        gameObject.transform.Rotate(0, 0, 0);
                        gameObject.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }
                }
            }

            if (parameter1 < -2.5)
            {

                gameObject.transform.Rotate(0, 0, 1f);
                if (rotation > 0.7f)
                {
                    gameObject.transform.Rotate(0, 0, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                    position = "";
                }

            }

            if (parameter1 < 0 && parameter1 > -2)
            {
                if (position != "Right")
                {
                    position = "Left";
                }
                if (position == "Left")
                {
                    gameObject.transform.Rotate(0, 0, -1f);
                    if (rotation < -0.2f)
                    {
                        gameObject.transform.Rotate(0, 0, 0);
                        gameObject.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }
                }
            }

            if (parameter1 > 2.5)
            {
                gameObject.transform.Rotate(0, 0, 1f);
                if (rotation > 0.7f)
                {
                    gameObject.transform.Rotate(0, 0, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                    position = "";
                }
            }
        }

        if (doorLocation == "OpenUpAlternative")
        {
            if (parameter1 > 0 && parameter1 < 2)
            {
                if (position != "Left")
                {
                    position = "Right";
                }
                if (position == "Right")
                {
                    gameObject.transform.Rotate(0, 0, 1f);
                    if (rotation > 0.4f)
                    {
                        gameObject.transform.Rotate(0, 0, 0);
                        gameObject.transform.rotation = Quaternion.Euler(0, 0, 55);
                    }
                }
            }

            if (parameter1 < -2.5)
            {

                gameObject.transform.Rotate(0, 0, -1f);
                if (rotation < -0.7f)
                {
                    gameObject.transform.Rotate(0, 0, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);
                    position = "";
                }

            }

            if (parameter1 < 0 && parameter1 > -2)
            {
                if (position != "Right")
                {
                    position = "Left";
                }
                if (position == "Left")
                {
                    gameObject.transform.Rotate(0, 0, 1f);
                    if (rotation > 0.4f)
                    {
                        gameObject.transform.Rotate(0, 0, 0);
                        gameObject.transform.rotation = Quaternion.Euler(0, 0, 55);
                    }
                }
            }

            if (parameter1 > 2.5)
            {
                gameObject.transform.Rotate(0, 0, -1f);
                if (rotation < -0.7f)
                {
                    gameObject.transform.Rotate(0, 0, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, -90);
                    position = "";
                }
            }
        }

        if (doorLocation == "OpenDown")
        {
            if (parameter1 > 0 && parameter1 < 2)
            {
                if (position != "Left")
                {
                    position = "Right";
                }
                if (position == "Right")
                {
                    gameObject.transform.Rotate(0, 0, -1f);
                    if (rotation < -0.2f)
                    {
                        gameObject.transform.Rotate(0, 0, 0);
                        gameObject.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }
                }
            }

            if (parameter1 < -2.5)
            {

                gameObject.transform.Rotate(0, 0, 1f);
                if (rotation > 0.7f)
                {
                    gameObject.transform.Rotate(0, 0, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                    position = "";
                }

            }

            if (parameter1 < 0 && parameter1 > -2)
            {
                if (position != "Right")
                {
                    position = "Left";
                }
                if (position == "Left")
                {
                    gameObject.transform.Rotate(0, 0, -1f);
                    if (rotation < -0.2f)
                    {
                        gameObject.transform.Rotate(0, 0, 0);
                        gameObject.transform.rotation = Quaternion.Euler(0, 0, -55);
                    }
                }
            }

            if (parameter1 > 2.5)
            {
                gameObject.transform.Rotate(0, 0, 1f);
                if (rotation > 0.7f)
                {
                    gameObject.transform.Rotate(0, 0, 0);
                    gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);
                    position = "";
                }
            }
        }







        
        

    }
}
