using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour
{
    public float dps = 1f;
    public GameObject bouboule;

    bool one = true;
    float timeLeft = 2f;
    private GameObject playerObj = null;
    // Start is called before the first frame update
    void Start()
    {
        if (playerObj == null)
            playerObj = GameObject.Find("FPC");

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 relativePos = playerObj.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
        transform.rotation = rotation;
            GameObject instBouboule = Instantiate(bouboule, transform.position, Quaternion.identity);
            instBouboule.GetComponent<BulletBehavior>().Shoot(transform.rotation);
        //Debug.Log("Player Position: X = " + playerObj.transform.position.x + " --- Y = " + playerObj.transform.position.y + " --- Z = " + playerObj.transform.position.z);
    }
}
