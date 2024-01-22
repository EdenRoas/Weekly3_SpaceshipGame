using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverLogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject SpaceshipA;
    GameObject SpaceshipB;

    void Start()
    {
        SpaceshipA = GameObject.Find("PlayerSpaceshipA");
        if (SpaceshipA != null)
        {
            Destroy(SpaceshipA);
        }
        SpaceshipB = GameObject.Find("PlayerSpaceshipB");
        if (SpaceshipB != null)
        {
            Destroy(SpaceshipB);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
