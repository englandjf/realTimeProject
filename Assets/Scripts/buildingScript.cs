using UnityEngine;
using System.Collections;

public class buildingScript: MonoBehaviour{

	public globalVars gv;

	// Use this for initialization
	void Start () {
		if(this.gameObject.name.Contains("metal") || this.gameObject.name.Contains("power"))
			this.transform.rotation = Quaternion.Euler (new Vector3 (-90, 0, 0));

		Debug.Log(this.gameObject.name.Remove(this.gameObject.name.Length-7));
		//subtract costs
		priceList temp = (priceList) gv.buildingInfo[this.gameObject.name.Remove(this.gameObject.name.Length-7)];
		gv.metalAmt -= temp.metalAmt;
		gv.powerAmt -= temp.powerAmt;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
