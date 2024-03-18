using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> vehicles = new List<GameObject>();

    public GameObject player;
    private int currentVehicleID;
    private void Start()
    {
        CheckCurrentVehicle();
    }

    private void CheckCurrentVehicle()
    {
        currentVehicleID = DataManager.Instance.currentVehicleID;

        player = Instantiate(vehicles[currentVehicleID - 1], transform);
    }
}
