using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseClass : MonoBehaviour
{
    string Name;
    int Player;
    Material Material;
    // GameObject Model;

    void Start() {
        GetComponentInChildren<Text>().text = Name; // get name at start
        GetComponent<MeshRenderer>().material = Material;
    }

    public void SetName (string name) {
        Name = name;
    }

    public void SetPlayer (int player) {
        Player = player;
    }

    public void SetMaterial (Material material) {
        Material = material;
    }
   /* public void SetModel (GameObject model) {
        Model = model;
    } */
}
