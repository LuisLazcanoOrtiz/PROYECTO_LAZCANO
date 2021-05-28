using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class HealthBox : MonoBehaviour, IBox
{
    public Transform container;
    public float rotationSpeed = 180f;
    public int health = 5;

    int IBox.getID()
    {
        return (int)BoxID.HEALTH; 
    }

    int IBox.OpenBox()
    {
        return health;
    }

    // Update is called once per frame
    void Update()
    {
        container.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
