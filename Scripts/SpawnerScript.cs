using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerScript : MonoBehaviour
{
      public GameObject bombPrefab;
      public float xMax =2.55f;
      public float xMin =-2.55f;

    // Start is called before the first frame update
    void Start()
    {
        
     //StartCoroutine(SpawnBombs());
     StartCoroutine(RedSpawnBombsSTart());
    
    }
     IEnumerator SpawnBombs(){
         yield return new WaitForSeconds(Random.Range(0f,1f));
         Instantiate(bombPrefab,new Vector2(Random.Range(xMin,xMax),transform.position.y),Quaternion.identity);
          StartCoroutine(SpawnBombs());
     }   

     IEnumerator RedSpawnBombsSTart(){
       yield return new WaitForSeconds(3f);
        StartCoroutine(RedSpawnBombs());

     }

     IEnumerator RedSpawnBombs(){
         yield return new WaitForSeconds(Random.Range(0f,2f));
         Instantiate(bombPrefab,new Vector2(Random.Range(xMin,xMax),transform.position.y),Quaternion.identity);
          StartCoroutine(RedSpawnBombs());
     }   

    // Update is called once per frame
    void Update()
    {
       
    }
    
}
