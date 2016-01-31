using UnityEngine;
using System.Collections;

public class Scratch : MonoBehaviour 
{
	public GameObject ScratchQuad;


	void OnCollisionEnter(Collision Other)
	{
		if(Other.transform.CompareTag("Pawz"))
		{
			ScratchObject ();
		}
	}

	public void ScratchObject()
	{
		ScratchQuad.SetActive (true);
	}
}
