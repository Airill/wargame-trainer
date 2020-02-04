using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HoveringTextScript : MonoBehaviour
{
    public Text BaseName;


    private void Start() {
       
    }
    private void Update() {
        Vector3 namePose = Camera.main.WorldToScreenPoint(this.transform.position);
        BaseName.transform.position = namePose;
    }
}
