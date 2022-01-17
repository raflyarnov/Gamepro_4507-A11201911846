using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 jumpforce = new Vector2(0,300);
    private GameObject player2;
    void Start()
    {
        player2 = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown("up")){
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpforce);
        }
    }
    private void OnTriggerEnter2D(Collider2D player2)
    {
       if(player2.tag == "pembatas")
       {
           Destroy(this.gameObject);
           SceneManager.LoadScene("GameOver2");
       }
       else if(player2.tag == "musuh")
       {
           Destroy(this.gameObject);
           SceneManager.LoadScene("GameOver2");
       }
    }
}
