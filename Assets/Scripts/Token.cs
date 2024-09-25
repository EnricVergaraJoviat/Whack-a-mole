using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Token : MonoBehaviour
{
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        sphere.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
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
