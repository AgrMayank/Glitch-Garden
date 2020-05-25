using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
	public AudioClip[] levelMusicChangeArray;

	private AudioSource audioSource;

	private void Awake ()
	{
		DontDestroyOnLoad (gameObject);
		Debug.Log ("Don't destroy on load " + name);
	}

	private void Start ()
	{
		audioSource = GetComponent<AudioSource> ();
	}

	private void OnLevelWasLoaded (int level)
	{
		AudioClip thisLevelMusic = levelMusicChangeArray [level];
		Debug.Log ("Playing Clip : " + thisLevelMusic);

		//If there is some music attached
		if (thisLevelMusic)
		{
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play ();
		}
	}

	public void ChangeVolume (float volume)
	{
		audioSource.volume = volume;
	}
}
