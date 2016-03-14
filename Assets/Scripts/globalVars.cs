using UnityEngine;
using System.Collections;

public class globalVars : MonoBehaviour {

	public GameObject over;
	public GameObject selected;
	public float camDis;

	public GameObject menuState;

	// Use this for initialization
	void Start () {
		camDis = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
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


		


}
