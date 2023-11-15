using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitSphere : MonoBehaviour
{
    private Rigidbody obj;
    private bool _flag;
    
    void Start()
    {
        obj = GetComponent<Rigidbody>();
        
    }

    private void X()
    {
        obj.AddForce(0, 0, 5, ForceMode.VelocityChange);
    }

    private void FixedUpdate()
    {
        if (!_flag)
        {
            Invoke("X", 1f);
            _flag = true;
        }
    }
}
