using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SportsCar : Vehicle
{
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

    private void UseAbility()
    {
        Debug.Log("Car noises");
    }
}
