using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITENCE
public class Buggy : Vehicle
{
    public int vehicleID = 3;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // POLYMORPHISM
    protected override void Update()
    {
        base.Update();
        if (Input.GetKeyDown("space"))
            UseAbility();
    }

    public override void UseAbility()
    {
        Debug.Log("Boing");
    }
}
