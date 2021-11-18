using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateAndJoin : MonoBehaviourPunCallbacks
{
    public InputField create;
    public InputField join;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(create.text);
    }
    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(join.text);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Classroom");  
    }
}
