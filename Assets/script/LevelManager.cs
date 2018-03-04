using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {


    
	public void LoadLevel(string levelname)
    {
        SceneManager.LoadScene(levelname);
    }

    public void ExitGame()
    {
        Debug.Log("Game Exit !!!");
        Application.Quit();
    }
}
