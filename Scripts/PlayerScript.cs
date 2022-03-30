using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
     public GameObject hand;
     public Text scoreText;
    // public Text DecreaseScoreText;
     public Text gameOver;
     public int score;

    // public int dScore;

     
    public float speed =10.0f;
    public float xMax =2.55f;
    public float xMin =-2.55f;
   
    void Start()
    {
      
      
      
     //movePlayer();  
     //StartCoroutine(pt());
    
    }

    // Update is called once per frame
    void Update()
    {
      movePlayer(); 
    }
    IEnumerator pt(){
            yield return new WaitForSeconds(3f);
            print("after two second");
        }
      
      
    void movePlayer(){
        float h = Input.GetAxis("Horizontal");
        Vector2 temp = transform.position;
        if(h > 0)
        {
         // move right side block
         //temp.x = temp.x + speed * Time.deltaTime;
         temp.x += speed * Time.deltaTime;
         print(h);
        }
         else if(h < 0)
        {
         // move left side block
          temp.x -= speed * Time.deltaTime;
          print(h);
        }
        if(temp.x < xMin ){
            temp.x = xMin;
        }
        if(temp.x > xMax ){
            temp.x = xMax;
        }
        transform.position = temp ;
    }
        void increaseScore()
    {
       
         score ++;
         scoreText.text="Score: " + score;
    }
    //   void decreaseScore() //decrease score method
    // {
       
    //      dScore ++;
    //      DecreaseScoreText.text="D-score: " + dScore;
    // }
        void OnTriggerEnter2D(Collider2D target){
            
         // print(target.tag);
           if(target.tag == "Bomb")
          {
                increaseScore();
                target.gameObject.SetActive(false);
              //Time.timeScale=0f;
          }    
           if(target.tag == "RedBomb")
          {
             target.gameObject.SetActive(false);
                gameOverScore();
          
             
                // increaseScore();
                
                 Time.timeScale=0f;
                 
          }    

          void gameOverScore(){
               hand.SetActive(true);
               
               gameOver.text="Your score is : " + score;

          }

        }
}
