using UnityEngine;
using UnityEngine.SceneManagement;

public class ClientManager : MonoBehaviour {

    //int state = 0;
    public int maxPlayers = 1; //On Complete this should be 12

    public void ExitLobby()
    {
        PhotonNetwork.LeaveLobby();
        PhotonNetwork.Disconnect();
        Debug.Log("Exiting Lobby");
        SceneManager.LoadScene("Menu");
        
    }

    public void PlayGame()
    {
        PhotonNetwork.JoinOrCreateRoom("test",new RoomOptions(),new TypedLobby("TEST",new LobbyType()));   
        Debug.Log("Joined Queue");
        //Add Queue here
        ChampionSelect();
    }

    //void OnPhotonRandomJoinedFailed()
    //{
    //    PhotonNetwork.CreateRoom(null);
    //    ChampionSelect();
    //    Debug.Log("Connected to Champion Select");
    //}

    //void JoinOrCreateRoom()
    //{
    //    //Queue System
    //    /*
    //    if(PhotonNetwork.inRoom == true && PhotonNetwork.playerList.Length == maxPlayers)
    //    {
    //        LoadGame();
    //        state = 3;
    //    }
    //    */
    //    ChampionSelect();
    //    
    //}

    void ChampionSelect()
    {
        //load game scene here
        SceneManager.LoadScene("ChampionSelect");
        Debug.Log("Connected to Champion Select");
    }
}