using UnityEngine;
using System.Collections;

public class BricksCreation : MonoBehaviour 
{
	public static int TotalBricks = 0;

	void Start () 
	{
		BricksCreationProcess();
	}

	void Update () 
	{
	
	}

	private void BricksCreationProcess()
	{
		TotalBricks = 0;
		if (Application.loadedLevel >= 1) 
		{
			for (int x = 1; x < 15; x++) 
			{
				Instantiate(Resources.Load("1-hit-brick"), new Vector3(x+0.5f , 10f, 0), Quaternion.identity);
				TotalBricks++;
			}
			if (Application.loadedLevel >= 2) 
			{
				for (int x = 1; x < 15; x++) 
				{
					Instantiate(Resources.Load("2-hit-brick"), new Vector3(x+0.5f , 9.5f, 0), Quaternion.identity);
					TotalBricks++;
				}
				if (Application.loadedLevel >= 3) 
				{
					for (int x = 1; x < 15; x++) 
					{
						Instantiate(Resources.Load("3-hit-brick"), new Vector3(x+0.5f , 9f, 0), Quaternion.identity);
						TotalBricks++;
					}
					if (Application.loadedLevel >= 4) 
					{
						for (int x = 1; x < 15; x++) 
						{
							Instantiate(Resources.Load("4-hit-brick"), new Vector3(x+0.5f , 8.5f, 0), Quaternion.identity);
							TotalBricks++;
						}
						if (Application.loadedLevel >= 5) 
						{
							for (int x = 1; x < 15; x++) 
							{
								Instantiate(Resources.Load("5-hit-brick"), new Vector3(x+0.5f , 8f, 0), Quaternion.identity);
								TotalBricks++;
							}
							if (Application.loadedLevel >= 6) 
							{
								for (int x = 1; x < 15; x++) 
								{
									Instantiate(Resources.Load("6-hit-brick"), new Vector3(x+0.5f , 7.5f, 0), Quaternion.identity);
									TotalBricks++;
								}
								if (Application.loadedLevel >= 7) 
								{
									for (int x = 1; x < 15; x++) 
									{
										Instantiate(Resources.Load("7-hit-brick"), new Vector3(x+0.5f , 7f, 0), Quaternion.identity);
										TotalBricks++;
									}
									if (Application.loadedLevel >= 8) 
									{
										for (int x = 1; x < 15; x++) 
										{
											Instantiate(Resources.Load("8-hit-brick"), new Vector3(x+0.5f , 6.5f, 0), Quaternion.identity);
											TotalBricks++;
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}
}
