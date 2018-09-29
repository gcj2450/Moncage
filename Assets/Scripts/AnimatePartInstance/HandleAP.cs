using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HandleAP : AnimatePartBase
{
    public GameObject light;


    public override void DoEvent()
    {
        if (phase == 0)
        {
            if (isConnectActive)
            {
                light.GetComponent<MeshRenderer>().material.DOVector(new Vector4(1, 0, 0, 0), "_Emission", 0.2f);
                transform.parent.DORotate(new Vector3(-30, 60, 0), 0.2f);
                GameObject.Find("M-01-TestMarkPosition").SetActive(false);
                GameObject.Find("UnderGear").GetComponent<SelfRotation>().enabled = true;
            }
            else
            {
                return;
            }
        }
        else if (phase == 1)
        {
            
        }
        
    }

}
