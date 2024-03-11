using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICar : BaseCar
{
    private float Tmp;
    public override void Movement()
    {
        if(TargetPoint == null) TargetPoint = WayPoints.GetChild(WayIndex);
        if (Vector3.Distance(TargetPoint.position, transform.position) <= 10 && WayPoints.childCount > WayIndex + 1)
        {
            Debug.Log(WayIndex);
            WayIndex++;
            TargetPoint = WayPoints.GetChild(WayIndex);

            if (WayPoints.childCount == WayIndex)
            {
                
                GameManager gameManager = FindAnyObjectByType<GameManager>();
                gameManager.lose();
                Debug.Log("dfgsdfsdg");
            }
        }
        if (Tmp <= 100000)
        {
            rb.AddForce(rb.transform.forward * 200, ForceMode.Impulse);
            Tmp += 200;
        }
        Vector3 waypointRelativeDistance = transform.InverseTransformPoint(TargetPoint.position);
        waypointRelativeDistance /= waypointRelativeDistance.magnitude;
        steering = (waypointRelativeDistance.x / waypointRelativeDistance.magnitude) * 25; 
        base.Movement();
    }
}
