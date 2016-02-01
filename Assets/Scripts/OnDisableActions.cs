using UnityEngine;
using System.Collections;

public class OnDisableActions : MonoBehaviour {

	public float timeBonus;
    public AudioClip sound;

    AudioSource audioSource;

	void OnDisable(){
		if (timeBonus > 0f){
			GameController.AddTime(timeBonus);
		}
        if (sound) {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.clip = sound;
            audioSource.Play();
        }

	}
}
