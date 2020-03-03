using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
	private float speed = -12;
	private float deadline = -10;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (this.speed * Time.deltaTime, 0, 0);

		if (transform.position.x < this.deadline) {
			Destroy (gameObject);
		}
	}

	void OnCollisionEnter2D (Collision2D collision2d){
		if (collision2d.gameObject.tag == "BlockTag" || collision2d.gameObject.name == "ground") {
			GetComponent<AudioSource> ().Play ();
		}
	}
}
