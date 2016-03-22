using UnityEngine;
using System.Collections;

public class cubeControl : MonoBehaviour {

	public globalVars gv;
	public NavMeshAgent nvm;

	// Use this for initialization
	void Start () {
		nvm = GetComponent<NavMeshAgent>();
		Debug.Log(this.gameObject.name.Remove(7));
		priceList temp = (priceList) gv.dropInfo[this.gameObject.name.Remove(this.gameObject.name.Length-7)];
		gv.metalAmt -= temp.metalAmt;
		gv.powerAmt -= temp.powerAmt;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver()
	{
		
		if (Input.GetMouseButtonDown (0)) {
			//if (gv.selectedCube)
			//	gv.selectedCube.GetComponent<Renderer> ().materials [0].color = Color.white;
			//gameObject.GetComponent<Renderer> ().materials [0].color = Color.red;
			gv.selectedCube = this.gameObject;
		}


	}

	public void moveTo(Vector3 dest)
	{
		nvm.SetDestination(dest);
	}
}
