using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectorScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    public int DecreaseScore;
    
    void DecreaseSc()
    {
        DecreaseScore ++;
        scoreText.text="D-core: " + DecreaseScore;
    }
     void OnTriggerEnter2D(Collider2D target)
     {// this is downfall box collector function
         if(target.tag == "Bomb")
        {
             // DecreaseSc();
            //  target.gameObject.SetActive(false);
             
        
        }
     
   }
}
