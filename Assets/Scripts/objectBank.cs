using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class objectBank : MonoBehaviour {
	//controllable
	public GameObject cube1;
	public GameObject tank1;

	//static
	public GameObject dropBox;
	public GameObject metalBuilding;
	public GameObject powerBuilding;


	public GameObject getSelection(string selection)
	{
		Debug.Log("callede");
		switch(selection)
		{
		case "cube1":
			return cube1;
		case "dropBox":
			return dropBox;
		case "metalBuilding":
			return metalBuilding;
		case "tank1":
			return tank1;
		case "powerBuilding":
			return powerBuilding;
		}
		return null;
	}
}
