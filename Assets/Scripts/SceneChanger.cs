using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField]
    private ScriptableManager scriptableManager;



    public void SwitchScene(string sceneName)
    {
        StoreData(sceneName);
        SceneManager.LoadScene(sceneName);
    }


    public void StoreData(string sceneName)
    {
        if (sceneName == "SampleScene")
        {
            scriptableManager.someString = "Changing text Sample scene";
        }
        if (sceneName == "NextScene")
        {
            scriptableManager.someString = "Changing text Next scene";
        }
    }
}
