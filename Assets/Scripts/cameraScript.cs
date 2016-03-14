using UnityEngine;
using System.Collections;

public class cameraScript : MonoBehaviour {

	Vector3 newPos;
	public globalVars gv;

	// Use this for initialization
	void Start () {
		newPos = new Vector3 ();
		newPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.mousePosition.x <= 20)
			newPos.x-=.2f;
		if (Input.mousePosition.x >= Screen.width - 20)
			newPos.x+=.2f;
		if (Input.mousePosition.y <= 20)
			newPos.z -= .2f;
		if (Input.mousePosition.y >= Screen.height - 20)
			newPos.z+=.2f;
		this.transform.position = newPos;

		Debug.Log (Input.mouseScrollDelta);

	}


}
