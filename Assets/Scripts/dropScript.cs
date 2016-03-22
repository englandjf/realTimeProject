using UnityEngine;
using System.Collections;

public class dropScript : MonoBehaviour {

	public GameObject spawner;
	public globalVars gv;

	// Use this for initialization
	void Start () {
		if(this.gameObject.tag == "controlled")
			StartCoroutine(groundCheck());
		else if(this.gameObject.tag == "static")
			StartCoroutine(groundCheckStatic());

		//subtract costs
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator groundCheck()
	{
		while(this.gameObject.transform.position.y >= .5f)
			yield return null;
		//particle or explosion
		spawner.GetComponent<Renderer>().material.color = Color.white;
		this.gameObject.AddComponent<cubeControl>().gv = gv;
		this.gameObject.AddComponent<NavMeshAgent>();
		Destroy(this.gameObject.GetComponent<Rigidbody>());
		gv.dropSelection = null;
	}

	IEnumerator groundCheckStatic()
	{
		while(this.gameObject.transform.position.y >= .5f)
			yield return null;

		spawner.GetComponent<Renderer>().material.color = Color.white;

		this.gameObject.AddComponent<buildingScript>();
		//will want to remove at some point?
		//Destroy(this.gameObject.GetComponent<Rigidbody>());
		gv.dropSelection = null;
	}		
}
