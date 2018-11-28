using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomroatoin : MonoBehaviour
{
    public float tumble;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * tumble;
    }
}