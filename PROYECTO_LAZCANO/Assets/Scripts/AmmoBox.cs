using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class AmmoBox : MonoBehaviour, IBox
{
    public Transform container;
    public float rotationSpeed = 180f;
    public int ammo = 10;

    int IBox.getID()
    {
        return (int)BoxID.AMMO;
    }

    int IBox.OpenBox()
    {
        return ammo;
    }

    // Update is called once per frame
    void Update()
    {
        container.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
