using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class wintrigger : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(bringscene());
        
       
    }

    IEnumerator bringscene()
    {

        
        yield return new WaitForSeconds(2F);

        print("Trigger happened");

        SceneManager.LoadScene("Win");

    }
}
