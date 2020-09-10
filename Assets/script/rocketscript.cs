using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocketscript : MonoBehaviour
{
    public GameObject RocketPrefab;
    float shotSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GameObject Rocket = Instantiate(RocketPrefab, transform.position, Quaternion.identity);
            Rigidbody RocketRb = Rocket.GetComponent<Rigidbody>();
            RocketRb.AddForce(transform.forward * shotSpeed);
            Destroy(Rocket, 3.0f);
        }
    }
}
