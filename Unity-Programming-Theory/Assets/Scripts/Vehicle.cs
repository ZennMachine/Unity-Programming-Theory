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
    protected virtual void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (vertical != 0)
        {
            Accelerate(vertical);
        }
            
        if (horizontal != 0)
        {
            Turn(horizontal);
        } 
    }

    public void Accelerate(float input)
    {
        transform.Translate(Vector3.forward * input * speed * Time.deltaTime);
    }

    public void Turn(float input)
    {
        transform.Rotate(Vector3.up * input * turnSpeed * Time.deltaTime);
    }

    public void DealDamage()
    {

    }

    public virtual void UseAbility()
    {
        Debug.Log("You dont have an ability!");
    }
}
