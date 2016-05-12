using UnityEngine;
using System.Collections;

public class MenuMusicPlayer : MonoBehaviour 
{
	static MenuMusicPlayer instance = null;
	public AudioClip menu;
	public AudioClip ingame;
	public AudioClip lose;
	public AudioClip win;
	//private MusicPlayer asa;
	//private AudioSource;

	void Awake()
	{
		AudioSource audio = GetComponent<AudioSource>();
		//GameObject.DontDestroyOnLoad(audio);
		//Vector3 soundPosition = new Vector3(0,0,0);
		//if(Application.loadedLevel == 0)	AudioSource.PlayClipAtPoint(menu, soundPosition);
		//else if(Application.loadedLevel > 0) AudioSource.PlayClipAtPoint(ingame, soundPosition);
		if(Application.loadedLevel == 0)
		{
			audio.Stop();
			audio.clip = menu;
			audio.Play();
		}

		if(Application.loadedLevel > 0 && Application.loadedLevel < 9)
		{
			audio.Stop();
			audio.clip = ingame;
			audio.Play();
		}

		if(Application.loadedLevel == 9)
		{
			audio.Stop();
			if(TextController.Win == true)
			{
				audio.Stop();
				audio.clip = win;
				audio.Play();
			}
			
			else if(TextController.Win == false)
			{
				audio.Stop();
				audio.clip = lose;
				audio.Play();
			}
		}
	}

	void Start () 
	{

	}

	void Update () 
	{
	
	}
}
