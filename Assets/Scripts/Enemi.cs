using UnityEngine;
using System.Collections;

public class Enemi : MonoBehaviour {
    public float speed;
	// Use this for initialization
	void FixedUpdate () {
        GetComponent<Rigidbody2D>().AddForce(Vector2.left * speed, ForceMode2D.Force);
	}
}
