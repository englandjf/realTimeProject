using UnityEngine;
using System.Collections;

public class createScript : MonoBehaviour {

	public GameObject tile;
	public GameObject metalTile;
	public GameObject powerTile;
	public globalVars gv;



	// Use this for initialization
	void Start () {
		createTiles ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void createTiles()
	{
		for (int x = 0; x <= 50; x++) {
			for (int z = 0; z <= 50; z++) {
				int aRand = Random.Range (0, 10);
				if (aRand == 0) {
					GameObject a = (GameObject)Instantiate (metalTile, new Vector3 (x, 0, z), Quaternion.Euler (new Vector3 (270, 0, 0)));
					a.GetComponent<tileScript> ().gv = this.gv;
					//a.GetComponent<tileScript> ().baseIndex = 0;
					a.GetComponent<Renderer> ().materials [0].color = Color.white;
				}
				else if (aRand == 1) {
					GameObject a = (GameObject)Instantiate (powerTile, new Vector3 (x, 0, z), Quaternion.Euler (new Vector3 (270, 0, 0)));
					a.GetComponent<tileScript> ().gv = this.gv;
					//a.GetComponent<tileScript> ().baseIndex = 0;
					a.GetComponent<Renderer> ().materials [0].color = Color.white;
				} else {
					GameObject a = (GameObject)Instantiate (tile, new Vector3 (x, 0, z), Quaternion.Euler (new Vector3 (270, 0, 0)));
					a.GetComponent<tileScript> ().gv = this.gv;
					//a.GetComponent<tileScript> ().baseIndex = 0;
					a.GetComponent<Renderer> ().materials [0].color = Color.white;
				}
			}
		}

	}

	public void createObject(GameObject objectSelection,GameObject objectDestination)
	{
		//for some reason this is still being called?
		if(gv.dropSelection != null && priceCheck(objectSelection.name)){
			//Vector3 start = objectDestination.transform.position;
			//start.y = 10;


			try{
				gv.dropSelection = null;
				gv.selected = null;
				objectDestination.GetComponent<Renderer>().material.color = Color.white;
				if(objectSelection.name.Contains("metal")){
					if(!objectDestination.name.Contains("metal"))
						return;
				}
				else if(objectSelection.name.Contains("power")){
					if(!objectDestination.name.Contains("power"))
						return;
				}
				GameObject a = (GameObject)Instantiate (objectSelection, objectDestination.transform.position, Quaternion.Euler (new Vector3(0, 0, 0)));
				//a.GetComponent<dropScript>().spawner = objectDestination;
				//a.GetComponent<dropScript>().gv = this.gv;

				if(a.name.Contains("metal"))
				{
					gv.metalList.Add(a);
				}
				else if(a.name.Contains("power"))
				{
					gv.powerList.Add(a);
				}

				if(a.tag == "static")
				{
					a.GetComponent<buildingScript>().gv = this.gv;
				}
				else if(a.tag == "controlled")
				{
					a.AddComponent<cubeControl>().nvm = a.AddComponent<NavMeshAgent>();
					a.GetComponent<cubeControl>().gv = this.gv;
				}

					
			}
			catch(System.Exception e){
				Debug.Log(e);
			}
		}
	}


	bool priceCheck(string name)
	{
		Debug.Log(name);
		if(name.Contains("Building")){
			priceList temp =  (priceList)gv.buildingInfo[name];
			if(gv.metalAmt - temp.metalAmt < 0)
				return false;
			if(gv.powerAmt - temp.powerAmt < 0)
				return false;
			return true;
		}
		else
		{
			priceList temp =  (priceList)gv.dropInfo[name];
			if(gv.metalAmt - temp.metalAmt < 0)
				return false;
			if(gv.powerAmt - temp.powerAmt < 0)
				return false;
			return true;
		}
	
	}


}
