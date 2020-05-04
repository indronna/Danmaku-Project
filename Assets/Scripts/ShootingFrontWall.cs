using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingFrontWall : MonoBehaviour
{
    List<GameObject> turret = new List<GameObject>();
    bool first = true;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            turret.Add(this.transform.GetChild(i).GetChild(0).GetChild(0).gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //turret[1].transform.GetComponent<ShootDaWoop>().Shoot();
        if (first)
        {
            first = false;
            StartCoroutine(Eventaille());
        }
    }

    IEnumerator Eventaille()
    {
        yield return new WaitForSeconds(0.2f);
        turret[1].transform.GetComponent<ShootDaWoop>().Shoot();
        yield return new WaitForSeconds(0.2f);
        turret[2].transform.GetComponent<ShootDaWoop>().Shoot();
        turret[0].transform.GetComponent<ShootDaWoop>().Shoot();
        yield return new WaitForSeconds(0.2f);
        turret[9].transform.GetComponent<ShootDaWoop>().Shoot();
        turret[3].transform.GetComponent<ShootDaWoop>().Shoot();
        yield return new WaitForSeconds(0.2f);
        turret[10].transform.GetComponent<ShootDaWoop>().Shoot();
        turret[4].transform.GetComponent<ShootDaWoop>().Shoot();
        yield return new WaitForSeconds(0.2f);
        turret[11].transform.GetComponent<ShootDaWoop>().Shoot();
        turret[5].transform.GetComponent<ShootDaWoop>().Shoot();
        yield return new WaitForSeconds(0.2f);
        turret[12].transform.GetComponent<ShootDaWoop>().Shoot();
        turret[6].transform.GetComponent<ShootDaWoop>().Shoot();
        yield return new WaitForSeconds(0.2f);
        turret[13].transform.GetComponent<ShootDaWoop>().Shoot();
        turret[7].transform.GetComponent<ShootDaWoop>().Shoot();
        yield return new WaitForSeconds(0.2f);
        turret[14].transform.GetComponent<ShootDaWoop>().Shoot();
        turret[8].transform.GetComponent<ShootDaWoop>().Shoot();
    }
}
