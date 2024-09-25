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
            if (sphere.GetComponent<MeshRenderer>().material.color == Color.green)
            {
                Debug.Log("Han fet click sobre el talp (+1)");
            }
            else
            {
                Debug.Log("Han fet click sobre el talp (-1)");
            } 
            sphere.SetActive(false);
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
            sphere.GetComponent<MeshRenderer>().material.color = Color.red;
        }
        else
        {
            Debug.Log("Han activat el token amb verd");
            sphere.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        
        Invoke("DeactivateSpehere", 2.0f);
    }
}
