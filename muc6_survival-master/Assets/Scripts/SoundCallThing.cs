using UnityEngine;
using System.Collections;

public class SoundCallThing : MonoBehaviour 
{
	public AudioClip clip;
	public string bus;

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown ("d")) 
		{
			AudioManager.instance.Play(clip, bus);
		}
		else if (Input.GetKeyDown ("a")) 
		{
			AudioManager.instance.Play(clip, bus);
		}
		else if (Input.GetKeyDown ("s")) 
		{
			AudioManager.instance.Play(clip, bus);
		}
		else if (Input.GetKeyDown ("w")) 
		{
			AudioManager.instance.Play(clip, bus);
		}
	}
}
