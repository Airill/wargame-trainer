using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    GameObject LastObject;
    private void Start() {
        
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit)) {
                   if (hit.transform.tag == "Base") {
                   hit.transform.GetComponentInChildren<LineRendererEx>().ChangeSliderStatus();
                   }
            }
        }
    }
}
 