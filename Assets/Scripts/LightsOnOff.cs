using UnityEngine;
using System.Collections;

public class LightsOnOff : MonoBehaviour 
{
	public bool LightSwitch = false;
	public GameObject LightSource;
	public GameObject BackupLights;

	void Update()
	{
	}

	public void ToggleLightSwitch()
	{
		LightSwitch = !LightSwitch;

		if (!LightSwitch) 
		{
			LightSource.transform.GetComponent<Light> ().enabled = false;
			BackupLights.transform.GetComponent<Light> ().enabled = true;
		}
		else 
		{
			LightSource.transform.GetComponent<Light> ().enabled = true;
			BackupLights.transform.GetComponent<Light> ().enabled = false;
		}
	}



    void OnTriggerEnter(Collider other)
    {
		if(other.transform.CompareTag("Pawz"))
		{
				ToggleLightSwitch ();
		}
	}
}
