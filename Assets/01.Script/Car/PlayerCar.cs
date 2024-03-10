using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine.SceneManagement;
using System;
using Unity.VisualScripting;


public class PlayerCar : BaseCar
{
    public override void Movement()
    {
        motor = maxMotorTorque * Input.GetAxis("Vertical");
        steering = maxSteeringAngle * Input.GetAxis("Horizontal");
        Break = Input.GetKey(KeyCode.Space) ? BreakForce : 0;
        base.Movement();
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            rb.AddForce(transform.forward * 20000, ForceMode.Impulse);
        }
    }
}