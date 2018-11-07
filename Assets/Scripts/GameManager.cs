using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour {

    public GameObject[] blueSpawns;
    public GameObject[] redSpawns;

    public int state = 0;

    void Connect(){
        //Connection method to be added
        //PhotonNetwork.ConnectToBestCloudServer("V1.0"); //Connects to "Version"
        state = 1;
    }

    void OnJoinedLobby(){
        state = 1;
    }
    
    void OnJoinedRoom(){
        state = 2;
    }
    void OnPhtonRandomJoinFailed(){
        //PhotonNetwork.CreateRoom(null);
    }

    private void OnGUI()
    {
        switch (state)
        {
            case 0:
                //Game type select
                if (GUI.Button(new Rect(10, 10, 100, 30), "Connect"))
                {
                    Connect();
                }
                break;
            case 1: 
                //Connect to server
                GUI.Label(new Rect(10,40,100,30), "Connected");
                if (GUI.Button(new Rect(10, 10, 100, 30), "Search")){
                    //PhotonNetwork.JoinRandomRoom();
                }
                break;
            case 2:
                //Champ select
                GUI.Label(new Rect(10, 40, 100, 30), "Select your Champion");
                if (GUI.Button(new Rect(70, 10, 100, 30), "Champion 1"))
                {
                    //Spawn(true, "Champion"); //Champion hardcoded PLEASE REPLACE
                }
                break;
            case 3:
                //IN GAME
                break;
        }
    }

    private void Exception()
    {
        Debug.Log("Game Manager error");
        throw new NotImplementedException();
    }    
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}