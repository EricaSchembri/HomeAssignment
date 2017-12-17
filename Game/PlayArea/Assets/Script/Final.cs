using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : MonoBehaviour {

	int  PlayerOne_Total = PlaySpace.PlayerScore1 + PlaySpace1.PlayerScore1 + PlaySpace2.PlayerScore1;
	int PlayerTwo_Total = PlaySpace.PlayerScore2 + PlaySpace1.PlayerScore2 + PlaySpace2.PlayerScore2;

	void Start(){
	}	

	void OnGUI () {
		if (PlayerOne_Total > PlayerOne_Total){
			GUI.Label(new Rect(Screen.width / 2 - 0 - 12, 20, 100, 100), "" + "PLAYER ONE IS THE WINNER");
		}
		else{
			GUI.Label(new Rect(Screen.width / 2 - 0 - 12, 20, 100, 100), "" + "PLAYER TWO IS THE WINNER");
		}

	}

}