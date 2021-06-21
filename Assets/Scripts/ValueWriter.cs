using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueWriter : MonoBehaviour
{
    [SerializeField]
    private ScriptableManager scriptableManager;

    private void Start()
    {
        StoreData();
    }

    public void StoreData()
    {
        scriptableManager.someString = "String from scene 1.";
    }
}
