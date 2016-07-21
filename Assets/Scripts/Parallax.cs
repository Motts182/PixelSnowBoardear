using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {
    public float speed;
    float pos = 0;
    Renderer rend;

    void Awake() {
        rend = GetComponent<Renderer>();
    }

    void Update() {

        pos += speed;
         if (pos > 1.0f)
            pos -= 1.0f;

        rend.material.mainTextureOffset = new Vector2(pos, 0);
    }
}
