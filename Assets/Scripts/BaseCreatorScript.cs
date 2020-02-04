using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCreatorScript : MonoBehaviour
{
    GameObject BaseModel;
    GameObject BaseLibrary;
    GameObject PlayerLibrary;
    GameObject NameInput;

    BaseChoice bsScript;    
    NameInputScript niScript;
    PlayerChoice pcScript;

    string MiniatureName;
    
    void Start()
    {
        PlayerLibrary = GameObject.Find("PlayerLibrary");
        pcScript = PlayerLibrary.GetComponent<PlayerChoice>();
        BaseLibrary = GameObject.Find("BaseLibrary");
        bsScript =  BaseLibrary.GetComponent<BaseChoice>();
        NameInput = GameObject.Find("Name");
        niScript = NameInput.GetComponent<NameInputScript>();
    }

    public void CreateMini() {
        BaseModel = bsScript.GetChosenBase();
        GameObject Miniature =  Instantiate(BaseModel, new Vector3(0, 0, 0), Quaternion.identity);
        Miniature.GetComponent<BaseClass>().SetName(niScript.GetChosenName());
        Miniature.GetComponent<BaseClass>().SetMaterial(pcScript.GetMaterial());

    }
}
