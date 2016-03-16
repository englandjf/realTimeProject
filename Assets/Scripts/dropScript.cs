using UnityEngine;
using System.Collections;

public class dropScript : MonoBehaviour {

	public GameObject spawner;
	public globalVars gv;
	public ParticleSystem ps;

	// Use this for initialization
	void Start () {
		StartCoroutine(groundCheck());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator groundCheck()
	{
		while(this.gameObject.transform.position.y >= 1)
			yield return null;
		//particle or explosion
		ps.Play();
		spawner.GetComponent<Renderer>().material.color = Color.white;
		this.gameObject.AddComponent<cubeControl>().gv = gv;
		this.gameObject.AddComponent<NavMeshAgent>();
		Destroy(this.gameObject.GetComponent<Rigidbody>());
		gv.dropSelection = null;
	}
		
}
