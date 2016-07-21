using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {
    public Text point_txt;
    Rigidbody2D rb2d;
    public bool ground;
    public float JumpForce;
    public GameObject panel;
    public bool fist;
    public Text tabToStart;
    
    void Awake() {

        Time.timeScale = 0;
        fist = false;
        rb2d = GetComponent<Rigidbody2D>();
        tabToStart.gameObject.SetActive(true);
    }


    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !fist) {
            Time.timeScale = 1;
            tabToStart.gameObject.SetActive(false);
            fist = true;
        }
    }

    void FixedUpdate() {

        if (Input.GetButtonDown("Fire1") && ground)
        {
            rb2d.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
        }
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Point")
        {
            int i = int.Parse(point_txt.text);
            i += 3;
            point_txt.text = i.ToString();
        }
        else {
            ground = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        ground = false;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy") {
            Debug.Log("Enemy");
             panel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void LoadLevel() {
        Application.LoadLevel("One");
    }
}
