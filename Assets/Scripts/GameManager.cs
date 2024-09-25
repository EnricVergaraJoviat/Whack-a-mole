using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class GameManager : MonoBehaviour
{
    public GameObject[] tokens;
    // Start is called before the first frame update
    void Start()
    {
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            int index = UnityEngine.Random.Range(0, 25);
            //Token t = tokens[0].GetComponent<Token>().ActivateToken(true);
            Token t = tokens[index].GetComponent<Token>();
            bool isRed = true;
            if (UnityEngine.Random.value <= 0.5f)
            {
                isRed = false;    
            }
            t.ActivateToken(isRed);
            
        }
       
    }
}
