using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject gameOverMenu;

    //Event triggerd zie game menu. Enable en disable

    private void OnEnable()
    {
        PlayerHealth.OnPlayerCaught += EnableGameoverMenu; // Health op 0 opent Menu
    }

    private void OnDisable()
    {
        PlayerHealth.OnPlayerCaught -= EnableGameoverMenu; // Vice versa
    }


    public void EnableGameoverMenu()
    { 
    gameOverMenu.SetActive(true); // Opent GameOverMenu
    }

    public void RetstartLevel() 
    {
    SceneManager.LoadScene("SampleScene"); // Gaat terug naar Sample Scene na klik in GameOverMenu (eventsystem)
    }
}
