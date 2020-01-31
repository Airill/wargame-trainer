using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInputScript : MonoBehaviour
{
    string ChosenName;
    public GameObject input;

    void Start()
    {

    }

    public void NameChanged() {
        ChosenName = input.GetComponent<InputField>().text;
    }

    public string GetChosenName() {
        return ChosenName;
    }

}
