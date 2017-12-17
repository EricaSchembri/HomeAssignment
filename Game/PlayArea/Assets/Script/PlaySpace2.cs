using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySpace2 : MonoBehaviour {
	public static int PlayerScore1;
	public static int PlayerScore2;


	GameObject theBall;

	void Start () {
		theBall = GameObject.FindGameObjectWithTag ("Ball");
	}
	public static void Score (string wallID) {
		if (wallID == "RightCollider")
		{
			PlayerScore1++;
		} else
		{
			PlayerScore2++;
		}
	}

	void OnGUI () {
		GUI.Label(new Rect(Screen.width / 2 - 150 - 0, 50, 100, 100), "" + PlayerScore1);
		GUI.Label(new Rect(Screen.width / 2 + 150 + 0, 50, 100, 100), "" + PlayerScore2);



		if (PlayerScore1 == 10)
		{
			NextLevel();
		}

		else if (PlayerScore2 == 10)
		{
			NextLevel();
		}
	}

	void NextLevel() {
		SceneManager.LoadScene("Level3");
	}
}