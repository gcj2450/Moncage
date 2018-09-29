using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolsControl : MonoBehaviour
{

	public Material needItemMat;
	public Material findItemMat;

	private List<string> needItemList = new List<string>();
	private List<string> hasItemList = new List<string>();
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.M))
		{
			foreach (string child in needItemList)
			{
				print(child);
			}
		}
	}
	
	public void AddNeedItem(GameObject needItem, Vector3 euler, Vector3 size)
	{
		needItemList.Add(needItem.name);
		GameObject newNeedItem = Instantiate(needItem, transform);
		newNeedItem.transform.localPosition = Vector3.zero;
		newNeedItem.GetComponent<MeshRenderer>().material = needItemMat;
		newNeedItem.layer = 0;
		newNeedItem.name = needItem.name;
		newNeedItem.AddComponent<SelfRotation>();
		newNeedItem.transform.rotation = Quaternion.Euler(euler);
		newNeedItem.transform.localScale = size;
		newNeedItem.GetComponent<SelfRotation>().rotationSpeed = Random.insideUnitSphere;
	}

	public bool NeedItem(string name)//check function
	{
		foreach (string child in needItemList)
		{
			if (child == name)
			{
				return true;
			}
		}

		return false;
	}

	public void FindItem(string name)
	{
		needItemList.Remove(name);
		hasItemList.Add(name);
		foreach (Transform child in transform)
		{
			if (child.name == name)
			{
				child.GetComponent<MeshRenderer>().material = findItemMat;
			}
		}
	}
	
	public bool HasItem(string name)//check function
	{
		foreach (string child in hasItemList)
		{
			if (child == name)
			{
				return true;
			}
		}

		return false;
	}

	public void RemoveItem(string name)
	{
		hasItemList.Remove(name);
		foreach (Transform child in transform)
		{
			if (child.name == name)
			{
				Destroy(child.gameObject);
			}
		}
	}
}
