using UnityEngine;
using System.Collections;

public class Footprints : MonoBehaviour {

    public bool painted;
    float timer = 0.5f;
    Vector3 curPos;
    Vector3 lastPos;
    Vector3 dwn;
    public GameObject pawPrint;
    public LayerMask layerMask;
    // Use this for initialization
    void Start () {
        //painted = false;
        lastPos = new Vector3(0, 0, 0);
        //Ray ray = transform.TransformDirection(Vector3.down);
	}
	
	// Update is called once per frame
	void Update () {

        curPos = gameObject.transform.position;
        if (painted == true && curPos != lastPos )
        {
            //do the raycast down thing
            timer -= Time.deltaTime;
            //print(timer);
        }

        if (timer <= 0)
        {
            RaycastHit hit;
            //if (Physics.Raycast(transform.position, -Vector3.up, out hit, 100.0f, 12))
            if (Physics.Raycast(transform.position, -Vector3.up, out hit, 100.0f, layerMask))
            {
               // if (hit.collider.tag != "Player" &&
                //    hit.collider.tag != "Pawz")
                    Instantiate(pawPrint, hit.point + new Vector3 (0,0.05f,0), Quaternion.LookRotation(-hit.normal));
            }
            timer = 0.5f;
        }

        lastPos = curPos;
	}

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "paintTray")
        {
            painted = true;
        }
    }
}
