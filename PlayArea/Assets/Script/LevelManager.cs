using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadLevel(string levelName)
    {
        print("Loading Level " + levelName);

        //loads the Scene named levelName
        SceneManager.LoadScene(levelName);
    }

    public void Exit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }

    //Declare 2 Integer Variables
    int max = 1001;
    int min = 1;
    int guess = 500;
    int maxGuessesAllowed = 10;

    void NextGuess()
    {
        guess = (max + min) / 2;
        maxGuessesAllowed--;
        if (maxGuessesAllowed <= 0)
        {
            SceneManager.LoadScene("Win");
        }

    }

    void StartGame()
    {

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    void GuessHigher()
    {
        min = guess;
        NextGuess(); 
    }
}
