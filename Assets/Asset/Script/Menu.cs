using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void Kembali()
   {
    SceneManager.LoadScene("Main menu");
   }

   public void ScanBrosur()
   {
    SceneManager.LoadScene("Cara Scan Brosur");
   }

   public void InfoSekolah()
   {
    SceneManager.LoadScene("Info sekolah");
   }

   public void InfoPPDB()
   {
    SceneManager.LoadScene("Info PPDB");
   }

   public void InfoJurusan()
   {
    SceneManager.LoadScene("Info jurusan");
   }
}
