﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject arrow = Instantiate(arrowPrefab) as GameObject;
        arrow.GetComponent<ArrowController>().Shoot(new Vector3(0,200,2000));
    }
}
