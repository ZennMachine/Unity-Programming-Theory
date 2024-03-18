using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{

    public GameObject mainmenu;
    public GameObject vehicleselectmenu;

    // Start is called before the first frame update
    void Start()
    {
        LoadMainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        
    }

    public void LoadMainMenu()
    {
        mainmenu.SetActive(true);
        vehicleselectmenu.SetActive(false);
    }

    public void LoadVehicleSelect()
    {
        mainmenu.SetActive(false);
        vehicleselectmenu.SetActive(true);
    }
}
