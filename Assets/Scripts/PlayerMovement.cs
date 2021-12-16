using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : Entity
{
    public float MovementSpeed = 5;
    public Rigidbody2D _rb;
    public Shooting[] Shootings;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        _rb.velocity = new Vector2(Input.GetAxis("Horizontal") * MovementSpeed, Input.GetAxis("Vertical") * MovementSpeed);
        if (Time.timeSinceLevelLoad > 2)
        {
            foreach (Shooting shooting in Shootings)
            {
                shooting.Fire();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
