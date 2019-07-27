using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject genie;
    GameObject message;

    Button yesButton;
    Button noButton;
    Text talkText;

    // Start is called before the first frame update
    void Start()
    {
        genie = GameObject.Find("Genie");
        message = GameObject.Find("Message");
        genie.SetActive(false);
        message.SetActive(false);

        yesButton = GameObject.Find("Yes Button").GetComponent<Button>();
        noButton = GameObject.Find("No Button").GetComponent<Button>();

        yesButton.gameObject.SetActive(false);
        noButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayTheGame()
    {
        Debug.Log("Play the game");
    }
}
