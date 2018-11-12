using UnityEngine;
using UnityEngine.SceneManagement;

public class NetworkManager : MonoBehaviour {

    public int maxPlayers = 1; //On Complete this should be 12
    public RoomOptions roomOptions;

    public void JoinLobby()
    {
        PhotonNetwork.JoinLobby();
        Debug.Log("In Lobby");
    } 

    public void ExitLobby()
    {
        PhotonNetwork.LeaveLobby();       
        Debug.Log("Exiting Lobby");      
    }

    public void PlayGame()
    {
        PhotonNetwork.JoinOrCreateRoom("Blank", roomOptions, null);//"Blank" will need to be replaced to scale
        Debug.Log("Joined Queue");
        //Add Queue here
    }
}