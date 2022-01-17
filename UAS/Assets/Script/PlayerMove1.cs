using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove1 : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector2 jumpforce = new Vector2(0,300);
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown("space")){
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpforce);
        }
    }
    private void OnTriggerEnter2D(Collider2D player)
    {
       if(player.tag == "pembatas")
       {
           Destroy(this.gameObject);
           SceneManager.LoadScene("GameOver2");
       }else if(player.tag == "musuh")
       {
           Destroy(this.gameObject);
           SceneManager.LoadScene("GameOver2");
       }
    }
}
