using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformCode : MonoBehaviour {

	[SerializeField] private float objSpeed = 1f;	
	[SerializeField] private float resetPos = -28.62f;
	[SerializeField] private float lastPos = 66.4f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	protected virtual void Update () {
		transform.Translate(Vector3.left * (objSpeed * Time.deltaTime));
		if (transform.localPosition.x <= resetPos) {
			Vector3 newPos = new Vector3 (lastPos, transform.localPosition.y, transform.position.z);
			transform.position = newPos;
		}

	}  
}
