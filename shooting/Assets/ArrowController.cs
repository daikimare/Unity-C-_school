using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Shoot(new Vector3(-6000,0,0));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Shoot(Vector3 dir) {
        GetComponent<Rigidbody>().AddForce(dir);
    }
    private void OnCollisionEnter(Collision other) {
        GetComponent<Rigidbody>().isKinematic = true;
    }
}
