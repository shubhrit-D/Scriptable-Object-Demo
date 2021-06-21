using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValueGetter : MonoBehaviour
{
    [SerializeField]
    private ScriptableManager scriptableManager;
    [SerializeField]
    private Text myText;

    private void Start()
    {
        GetValues();
    }

    public void GetValues()
    {
        Debug.Log(scriptableManager.someString);
        myText.text = scriptableManager.someString;
    }
}
