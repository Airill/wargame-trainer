using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass : MonoBehaviour
{
    string Name;
    string Color;
    GameObject Model;

    public void SetName (string name) {
        Name = name;
    }

    public void SetColor (string color) {
        Color = color;
    }

    public void SetModel (GameObject model) {
        Model = model;
    }
}
