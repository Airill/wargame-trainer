using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseClass : MonoBehaviour
{
    string Name;
    int Player;
    float AuraRadius;
    Material Material;
    [SerializeField] GameObject NameText;
    [SerializeField] GameObject AuraText;
    // GameObject Model;

    void Start() {

        NameText.GetComponent<Text>().text = Name; // get name at start

        AuraText.GetComponent<Text>().text = AuraRadius.ToString();

        GetComponentInChildren<MeshRenderer>().material = Material;
    }

    public void SetAuraRadius(float radius) {
        AuraRadius = radius;
        AuraText.GetComponent<Text>().text = AuraRadius.ToString();
    }

    public float GetAuraRadius() { 
        return AuraRadius;
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
