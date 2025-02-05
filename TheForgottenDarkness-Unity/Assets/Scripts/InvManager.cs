using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvManager : MonoBehaviour
{
    public GameObject invMenu;
    private bool isMenuActive;

    void Start()
    {
        isMenuActive = false;
        if (invMenu.activeInHierarchy == true )
        {
            invMenu.SetActive(false);
        }
    }

    void Update()
    {
        if(Input.GetButtonDown("Inventory") && isMenuActive)
        {
            invMenu.SetActive(false);
            isMenuActive = false;
            Time.timeScale = 1;
        } else if(Input.GetButtonDown("Inventory") && !isMenuActive)
        {
            invMenu.SetActive(true);
            isMenuActive = true;
            Time.timeScale = 0;
        } 
    }
}
