using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InfoSekolah : MonoBehaviour
{
   public void Kembali()
   {
    SceneManager.LoadScene("Menu");
   }

   public void Maps()
   {
    Application.OpenURL("https://www.google.com/maps/place/SMK+Budi+Tresna+Muhammadiyah+Cirebon/@-6.7425455,108.4896853,17z/data=!3m1!4b1!4m6!3m5!1s0x2e6f1e3b77660e3d:0x900598acaa540514!8m2!3d-6.7425455!4d108.4922602!16s%2Fg%2F11cjkq0zyg?entry=ttu");
   }
}