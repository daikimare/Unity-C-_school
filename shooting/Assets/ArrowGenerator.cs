using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject ArrowPrefab;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            GameObject arrow = Instantiate(ArrowPrefab) as GameObject;
            arrow.GetComponent<ArrowController>().Shoot(new Vector3(-60000,0,0));
        }
    }
}
