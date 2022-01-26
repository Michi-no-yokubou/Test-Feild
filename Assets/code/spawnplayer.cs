
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class spawnplayer : MonoBehaviour
{
    public GameObject player;
    public float minX,minY,maxX,maxY;
    public void Start()
    {
        Vector3 ramdomPosition = new Vector3(Random.Range(minX,maxX), Random.Range(minY,maxY));
        PhotonNetwork.Instantiate(player.name, ramdomPosition, Quaternion.identity);
    }
}
