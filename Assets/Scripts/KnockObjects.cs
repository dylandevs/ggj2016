using UnityEngine;
using System.Collections;

public class KnockObjects : MonoBehaviour 
{
	public Vector3 ExpPos;
	public GameObject[] BrokenObjects;
	public float radius;
	public float Power;

	void OnCollisionEnter(Collision Other)
	{
		ExpPos = transform.position;
		if(Other.transform.CompareTag("Pawz"))
		{
			
			for (int x = 0; x < BrokenObjects.Length; x++) 
			{
				GameObject tempObject = (GameObject)Instantiate (BrokenObjects [x],transform.position, Quaternion.identity);
				tempObject.transform.GetComponent<Rigidbody> ().AddExplosionForce (Power,tempObject.transform.position , radius);
			}

			transform.gameObject.SetActive (false);
		}
		else if (!this.transform.CompareTag ("Cake"))
		{
			if(Other.transform.CompareTag("Ground"))
			{
				//transform.gameObject.SetActive (false);

				for (int x = 0; x < BrokenObjects.Length; x++) 
				{
					GameObject tempObject = (GameObject)Instantiate (BrokenObjects [x],transform.position, Quaternion.identity);
					tempObject.transform.GetComponent<Rigidbody> ().AddExplosionForce (Power,tempObject.transform.position , radius);
				}		

				transform.gameObject.SetActive (false);
			}

			//transform.gameObject.SetActive (false);
		}
	}
}
