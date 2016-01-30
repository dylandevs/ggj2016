using UnityEngine;
using System.Collections;

public class SwiperNoSwiping : MonoBehaviour {
    public bool logging = false;
    public GameObject LeftPaw;
    public Animator lpAnim;
    public GameObject RightPaw;
    public Animator rpAnim;



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
        if (goRight)
        {
            if (logging) Debug.Log("LOG: Swipey rightey");
            rpAnim.SetTrigger("DoBap");
            rpAnim.SetInteger("BapType", Random.Range(0, 3));
        }
        else
        {
            if (logging) Debug.Log("LOG: Swipey leftey");
            lpAnim.SetTrigger("DoBap");
            lpAnim.SetInteger("BapType", Random.Range(0,3));
        }
    }
}
