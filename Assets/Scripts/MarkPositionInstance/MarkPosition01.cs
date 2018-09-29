using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MarkPosition01 : MarkPositionBase
{
	public GameObject light;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override float DoEvent()//return the wait time
    {
        print("position1 in");
	    light.GetComponent<MeshRenderer>().material.DOVector(new Vector4(0, 1, 0, 0), "_Emission", 0.2f);
	    GameObject.Find("handleMod").GetComponent<AnimatePartBase>().EnableIsConnectActive();
        exitIsActive = true;
        return 1f;
    }

    public override void DoExitEvent()
    {
        if (exitIsActive && transform.gameObject.activeSelf)
        {
            exitIsActive = false;
	        light.GetComponent<MeshRenderer>().material.DOVector(new Vector4(0, 0, 0, 0), "_Emission", 0.2f);
	        GameObject.Find("handleMod").GetComponent<AnimatePartBase>().DisableIsConnectActive();
            print("position1 exit");
        }        
    }
}
