using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass : MonoBehaviour
{
    string Name;
    int Player;
    // GameObject Model;

    void Start() {
        GetComponentInChildren<TextMesh>().text = Name; 
    }

    public void SetName (string name) {
        Name = name;
    }

    public void SetPlayer (int player) {
        Player = player;
    }

   /* public void SetModel (GameObject model) {
        Model = model;
    } */
}
