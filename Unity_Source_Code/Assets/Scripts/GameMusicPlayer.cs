/*
            THIS SCRIPT FILE IS USELESS,, BUT WE ARE KEEPING IT IF WE NEED IT IN FUTURE AS IT
            EXPLAINS HOW TO HANDLE THE DUPLICATE GAMEOBJECT USING STATIC AND SINGLETON

 */

using UnityEngine;
using System.Collections;

public class GameMusicPlayer : MonoBehaviour 
{
	static GameMusicPlayer instance = null;

	void Awake()
	{
			if (instance != null) 
			{
				Destroy(gameObject);
				Debug.Log("Duplicate Music Player");
			}
			else
			{
				instance = this;
				if(Application.loadedLevel > 0)
					GameObject.DontDestroyOnLoad(gameObject);
				else if (Application.loadedLevel == 0)
					Destroy(gameObject);
			}
	}

	void Start () 
	{
	
	}

	void Update () 
	{
	
	}
}
