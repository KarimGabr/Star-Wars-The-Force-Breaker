using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour 
{
	//autoplay for debugging 
	public bool autoPlay = false;
	//autoplay for debugging

	public AudioClip paddle;

	private Ball ball;


	void Start () 
	{
		ball = GameObject.FindObjectOfType<Ball>();
	}

	void Update () 
	{
		if(autoPlay)	moveAutoPlay();
		else moveWithMouse();
	}

	void moveWithMouse()
	{
		Vector3 paddlePosition = new Vector3(this.transform.position.x, this.transform.position.y, 0f);
		float mousePosition = Input.mousePosition.x / Screen.width * 16;
		paddlePosition.x = Mathf.Clamp(mousePosition, 1f, 15f);
		this.transform.position = paddlePosition;
	}

	//autoplay for debugging
	void moveAutoPlay()
	{
		Vector3 paddlePosition = new Vector3(this.transform.position.x, this.transform.position.y, 0f);
		float ballPosition = ball.transform.position.x;
		paddlePosition.x = Mathf.Clamp(ballPosition, 1f, 15f);
		this.transform.position = paddlePosition;
	}
	//autoplay for debugging

	void OnCollisionEnter2D(Collision2D collision)
	{
		if(Ball.gameHasStarted == true)	AudioSource.PlayClipAtPoint(paddle, transform.position);
	}
}
