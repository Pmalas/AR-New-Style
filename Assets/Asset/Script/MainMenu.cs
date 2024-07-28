using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void Keluar(){
    Application.Quit();
    Debug.Log("Game Telah Keluar");
   }

   public void Tentang()
   {
    SceneManager.LoadScene("About");
   }

   public void Mulai()
   {
    SceneManager.LoadScene("Menu");
   }
}
