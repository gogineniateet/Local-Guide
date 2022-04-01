using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static string keyword;
    
    private void Start()
    {
        //StartCoroutine(GetRequest("https://bit.ly/3uKhB3g"));
    }


    public void Quit()
    {
        Application.Quit();
    }

    public void GoNextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void KeyWordForGoogle(string keywordName)
    {
        keyword = keywordName;
        Debug.Log(keyword);
        //string url = "https://github.com/OAI/OpenAPI-Specification/blob/main/examples/v3.0/link-example.json";
        //StartCoroutine(GetRequest());
    }
    
}
