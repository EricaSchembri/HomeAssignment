using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour {
    static MusicScript myMusicPlayer = null;

    void Awake()
    {
        if (myMusicPlayer == null)
        {
            myMusicPlayer = this;
            GameObject.DontDestroyOnLoad(this.gameObject);
        }
        else
        {

            print("Sound Object " + this.gameObject.GetInstanceID().ToString());
            Destroy(this.gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
