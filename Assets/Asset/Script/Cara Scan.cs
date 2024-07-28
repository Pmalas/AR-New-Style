using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScanBrosur : MonoBehaviour
{
   public void Kembali()
   {
    SceneManager.LoadScene("Menu");
   }

   public void GoogleDrive()
   {
    Application.OpenURL("https://drive.google.com/file/d/16ySh0q11giPBiYQJlchUt1W6Gz3TX_lF/view?usp=sharing");
   }

   public void CaraScanBrosur()
   {
    SceneManager.LoadScene("Scan Brosur AR");
   }
}