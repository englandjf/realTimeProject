using UnityEngine;
using System.Collections;

public class tileScript : MonoBehaviour {

	bool over;
	bool selected;
	public globalVars gv;


	// Use this for initialization
	/*
	void Start () {
		gv = GameObject.Find ("Main Camera").GetComponent<globalVars> ();
	}


	
	// Update is called once per frame
	void Update () {
		if (gv.over == this.gameObject) {
			gameObject.GetComponent<Renderer> ().material.color = Color.yellow;
			if (Input.GetMouseButtonDown (0)) {
				gv.selected = this.gameObject;
			}
		}
		else
			gameObject.GetComponent<Renderer> ().material.color = Color.white;

		if (gv.selected == this.gameObject) {
			gameObject.GetComponent<Renderer> ().material.color = Color.red;
		}
	}
	*/

	void OnMouseEnter()
	{
		if (gv.menuState.name == "dropMenu" || gv.menuState.name == "buildMenu") {
			if (gv.selected != this.gameObject)
				gameObject.GetComponent<Renderer> ().materials [0].color = Color.yellow;
			gv.over = this.gameObject;
		}
	}

	void OnMouseOver()
	{
		if (gv.menuState.name =="dropMenu" || gv.menuState.name == "buildMenu") {
			if (Input.GetMouseButtonDown (0)) {
				//clears old
				if (gv.selected)
					gv.selected.GetComponent<Renderer> ().materials [0].color = Color.white;
				gameObject.GetComponent<Renderer> ().materials [0].color = Color.red;
				gv.selected = this.gameObject;
				gv.cs.createObject(gv.ob.cube1,this.gameObject);
			}
		}
	}

	void OnMouseExit()
	{
		if (gv.menuState.name == "dropMenu" || gv.menuState.name == "buildMenu") {
			if (gv.selected != this.gameObject)
				gameObject.GetComponent<Renderer> ().materials [0].color = Color.white;
			gv.over = null;
		}
	}
}
