using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string levelName)
    {
        Debug.Log(levelName + " is attempting to load.");
        Application.LoadLevel(levelName);
    }
}
