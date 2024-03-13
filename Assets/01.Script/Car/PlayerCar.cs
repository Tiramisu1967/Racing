using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System;
using Unity.VisualScripting;


public class PlayerCar : BaseCar
{
    private float Maxtime = 6f;
    private float CurrenTime = 0f;
    public override void Movement()
    {
        motor = maxMotorTorque * Input.GetAxis("Vertical");
        steering = maxSteeringAngle * Input.GetAxis("Horizontal");
        Break = Input.GetKey(KeyCode.Space) ? BreakForce : 0;
        base.Movement();
    }

    public IEnumerator Booster(int Speed)
    {
        float CurrentMotor = motor;
        motor = motor * Speed;
        yield return new WaitForSeconds(3f);
        motor = CurrentMotor;
        StopBoosterCoroutine();
    }

    public void StopBoosterCoroutine()
    {
        // 현재 진행 중인 Booster 코루틴을 중지
        StopCoroutine("Booster");
    }

    private void Update()
    {
        GameInstance.instance.PlayerPoint = this.gameObject;
        if(CurrenTime > 0)
        {
            CurrenTime -= Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            CurrenTime = Maxtime;
            StartCoroutine(Booster(20000));
        }
    }

    public void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Slow"))
        {
            SlowMap();
        }
        if (collision.gameObject.CompareTag("Map"))
        {
            MapCheck(collision);
        }
    }

    public void SlowMap()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity *= 0.5f;
        Debug.Log("ssssss");
    }

    public void MapCheck(Collision collision)
    {
        if(collision.gameObject.name == "Desert" && GameInstance.instance.isDesertWheel)
        {}
        else if (collision.gameObject.name == "Mountain" && GameInstance.instance.isMountainWheel)
        {}
        else if (collision.gameObject.name == "DownTown" && GameInstance.instance.isDownTownWheel)
        {}
        else
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.velocity *= 0.5f;
        }
    }
}