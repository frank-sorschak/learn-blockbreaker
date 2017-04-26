﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string name) {
        Debug.Log("Level load requested for: " + name);
        SceneManager.LoadScene(name);

    }

    public void QuitGame() {
        Debug.Log("Quit Game requested");
        Application.Quit();
    }


}
