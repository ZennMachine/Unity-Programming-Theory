using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{

    public GameObject mainmenu;
    public GameObject vehicleselectmenu;

    public Image tankImage;
    public Image sportsCarImage;
    public Image buggyImage;

    private int currentVehicleID;

    // Start is called before the first frame update
    void Start()
    {
        LoadMainMenu();
        DataManager.Instance.LoadData();
        CheckCurrentVehicle();
        
    }

    // ABSTRACTION
    // Updates the menu based on saved vehicle
    private void CheckCurrentVehicle()
    {
        currentVehicleID = DataManager.Instance.currentVehicleID;

        switch (currentVehicleID)
        {
            case 1:
                SelectTank();
                break;
            case 2:
                SelectSportsCar();
                break;
            case 3:
                SelectSportsCar();
                break;
            default:
                break;
        }
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

    public void SelectTank()
    {
        tankImage.color = Color.green;
        sportsCarImage.color = Color.grey;
        buggyImage.color = Color.grey;
        DataManager.Instance.currentVehicleID = 1;
        DataManager.Instance.SaveData();
    }

    public void SelectSportsCar()
    {
        tankImage.color = Color.grey;
        sportsCarImage.color = Color.green;
        buggyImage.color = Color.grey;
        DataManager.Instance.currentVehicleID = 2;
        DataManager.Instance.SaveData();
    }

    public void SelectBuggy()
    {
        tankImage.color = Color.grey;
        sportsCarImage.color = Color.grey;
        buggyImage.color = Color.green;
        DataManager.Instance.currentVehicleID = 3;
        DataManager.Instance.SaveData();
    }
}
