using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public static void SceneChange()
    {
        Scene curr = SceneManager.GetActiveScene();
        if(curr.name == "StageOne")
        {
            SceneManager.LoadScene("StageTwo");
        }
        else if(curr.name == "StageTwo")
        {
            SceneManager.LoadScene("StageThree");

        }
        else if(curr.name == "StageThree")
        {
            SceneManager.LoadScene("End");
        }
    }
    public static string getScene()
    {
        return SceneManager.GetActiveScene().name;
    }
    public void Restart()
    {
        SceneManager.LoadScene("Menu");
    }

    public void SceneOne()
    {
        SceneManager.LoadScene("StageOne");
    }

    public void SceneTwo()
    {
        SceneManager.LoadScene("StageTwo");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
