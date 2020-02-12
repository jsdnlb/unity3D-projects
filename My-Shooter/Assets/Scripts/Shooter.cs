using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    public float fireRate;
    private float nextFire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) && Time.time > nextFire) {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
        }
    }
}
