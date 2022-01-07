using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioButton : MonoBehaviour
{
    public AudioSource myFx;
	public AudioClip clickFx;

	public void TriggerSound(){
		myFx.PlayOneShot(clickFx);
	}
}
