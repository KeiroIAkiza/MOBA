using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings("V1.0a");//Lines to be moved
        Debug.Log("Connected");                     //to login scene       
    }

    public void QuitGame()
    {
        PhotonNetwork.Disconnect();
        Debug.Log("Quit");
        Application.Quit();
    }
}
