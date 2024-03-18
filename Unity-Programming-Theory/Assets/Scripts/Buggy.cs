using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buggy : Vehicle
{
    public int vehicleID = 3;
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
        Debug.Log("Boing");
    }
}
