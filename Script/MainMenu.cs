using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject CreditsPanel;
public void Start()
{
 CreditsPanel.SetActive(false);
}
public void CreditsPannel()
{
    CreditsPanel.SetActive(true);
}
public void PlayGame()
  {
    SceneManager.LoadScene("Game");
  }
public void QuitGame()
  {
    Application.Quit();
  }


public void CeditsBack()
    {
       CreditsPanel.SetActive(false); 
    }


}


