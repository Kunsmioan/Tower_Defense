using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static bool GameIsOver;

	public GameObject gameOverUI;
	public GameObject completeLevelUI;

	void Start ()
	{
		GameIsOver = false;
	}

	// Update is called once per frame
	void Update () {
		if (GameIsOver)
			return;

		if (PlayerStats.Lives <= 0)
		{
			EndGame();
		}
	}

	void EndGame ()
	{
		GameIsOver = true;
		gameOverUI.SetActive(true);
	}

    //public void WinLevel ()
    //{
    //	GameIsOver = true;
    //	completeLevelUI.SetActive(true);
    //}

    public void WinLevel()
    {
        GameIsOver = true;
        if (completeLevelUI != null)
        {
            completeLevelUI.SetActive(true);
        }
        else
        {
            Debug.LogError("Chưa gán Complete Level UI trong Inspector của GameManager!");
        }
    }

}
