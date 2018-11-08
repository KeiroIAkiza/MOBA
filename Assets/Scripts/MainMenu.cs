using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	/*public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }*/

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    int state = 0;
    public int maxPlayers = 1; //On Complete this should be 12

    private void PlayGame()
    {
        switch (state)
        {
            case 0:
                    PhotonNetwork.ConnectUsingSettings("V1.0a");
                    state = 4;
                    Debug.Log("Case 0");
                break;
            case 1:
                /*if (GAMEMODE.ISPRESSED)
                {
                    PhotonNetwork.JoinLobby();
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    state = 4;
                    Debug.Log("Case 1");
                }*/
                break;
            case 2:
                /*if (FINDMATCH.ISPRESSED)
                {
                    PhotonNetwork.JoinRandomRoom();
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    state = 5;
                    Debug.Log("Case 2");
                }*/
                break;
            case 3:

                break;
            //Break
            case 4:
                Debug.Log("Case 4");
                break;
            //Matchmaking
            case 5:
                if (PhotonNetwork.inRoom == true && PhotonNetwork.playerList.Length == maxPlayers)
                {
                    LoadGame();
                    state = 3;
                }
                Debug.Log("Case 5");
                break;
        }

    }

    void OnConnectedToPhoton()
    {
        state = 1;
    }

    void OnJoinedLobby()
    {
        state = 2;
    }

    void OnPhotonRandomJoinedFailed()
    {
        PhotonNetwork.CreateRoom(null);
    }

    void LoadGame()
    {
        //load game scene here
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
