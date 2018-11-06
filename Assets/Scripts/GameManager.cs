using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Pun;
using System;

public class GameManager : MonoBehaviour {

    public GameObject[] blueSpawns;
    public GameObject[] redSpawns;

    public int state = 0;

    void Connect(){
        //Connection method to be added
        PhotonNetwork.ConnectToBestCloudServer("V1.0"); //Connects to "Version"
        state = 1;
    }

    void OnJoinedLobby(){
        state = 1;
    }
    
    void OnJoinedRoom(){
        state = 2;
    }
    void OnPhtonRandomJoinFailed(){
        PhotonNetwork.CreateRoom(null);
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
                    PhotonNetwork.JoinRandomRoom();
                }
                break;
            case 2:
                //Champ select
                GUI.Label(new Rect(10, 40, 100, 30), "Select your Champion");
                if (GUI.Button(new Rect(70, 10, 100, 30), "Champion 1"))
                {
                    Spawn(true, "Champion"); //Champion hardcoded PLEASE REPLACE
                }
                break;
            case 3:
                //IN GAME
                break;
        }

        void Spawn(bool team, string character){
            state = 3;

            GameObject Player = PhotonNetwork.Instantiate(character, new Vector3(), new Quaternion(), 0); //Connect vector to a spawn cord and Quaternion to a set rotation for the chosen spawn   
            Player.GetComponent<CharacterController>().enabled = true; // Enable character controller locally
            //Player.GetComponent<MouseController>().enabled = true; // Enable mouse controls locally
            //Player.GetComponent<CharacterMotor>().enabled = true; // Enable character movement locally 
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