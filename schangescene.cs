using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class schangescene : MonoBehaviour {

	
	
	
	public void changeToscene (int sceneTochangeTo) {
        Application.LoadLevel(sceneTochangeTo);
		
	}

    public void loadlevel(int sceneindex)
    {
        StartCoroutine(LoadAsynchronously(sceneindex));
    }
    IEnumerator LoadAsynchronously(int sceneindex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneindex);
        while (!operation.isDone)
        {
            float progress =Mathf.Clamp01(operation.progress / .9f);
            Debug.Log(progress);
            yield return null;
        }
    }

    public void exitgame()
    {
        Debug.Log("exit page");
        Application.Quit();

    }
}
