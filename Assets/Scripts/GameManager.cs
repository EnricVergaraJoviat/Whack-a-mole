using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = System.Random;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI lbl_Score;
    
    public GameObject[] tokens;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        lbl_Score.text = "Score: 0";
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

    public void AddScore(int value)
    {
        score += value;
        lbl_Score.text = "Score: " + score;
    }
}
