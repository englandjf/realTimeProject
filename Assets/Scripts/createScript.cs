using UnityEngine;
using System.Collections;

public class createScript : MonoBehaviour {

	public GameObject tile;
	public GameObject metalTile;
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
					a.GetComponent<Renderer> ().materials [0].color = Color.white;
				} else {
					GameObject a = (GameObject)Instantiate (tile, new Vector3 (x, 0, z), Quaternion.Euler (new Vector3 (270, 0, 0)));
					a.GetComponent<tileScript> ().gv = this.gv;
					a.GetComponent<Renderer> ().materials [0].color = Color.white;
				}
			}
		}

	}

	public void createObject(GameObject objectSelection,GameObject objectDestination)
	{
		//for some reason this is still being called?
		if(gv.dropSelection != null){
			Vector3 start = objectDestination.transform.position;
			start.y = 10;
			try{
				GameObject a = (GameObject)Instantiate (objectSelection, start, Quaternion.Euler (new Vector3(0, 0, 0)));
				a.GetComponent<dropScript>().spawner = objectDestination;
				a.GetComponent<dropScript>().gv = this.gv;
			}
			catch(System.Exception e){
				Debug.Log(e);
			}
		}
	}

}
