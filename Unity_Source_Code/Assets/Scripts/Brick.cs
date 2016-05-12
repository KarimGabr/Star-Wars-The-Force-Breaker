using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour 
{
	private int maxHits;
	private int timeHits;
	private LevelManager levelManager;

	public Sprite[] hitSprite;
	public AudioClip crack;
	public AudioClip destroy;

	void Start () 
	{
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		timeHits = 0;
	}

	void Update () 
	{
	
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		AudioSource.PlayClipAtPoint(crack, transform.position);
		bool isBreakable = (this.tag == "Breakable");
		if(isBreakable)	HandleHits();
	}

	void HandleHits()
	{
		timeHits++;
		maxHits = hitSprite.Length + 1;
		if(timeHits == maxHits)
		{
			AudioSource.PlayClipAtPoint(destroy, transform.position);
			BricksCreation.TotalBricks--;
			GameObject smokePuff = Instantiate(Resources.Load("smoke"), gameObject.transform.position, Quaternion.identity) as GameObject;
			smokePuff.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
			Destroy(gameObject);
			if(BricksCreation.TotalBricks == 0)
			{
				if(Application.loadedLevel == 8) TextController.Win = true;
				levelManager.LoadNextLevel();
			}
		}
		else LoadSprites(); 
	}

	void LoadSprites()
	{
		int spriteIndex = timeHits - 1;
		if (hitSprite[spriteIndex]) 
		{
			this.GetComponent<SpriteRenderer>().sprite = hitSprite[spriteIndex];	
		}
	}
}
