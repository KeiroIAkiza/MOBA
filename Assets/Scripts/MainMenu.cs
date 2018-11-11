using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
        PhotonNetwork.ConnectUsingSettings("V1.0a");//Lines to be moved
        Debug.Log("Connected");                     //to login scene
        PhotonNetwork.JoinLobby();
        Debug.Log("In Lobby");
        SceneManager.LoadScene("Lobby");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
