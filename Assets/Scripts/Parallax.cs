using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {
    float speed = 0.008f;
    float pos = 0;
    Renderer rend;

    void Awake() {
        rend = GetComponent<Renderer>();
    }

    void Update() {

        pos += speed;
         if (pos > 1.0f)
            pos -= 1.0f;

        print(pos);

        rend.material.mainTextureOffset = new Vector2(pos, 0);
    }
}
