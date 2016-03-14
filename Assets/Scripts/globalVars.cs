using UnityEngine;
using System.Collections;

public class globalVars : MonoBehaviour {

	public GameObject over;
	public GameObject selected;
	public float camDis;

	public GameObject menuState;

	public createScript cs;

	public objectBank ob;

	public GameObject selectedCube;

	// Use this for initialization
	void Start () {
		camDis = 10;
	}
	
	// Update is called once per frame
	void Update () {
		if(selectedCube && Input.GetMouseButtonDown(1))
		{
			Ray a = Camera.main.ScreenPointToRay(Input.mousePosition);

			selectedCube.GetComponent<cubeControl>().moveTo(a.GetPoint(camDis));
		}

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


		


}
