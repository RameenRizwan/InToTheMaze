using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wintrigger : MonoBehaviour
{
    private int scenenum;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(bringscene());
        
       
    }

    IEnumerator bringscene()
    {

        
        yield return new WaitForSeconds(2F);

        print("Trigger happened");



        scenenum = SceneManager.GetActiveScene().buildIndex;
        print("The scene number is: " + scenenum);
        print("************************************");


        

        PlayerPrefs.SetInt("SceneNumber", scenenum);
        SceneManager.LoadScene("Win");

    }
}
