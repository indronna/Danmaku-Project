using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ShootDaWoop : MonoBehaviour
{

    public GameObject bouboule;
    public float speed = 100f;
    public float dps = 3;

    float timeLeft = 1f;
    // Update is called once per frame
    void Update()
    {
        if (timeLeft <= 0f || Input.GetKeyDown(KeyCode.Space))
        {
            GameObject instBouboule = Instantiate(bouboule, transform.position, Quaternion.identity);
            Rigidbody instBoubouleRigidBody = instBouboule.GetComponent<Rigidbody>();
            instBoubouleRigidBody.AddForce(Vector3.forward * speed);
        }
    }
}
