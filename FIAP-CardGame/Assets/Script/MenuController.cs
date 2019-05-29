using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject generalmenu;
    public GameObject optionsmenu;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        ActiveMenu(generalmenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HideMenu()
    {
        generalmenu.SetActive(false);
        optionsmenu.SetActive(false);
    }

    public void ActiveMenu (GameObject menu)
    {
        HideMenu();
        menu.SetActive(true);
    }

    public void ExitGame()
    {
        ApplicationController.ExitGame();

    }

}
