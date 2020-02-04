using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerChoice : MonoBehaviour
{
    public Dropdown dropdown;
    int ChosenPlayer = 0;
    public Material[] Materials;
    Material ChosenMaterial;

    void Start() {
        ChosenMaterial = Materials[ChosenPlayer];
    }

    public void PlayerChanged() {
        ChosenPlayer = dropdown.value;
        switch (ChosenPlayer) {
            default:
            case 0:
                ChosenMaterial = Materials[0];
                break;
            case 1:
                ChosenMaterial = Materials[1];
                break;
        }
        Debug.Log("ChosenPlayer = " + dropdown.value);
    }

    public Material GetMaterial() {
        return ChosenMaterial;
    }
}
