using UnityEngine;
using System.Collections;

public class EnemiGenerator : MonoBehaviour {

    public GameObject[] enemis;

    void Start() {
        FirstCall();
    }

     IEnumerator CreateEnemis (){
         yield return new WaitForSeconds(1f);
         Instantiate(enemis[0]);
         yield return null;
         FirstCall();
    }

     public void FirstCall() {
         StartCoroutine(CreateEnemis());
     }
}
