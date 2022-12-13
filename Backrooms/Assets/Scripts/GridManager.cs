using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[RequireComponent(typeof(Player))]
public class GridManager : MonoBehaviour
{
    [Header("Player")]
    public Player player;

    float playerX;
    float playerZ;
    float playerY;

    [Header("Cells")]
    public GameObject cell;
    

    void Start()
    {
        player = GetComponent<Player>();
        

    }
    void Update()
    {
        playerX = player.transform.position.x;
        playerX = player.transform.position.x;
        playerX = player.transform.position.x;
    }

    void NewGrid()
    {
        Instantiate(cell, new Vector3(playerX, playerY, playerZ), Quaternion.identity);
    }

    void  GetCell()
    {

    }
}
