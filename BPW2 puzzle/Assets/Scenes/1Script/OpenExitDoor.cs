using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenExitDoor : MonoBehaviour
{
    public GameObject txtToDisplay; //tekst UI ''Press F to interact''
    private bool PlayerInZone;
    public GameObject exitDoor; //Object die geactiveerd wordt (Deur opent)


    private void Start()
    {
        PlayerInZone = false;          //Bevindt de speler zich binnen de zone (voor interactie)     
        txtToDisplay.SetActive(false);
    }


    private void Update()
    {
        if (PlayerInZone && Input.GetKeyDown(KeyCode.F))   // Speler bevind zich in de zone en klikt op 'F'
        {
            exitDoor.SetActive(!exitDoor.activeSelf);  // bij interactie worrdt actief
            gameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<Animator>().Play("open");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            txtToDisplay.SetActive(true); //Als de speler zich in de zone bevindt wordt tekst zichtbaar
            PlayerInZone = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = false;
            txtToDisplay.SetActive(false); //Als de speler zich buiten de zone bevindt wordt verdwijnd de tekst
        }
    }
}