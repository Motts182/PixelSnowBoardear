using UnityEngine;
using System.Collections;

public class EnemiGenerator : MonoBehaviour {

    public GameObject[] enemis;

    void Start() {
        FirstCall();
    }

     IEnumerator CreateEnemis (){
         yield return new WaitForSeconds(Random.Range(1, 4));
         var pepe = Instantiate(enemis[Random.Range(0,2)]);
         pepe.transform.position = transform.position;
         yield return null;
         FirstCall();
    }

     public void FirstCall() {
         StartCoroutine(CreateEnemis());
     }
}
