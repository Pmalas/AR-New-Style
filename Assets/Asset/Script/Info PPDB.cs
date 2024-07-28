using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   public void Kembali()
   {
    SceneManager.LoadScene("Menu");
   }

   public void Google()
   {
    Application.OpenURL("https://docs.google.com/forms/d/e/1FAIpQLSdkRJi8XROdKXpAo-R05VKi3YoGmyffjZLrd1K8E8EE2tHR_w/viewform");
   }
}