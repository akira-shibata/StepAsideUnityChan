using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyController : MonoBehaviour {

	private GameObject unityChan;

	// Use this for initialization
	void Start () {
		this.unityChan = GameObject.Find ("unitychan");
	}

	
	// Update is called once per frame
	void Update () {
		if (this.unityChan.transform.position.z > this.transform.position.z + 5.0){
				Destroy(this.gameObject);
			}
	}
}
