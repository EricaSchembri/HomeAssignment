using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnBricks : MonoBehaviour {

    public List<GameObject> listOfBricks = new List<GameObject>();
    
    // Use this for initialization
	void Start () {

        if (SceneManager.GetActiveScene().name == "Level 2")
        {
            listOfBricks.AddRange(Resources.LoadAll<GameObject>(""));

            Vector3 position = new Vector3(-5f, 3f, 0);
            Vector3 position2 = new Vector3(-5f, 4f, 0);

            for (int i = 1; i<= 10; i++)
            {
                GameObject go = listOfBricks[Random.Range(0, listOfBricks.Count)];

                Instantiate(go, position, Quaternion.identity);

                position.x += 1f;
            }
            
            for (int i = 1; i <= 10; i++)
            {
                GameObject go = listOfBricks[Random.Range(0, listOfBricks.Count)];

                Instantiate(go, position2, Quaternion.identity);

                position2.x += 1f;
            }
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
