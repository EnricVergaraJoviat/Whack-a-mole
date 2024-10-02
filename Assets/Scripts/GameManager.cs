using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = System.Random;

public class GameManager : MonoBehaviour
{
    [Header("Time Settings:")] 
    public float minTimeToAppear;
    public float maxTimeToAppear;
    public int minNumberOfMoles;
    public int maxNumberOfMoles;
    public float totalTime;
    public GameObject[] tokens;
    
    [Header("UI Settings:")]
    public TextMeshProUGUI lbl_Score;
    public TextMeshProUGUI lbl_Countdown;
    public TextMeshProUGUI lbl_GameFinished;
    
    
    
    private int score;
    private bool gameFinished = false;
    
    // Start is called before the first frame update
    void Start()
    {
        gameFinished = false;
        score = 0;
        
        lbl_Score.text = "Score: 0";
        lbl_Countdown.text = "Time: " + totalTime;
        lbl_GameFinished.text = "";
        
        Invoke("ActivateMoles", minTimeToAppear);
    }


    void Update()
    {
        if (gameFinished)
        {
            return;
        }

        totalTime -= Time.deltaTime;
        lbl_Countdown.text = "Time: " + (int)totalTime;
        if (totalTime <= 0.0f)
        {
            lbl_GameFinished.text = "Game Finished";
            gameFinished = true;
            foreach (var token in tokens)
            {
                Destroy(token);
            }
        }

    }

    public void AddScore(int value)
    {
        score += value;
        lbl_Score.text = "Score: " + score;
    }

    private void ActivateMoles()
    {
        
        int numOfMolesToBeActivated = UnityEngine.Random.Range(minNumberOfMoles, maxNumberOfMoles+1);
        for (int i = 0; i < numOfMolesToBeActivated; i++)
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
        

        if (!gameFinished)
        {
            float time = UnityEngine.Random.Range(minTimeToAppear, maxTimeToAppear);
            Invoke("ActivateMoles", time);    
        }
        
    }
}
