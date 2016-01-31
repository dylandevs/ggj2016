using UnityEngine;
using System.Collections;

public class ElectricalEffect : MonoBehaviour
{
    public GameObject Screen;

    void OnCollisionEnter(Collision Other)
    {
        if (Other.transform.CompareTag("Pawz"))
        {
            Screen.transform.GetComponent<ParticleSystem>().Play();
        }
    }
}
