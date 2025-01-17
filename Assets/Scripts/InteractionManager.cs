﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
	private Camera mainCameraBg;
	
	private Ray ray; 
	private RaycastHit rayhit;
	private LayerMask maskLayer = 1 << 16;

	private LayerMask[] zoneLayerArray = new LayerMask[5];
	// Use this for initialization
	void Start ()
	{
		mainCameraBg = GameObject.Find("MainCameraBg").GetComponent<Camera>();
		for (var i = 1; i <= 4; i++)
		{
			zoneLayerArray[i] = 1 << (11 + i);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			
			ray = mainCameraBg.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out rayhit, 150f, maskLayer))
			{
				print("mask detected");
				var index = (int) (rayhit.transform.name[4] - '0');
				ray = new Ray(rayhit.point,mainCameraBg.ScreenPointToRay(Input.mousePosition).direction);
				if (Physics.Raycast(ray, out rayhit, 100f, zoneLayerArray[index]))
				{
					print(rayhit.transform.name+" detected");
					var selectedPart = rayhit.transform.GetComponent<AnimatePartBase>();
					if (selectedPart != null)
					{
						selectedPart.DoEvent();
					}
				}
				else
				{
					print("nothing detected");
				}
			}
		}
		else
		{
			
		}
	}
}
