using UnityEngine;
using System.Collections;

public class CameraSnap : MonoBehaviour {

    public GameObject LightSource;

    IEnumerator Snap()
    {
        LightSource.transform.GetComponent<Light>().enabled = true;
        yield return new WaitForSeconds(1);
        LightSource.transform.GetComponent<Light>().enabled = false;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.transform.CompareTag("Pawz"))
        {
            StartCoroutine(Snap());
        }
    }
}
