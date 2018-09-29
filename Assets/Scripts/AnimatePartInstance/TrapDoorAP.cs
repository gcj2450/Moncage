using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TrapDoorAP : AnimatePartBase {
    
    public override void DoEvent()
    {
        if (phase == 0)
        {
            transform.DOLocalMove(new Vector3(0.0664f,-0.1232f,-0.0603f), 0.5f);
            phase = 1;
        }
        else if (phase == 1)
        {
            transform.DOLocalMove(new Vector3(0.1f,-0.1232f,-0.005f), 0.5f);
            phase = 0;
        }
        
    }

}