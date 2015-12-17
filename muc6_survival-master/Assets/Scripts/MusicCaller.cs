using UnityEngine;
using System.Collections;

public class MusicCaller : MonoBehaviour {

	public AudioClip clip;
	public string bus;
	// Use this for initialization
	void Start () 
	{
		AudioManager.instance.Play (clip, bus);
		DontDestroyOnLoad (gameObject);
	}

	void Update ()
	{
		DontDestroyOnLoad (gameObject);
	}
}
