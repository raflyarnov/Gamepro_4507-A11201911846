using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptGUI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play(){
        SceneManager.LoadScene("GamePlay");
    }
    public void play2(){
        SceneManager.LoadScene("GamePlay2");
    }
    public void back(){
        SceneManager.LoadScene("Menu");
    }
    public void credits(){
        SceneManager.LoadScene("Credits");
    }
}
