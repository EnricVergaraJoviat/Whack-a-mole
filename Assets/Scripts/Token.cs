using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour
{
    private GameObject gm;
    public GameObject sphere;
    
    // Start is called before the first frame update
    void Start()
    {
        sphere.SetActive(false);
        
        gm = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (sphere.activeSelf)
        {
            Debug.Log("Han fet click sobre el talp");    
        }
        
    }

    void DeactivateSpehere()
    {
        sphere.SetActive(false);
    }
    public void ActivateToken(bool isRed)
    {
        sphere.SetActive(true);
        if (isRed)
        {
            Debug.Log("Han activat el token amb vermell");
            Invoke("DeactivateSpehere", 2.0f);
        }
        else
        {
            Debug.Log("Han activat el token amb verd");
        }
    }
}
