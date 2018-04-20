using UnityEngine;
using System.Collections;

public class FallInToDark : MonoBehaviour {


	public float State=0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col) 
	{
		if (col.gameObject.tag == "Player") 
		{
			State=1;
		}
		if (col.gameObject.tag == "Enemy") 
		{
			State=2;
		}
	}
	public float SomeOneFall()
	{
		return State;
	}
}
