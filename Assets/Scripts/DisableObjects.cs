using UnityEngine;
using System.Collections;

public class DisableObjects : MonoBehaviour {

	public float LifeTime;

	void Update () 
	{
		LifeTime -= Time.deltaTime;

		if (LifeTime < 0)
			Destroy (this.gameObject);
	}
}
