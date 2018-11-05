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

    void Connect()
    {
        //Connection method to be added
        PhotonNetwork.ConnectToBestCloudServer("V1.0");
        state = 1;
    }

    void OnJoinedLobby()
    {
        state = 1;
    }

    void OnPhtonRandomJoinFailed()
    {
        PhotonNetwork.CreateRoom(null);
    }

    void OnJoinedRoom()
    {
        state = 2;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    private void OnGUI()
    {
        switch (state)
        {
            case 0:
                //Start menu
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

        void Spawn(bool team, string character)
        {
            state = 3;
            string side = "ERROR";
            if (team == true)
            {
                side = "Blue";
            }
            else if (team == false)
            {
                side = "Red";
            }
            else
            {
                Exception();
            }
            Debug.Log("You are on " + side + " and you are playing " + character);
        }
    }

    private void Exception()
    {
        Debug.Log("Game Manager error");
        throw new NotImplementedException();
    }
}