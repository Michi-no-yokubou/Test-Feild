using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using UnityEngine.UI;
using Photon.Realtime;

public class mainmenu : MonoBehaviourPunCallbacks
{
    public InputField createroom;
    public InputField joinroom;
    public void playgame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void quitgame(){
        Application.Quit();
    }
    public void create(){
        RoomOptions rop = new RoomOptions();
        rop.MaxPlayers=2;
        PhotonNetwork.CreateRoom(createroom.text, rop);
    }

    public void join(){
        PhotonNetwork.JoinRoom(joinroom.text);
    }

    public override void OnJoinedRoom(){
        PhotonNetwork.LoadLevel("game");
    }
}
