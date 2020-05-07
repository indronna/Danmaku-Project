using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletBehavior : MonoBehaviour
{
    Vector3 mouvement = new Vector3(1,1,1);
    public float speed = 10f;
    bool ready = true;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (ready)
        {
            this.transform.position = (this.transform.position) + (mouvement * speed * Time.deltaTime);
        }
    }

    public void Shoot(Quaternion orientation)
    {
        Vector3 targetForward = orientation * Vector3.forward;
        Vector3 targetUp = orientation * Vector3.up;
        Debug.Log("TargetForward : " + targetForward + " TargetUp : " + targetUp);
        mouvement = targetForward;
        ready = true;
    }

    void OnTriggerEnter(Collider collider)
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collider.gameObject.name == "FPC")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            //SceneManager.LoadScene("Arena");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "LimitBox")
        {
            Destroy(this.gameObject);
        }
    }
}
