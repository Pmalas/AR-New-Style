using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tentang : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene("Main menu");
    }
}