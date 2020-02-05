using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoveringSlider : MonoBehaviour
{
    public Slider AuraSlider;


    private void Start() {

    }
    private void Update() {
        Vector3 namePose = Camera.main.WorldToScreenPoint(this.transform.position);
        AuraSlider.transform.position = namePose;
    }
}