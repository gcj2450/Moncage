using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FurnanceDoorAP : AnimatePartBase
{

    public GameObject needItem;
    private ToolsControl toolsControlScript;

    private void Start()
    {
        toolsControlScript = GameObject.Find("ToolsControl").GetComponent<ToolsControl>();
    }

    public override void DoEvent()
    {
        if (phase == 0)
        {
            if (toolsControlScript.HasItem(needItem.name))//already has the item in find list
            {
                toolsControlScript.RemoveItem(needItem.name);
                transform.DOScale(Vector3.zero, 0.5f);
                phase = 1;
            }
            else if (toolsControlScript.NeedItem(needItem.name))//already has the item in need list
            {
                return;
            }
            else//no item in need list
            {
                toolsControlScript.AddNeedItem(needItem, new Vector3(50,90,50), new Vector3(3,3,3));   

            }
        }
        
    }

}
