using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour 
{
	private Paddle paddle;
	public static bool gameHasStarted = false;
	private Vector3 paddleToBallVector;

	void Start () 
	{
		gameHasStarted = false;
		paddle = GameObject.FindObjectOfType<Paddle>();
		paddleToBallVector = this.transform.position - paddle.transform.position;
	}

	void Update () 
	{
		if (!gameHasStarted) 
		{
			this.transform.position = paddle.transform.position + paddleToBallVector;

			if (Input.GetMouseButtonDown(0)) 
			{
				gameHasStarted = true;
				this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
			}
		}

		//debugging 
		Debug.Log(this.GetComponent<Rigidbody2D>().velocity);
	}

	void OnCollisionEnter2D()
	{
		Vector2 speedIncrementUp = new Vector2(0.1f, 0.1f);
		Vector2 speedIncrementDown = new Vector2(-0.1f, -0.1f);
		if(this.GetComponent<Rigidbody2D>().velocity.y > 0)
		{
			this.GetComponent<Rigidbody2D>().velocity += speedIncrementUp;
		}
		else 
		{
			this.GetComponent<Rigidbody2D>().velocity += speedIncrementDown;
		}
		
	}
}
