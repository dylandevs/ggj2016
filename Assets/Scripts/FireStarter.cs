using UnityEngine;
using System.Collections;

public class FireStarter : MonoBehaviour {
    ParticleSystem particles;
	// Use this for initialization
	void Start () {
        particles = gameObject.GetComponentInChildren<ParticleSystem>();
	}

    void OnCollisionEnter(Collision Other)
    {
        if (Other.transform.CompareTag("Pawz"))
        {
            particles.Play();
        }
    }


}
