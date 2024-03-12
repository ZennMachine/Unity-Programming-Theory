using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public float speed = 40;
    public float maxSpeed = 60;
    public float turnSpeed = 50;
    private Rigidbody rb;
    private int m_health = 100;
    public int health
    {
        get { return m_health; }
        set { m_health = health; }
    }


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal != 0)
            Accelerate(horizontal);
        if (vertical != 0)
            Turn(vertical);
    }

    public void Accelerate(float input)
    {
        rb.AddRelativeForce(Vector3.forward * speed * input * Time.deltaTime, ForceMode.Impulse);
    }

    public void Turn(float input)
    {
        rb.AddTorque(Vector3.right * speed * input * Time.deltaTime, ForceMode.Impulse);
    }

    public void DealDamage()
    {

    }

    public virtual void UseAbility()
    {
        Debug.Log("You dont have an ability!");
    }
}
