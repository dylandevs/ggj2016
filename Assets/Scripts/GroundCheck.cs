using UnityEngine;
using System.Collections;

public class GroundCheck : MonoBehaviour 
{
	public GameObject LightSource;

	void OnCollisionEnter(Collision Other)
	{
		if(Other.transform.CompareTag("Ground") || Other.transform.CompareTag("Table"))
		{
			LightSource.gameObject.SetActive (false);

		}
	}
}
