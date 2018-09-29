using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class WrenchAP : AnimatePartBase
{

    private ToolsControl toolsControlScript;

    private void Start()
    {
        toolsControlScript = GameObject.Find("ToolsControl").GetComponent<ToolsControl>();
    }

    public override void DoEvent()
    {
        if (phase == 0)
        {
            if (toolsControlScript.NeedItem(gameObject.name))
            {
                gameObject.SetActive(false);
                toolsControlScript.FindItem(gameObject.name);
            }

        }
        
    }

}
