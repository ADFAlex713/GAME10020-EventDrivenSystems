using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    Vector3 floorSpacing = new Vector3 (0,10,0);
    public float elevatorSpeed = 2f;

    public void MoveUp()
    {
        transform.position = Vector3.MoveTowards(transform.position, floorSpacing, elevatorSpeed * Time.deltaTime);
    }

    public void MoveDown()
    {
        transform.position = Vector3.MoveTowards(transform.position, -floorSpacing, elevatorSpeed * Time.deltaTime);
    }
}
