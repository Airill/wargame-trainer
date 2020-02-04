using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass : MonoBehaviour
{
    string Name;
    int Player;
    Material Material;
    // GameObject Model;

    void Start() {
        GetComponentInChildren<TextMesh>().text = Name; // get name at start
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
