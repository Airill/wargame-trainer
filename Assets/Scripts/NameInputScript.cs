using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameInputScript : MonoBehaviour
{
    public string ChosenName;
    public GameObject input;
    // Start is called before the first frame update
    void Start()
    {
       // input = GameObject.Find("ObjectName");
        //.GetComponent<InputField>();
    }

    public void NameChanged() {
      //  ChosenName = input.text;
    }

}
