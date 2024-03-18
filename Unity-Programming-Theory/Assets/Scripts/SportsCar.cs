using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SportsCar : Vehicle
{
    public int vehicleID = 2;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
        if (Input.GetKeyDown("space"))
            UseAbility();
    }

    public override void UseAbility()
    {
        Debug.Log("Car noises");
    }
}
