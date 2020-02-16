using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineRendererEx : MonoBehaviour
{
    public Material material;
    public float LineWidth = 0.1f;
    public Slider slider;
    BaseClass BC;
    

    [Range(0.1f, 100f)]
    public float Radius = 1.0f;

    [Range(3, 256)]
    public int numSegments = 128;

    void Start() {
        BC = transform.parent.GetComponent<BaseClass>(); 
        DoRenderer();
    }

    public void ChangeRadius() {
        Radius = slider.value;
        BC.SetAuraRadius(Radius);
    }
    public void ChangeSliderStatus() {
        slider.gameObject.SetActive(!slider.gameObject.activeSelf);
    }

    public void DoRenderer() {
        LineRenderer lineRenderer = gameObject.GetComponent<LineRenderer>();
        Color c1 = new Color(0.5f, 0.5f, 0.5f, 1);
        lineRenderer.material = material;
        lineRenderer.startColor = c1;
        lineRenderer.endColor = c1;
        lineRenderer.startWidth = LineWidth;
        lineRenderer.endWidth = LineWidth;
        lineRenderer.positionCount = numSegments + 1;
        lineRenderer.useWorldSpace = false;

        float deltaTheta = (float)(2.0 * Mathf.PI) / numSegments;
        float theta = 0f;

        for (int i = 0; i < numSegments + 1; i++) {
            float x = Radius * Mathf.Cos(theta);
            float z = Radius * Mathf.Sin(theta);
            Vector3 pos = new Vector3(x, 0, z);
            lineRenderer.SetPosition(i, pos);
            theta += deltaTheta;
        }
    }
}