using UnityEngine;
using System.Collections;

public class controlScript : MonoBehaviour {

	public NavMeshAgent nm;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1))
			nm.SetDestination (getWorld());
	}

	Vector3 getWorld()
	{
		Ray tempRay = Camera.main.ScreenPointToRay (Input.mousePosition);
		Vector3 temp = tempRay.GetPoint (10);
		return temp;
	}
}
