using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    Vector3 mouvement = new Vector3(0,0,1);
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

/*    public void Orientation(Quaternion orientation)
    {
        //mouvement = new Vector3(orientation.y, orientation.x,0f);
        //Vector3 targetForward = targetRot * Vector3.forward;
        //Vector3 targetUp = targetRot * Vector3.up;
        ready = true;
    }*/
}
