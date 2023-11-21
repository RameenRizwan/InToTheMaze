using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonbehaviour : MonoBehaviour
{
    public void OnButtonClick()
    {
        SceneManager.LoadScene("lvl1");
    }
}
