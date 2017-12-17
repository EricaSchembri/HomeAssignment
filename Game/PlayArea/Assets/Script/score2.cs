using UnityEngine;
using System.Collections;

public class score2 : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D hitInfo) {
		if (hitInfo.name == "ball")
		{
			string wallName = transform.name;
			PlaySpace.Score(wallName);
			hitInfo.gameObject.SendMessage("RestartGame", 1.0f, SendMessageOptions.RequireReceiver);
		}
	}
}