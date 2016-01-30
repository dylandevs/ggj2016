using UnityEngine;
using System.Collections;

public class SwiperNoSwiping : MonoBehaviour {
    public GameObject LeftPaw;
    public GameObject RightPaw;



    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
            Swipe(false);

        if (Input.GetMouseButtonDown(1))
            Swipe(true);

    }

    public void Swipe(bool goRight = false)
    {

    }
}
