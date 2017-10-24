using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string levelName)
    {
        Debug.Log("Level: " + levelName);
        SceneManager.LoadScene(levelName);
    }
    public void quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;   
    }
}
