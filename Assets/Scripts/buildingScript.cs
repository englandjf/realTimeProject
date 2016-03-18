using UnityEngine;
using System.Collections;

public class buildingScript: MonoBehaviour{



	// Use this for initialization
	void Start () {
		if(this.gameObject.name.Contains("metal") || this.gameObject.name.Contains("power"))
			this.transform.rotation = Quaternion.Euler (new Vector3 (-90, 0, 0));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
