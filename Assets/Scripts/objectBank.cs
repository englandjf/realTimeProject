using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class objectBank : MonoBehaviour {
	//controllable
	public GameObject cube1;

	//static
	public GameObject dropBox;


	public GameObject getSelection(string selection)
	{
		Debug.Log("callede");
		switch(selection)
		{
		case "cube1":
			return cube1;
		case "dropBox":
			return dropBox;
		}
		return null;
	}
}
