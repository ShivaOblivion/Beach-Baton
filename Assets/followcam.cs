﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcam : MonoBehaviour
{
[SerializeField] private Transform target;


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y, target.position.z - 5f);
    }
}
