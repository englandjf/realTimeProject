using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class globalVars : MonoBehaviour {

	public GameObject over;
	public GameObject selected;
	public float camDis;

	public GameObject menuState;

	public createScript cs;

	public objectBank ob;

	public GameObject selectedCube;

	public string dropSelection;

	//To avoid having to update every single one, just do it all at once
	public List<GameObject> powerList;
	public List<GameObject> metalList;
	public float powerAmt;
	public float metalAmt;

	// Use this for initialization
	void Start () {
		camDis = 10;
		powerAmt = 200;
		metalAmt = 100;
		powerList = new List<GameObject> ();
		metalList = new List<GameObject> ();

		setupBuildings();
		setupDrops();
	}
	
	// Update is called once per frame
	void Update () {
		if(selectedCube && Input.GetMouseButtonDown(1))
		{
			Ray a = Camera.main.ScreenPointToRay(Input.mousePosition);

			selectedCube.GetComponent<cubeControl>().moveTo(a.GetPoint(camDis));
		}

		if (Input.GetMouseButtonDown (0) && over && over.tag.Contains ("tile") && selectedCube) {
			selectedCube = null;
		}

		calculateResources ();

		//handle game logic here?
	}

	public void clearTileState()
	{
		if (over) {
			over.GetComponent<Renderer> ().materials [0].color = Color.white;
			over = null;
		}

		if (selected) {
			selected.GetComponent<Renderer> ().materials [0].color = Color.white;
			selected = null;
		}


	}

	public void setSelection(string selection)
	{
		dropSelection = selection;
	}

	void calculateResources()
	{
		powerAmt += powerList.Count/500.0f;
		metalAmt += metalList.Count/500.0f;
	}

	//NAMES MUST BE EXACTLY THE SAME AS PREFAB NAMES
	public Hashtable dropInfo;
	public Hashtable buildingInfo;
	void setupDrops()
	{
		dropInfo = new Hashtable();
		dropInfo.Add("cube1",new priceList(50,50));
		dropInfo.Add("tank1",new priceList(100,50));
	}

	void setupBuildings()
	{
		buildingInfo = new Hashtable();
		buildingInfo.Add("metalBuilding",new priceList(50,100));
		buildingInfo.Add("powerBuilding",new priceList(100,50));
	}


		


}
