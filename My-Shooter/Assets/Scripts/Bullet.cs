﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        Destroy(gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.forward * speed);
    }

    private void OnCollisionEnter(Collision collision){
        Destroy(gameObject);
    }
}
