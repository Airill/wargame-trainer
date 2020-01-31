using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseChoice : MonoBehaviour
{
    public Dropdown dropdown;
    GameObject ChosenBase;
    BaseLibraryScript library;

    void Start()
    {
        library = gameObject.GetComponent<BaseLibraryScript>();
        ChosenBase = library.Bases[0];
        
    }

    public void BaseChanged() {
        
        ChosenBase = library.Bases[dropdown.value];
    }

    public GameObject GetChosenBase() { 
        return ChosenBase;
    }
}
