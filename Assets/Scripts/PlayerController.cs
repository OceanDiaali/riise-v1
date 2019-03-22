using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		//rb2d.velocity = new Vector2 (Input.GetAxisRaw("Horizontal") * speed, 0);
		float moveHorizontal = Input.GetAxis("Horizontal");
		Vector2 move = new Vector2 ((moveHorizontal) * speed, 0);
		rb2d.velocity = move;
	}
}
