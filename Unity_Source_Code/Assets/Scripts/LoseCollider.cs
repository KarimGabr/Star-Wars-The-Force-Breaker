using UnityEngine;
using System.Collections;
//using UnityEditor;

public class LoseCollider : MonoBehaviour 
{
	private LevelManager levelManager;

	void Start () 
	{
		levelManager = GameObject.FindObjectOfType<LevelManager>();
	}

	void Update () 
	{
	
	}

	void OnCollisionEnter2D(Collision2D collider)
	{
		Debug.Log("Collision");
		TextController.Win = false;
		levelManager.LoadLevel("WinScreen");
	}

	void OnTriggerEnter2D(Collider2D trigger)
	{
		Debug.Log("Trigger");
	}
}
