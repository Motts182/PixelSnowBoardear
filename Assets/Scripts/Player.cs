using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
     
    Rigidbody2D rb2d;
    public bool ground;
    
    void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update() {

        if (Input.GetButtonDown("Fire1") && ground)
        {
            rb2d.AddForce(Vector2.up * 5 , ForceMode2D.Impulse);
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        //print("Enter");
        ground = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        //print("Exit");
        ground = false;
    }
}
