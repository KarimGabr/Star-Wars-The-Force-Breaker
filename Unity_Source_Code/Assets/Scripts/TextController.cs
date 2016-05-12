using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextController : MonoBehaviour 
{
	public Text txt;
	public static bool Win;

	void Start () 
	{
		if(Win == true)
		{
			txt.text = "WE WIN! LET'S INFILTRATE THE DEATH STAR!";
		}

		else if(Win == false)
		{
			txt.text = "WE LOST! BUT WE WILL NEVER GIVE UP!";
		}
	}

	void Update () 
	{
	
	}
}
