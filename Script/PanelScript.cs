using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelScript : MonoBehaviour
{
   public void MainMenu()
   {
      SceneManager.LoadScene("MainMenu");
   }

   public void PlayAgain()
   {
    SceneManager.LoadScene("Game");
   }
}
