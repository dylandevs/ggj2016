using UnityEngine;
using System.Collections;

public class Papers : MonoBehaviour 
{
	public GameObject BrokenObjects;
	public int PapersNumber;

	void OnCollisionEnter(Collision Other)
	{
		PapersNumber = Random.Range (2, 5);

		if(Other.transform.CompareTag("Pawz"))
		{
			for (int x = 0; x < PapersNumber; x++) 
			{
				GameObject tempObject = (GameObject)Instantiate (BrokenObjects,transform.position, Quaternion.identity);
				tempObject.transform.localScale = new Vector3 (tempObject.transform.localScale.x, Random.Range (1, 2), tempObject.transform.localScale.z);
			}
		}
	}
}
