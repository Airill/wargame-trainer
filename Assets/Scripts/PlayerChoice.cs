using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerChoice : MonoBehaviour
{
    public Dropdown dropdown;
    public int ChosenPlayer;

    void Start() {

    }

    public void PlayerChanged() {
        ChosenPlayer = dropdown.value;
    }
}
