using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour 
{
	public static AudioManager instance = null;
	public GameObject AudioItemSFX;
	public GameObject AudioItemMX;

	private GameObject prefabBus;

	// Use this for initialization
	void Awake() 
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	public void Play(AudioClip clip, string bus) 
	{
		if (bus == "sfx") 
			prefabBus = AudioItemSFX;
		else if (bus == "mx")
			prefabBus = AudioItemMX;

		GameObject go = (GameObject)Instantiate (prefabBus);
		AudioSource src = go.GetComponent<AudioSource> ();
		src.clip = clip;
		
		src.Play ();
		Destroy (go, clip.length);
	}
}