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
		if(Other.transform.CompareTag("Player"))
		{
			transform.gameObject.SetActive (false);

			//transform.GetComponent<Rigidbody> ().AddExplosionForce (Power, ExpPos, radius);

			for (int x = 0; x < BrokenObjects.Length; x++) 
			{
				GameObject tempObject = (GameObject)Instantiate (BrokenObjects [x],transform.position, Quaternion.identity);
				BrokenObjects [x].transform.GetComponent<Rigidbody> ().AddExplosionForce (Power,tempObject.transform.position , radius);
			}


		}
	}
}
