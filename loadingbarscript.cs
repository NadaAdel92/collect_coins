using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadingbarscript : MonoBehaviour {
    private bool loadscene = false;
    public string loadingscrenename;
    public Text loadingtext;
    public Slider sliderbar;


	// Use this for initialization
	void Start () {
        sliderbar.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        //if the start scene is not loaded
        if (Input.GetKeyUp(KeyCode.Space) && loadscene == false)
        {
            loadscene = true;
            sliderbar.gameObject.SetActive(true);
            loadingtext.text = "Loading...";
            //load the start  menue screne
            StartCoroutine(LoadNewScene(loadingscrenename));

        }
		
	}
    IEnumerator LoadNewScene(string screnename)
    {
        AsyncOperation async = SceneManager.LoadSceneAsync(screnename);
        for (double i = 0; i < 900000000000000000; i++)
        {
            for (double j = 0; j < 900000000000000000; j++)
            {

                for (double x = 0; x< 900000000000000000; x++)
                {
                    for (double d = 0; d < 900000000000000000; d++)
                    {
                        for (double a = 0; a < 900000000000000000; a++)
                        {
                            for (double b = 0; b < 900000000000000000; b++)
                            {
                                while (!async.isDone)
                                {
                                    float progress = Mathf.Clamp01(async.progress / .9f);
                                    sliderbar.value = progress;
                                    loadingtext.text = progress * 100f + "%";
                                    yield return null;
                                }
                            }
                        }
                    }
                }
            }
        }
    }

}
