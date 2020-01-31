using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCreatorScript : MonoBehaviour
{
    GameObject BaseModel;
    GameObject BaseLibrary;
    BaseChoice bsScript;

    GameObject NameInput;

    string MiniatureName;
    
    void Start()
    {
        BaseLibrary = GameObject.Find("BaseLibrary");
        bsScript =  BaseLibrary.GetComponent<BaseChoice>();
        NameInput = GameObject.Find("Name");
    }

    public void CreateMini() {
        BaseModel = bsScript.GetChosenBase();
        GameObject Miniature =  Instantiate(BaseModel, new Vector3(0, 0, 0), Quaternion.identity);
        Miniature.GetComponent<BaseClass>().SetName("rbhbkkk");
      //  var BaseScript = BaseModel.GetComponent<BaseClass>();
        //BaseScript.SetPlayer(1);
        //BaseScript.SetName;
    }
}
