using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshtest : MonoBehaviour
{
    public GameObject go;
    public Mesh mesh;
    // Start is called before the first frame update
    void Start()
    {
        go.GetComponent<MeshFilter>().mesh = mesh;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
