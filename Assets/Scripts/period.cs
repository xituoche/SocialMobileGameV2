﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class period : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time, 2), transform.position.y, transform.position.z);
    }
}

