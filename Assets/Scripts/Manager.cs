using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    int state = 0;
    public int maxPlayers = 1; //On Complete this should be 12

    private void PlayGame()
    {
        switch (state)
        {  
            case 0:
                //connect to PLAY
                /*if (PLAYBUTTON.ISPRESSED)
                {
                    PhotonNetwork.ConnectUsingSettings("V1.0a");
                    state = 4;
                }*/
                break;
            case 1:
                /*if (GAMEMODE.ISPRESSED)
                {
                    PhotonNetwork.JoinLobby();
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    state = 4;
                }*/
                break;
            case 2:
                /*if (FINDMATCH.ISPRESSED)
                {
                    PhotonNetwork.JoinRandomRoom();
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    state = 5;
                }*/
                break;
            case 3:

                break;
            //Break
            case 4:
                break;
            //Matchmaking
            case 5:
                if(PhotonNetwork.inRoom == true && PhotonNetwork.playerList.Length == maxPlayers)
                {
                    LoadGame();
                    state = 3;
                }
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