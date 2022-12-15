using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GridManager : MonoBehaviour
{
    [Header("Player")]
    public Transform player;

    [Header("Cells")]
    public Cell defaultCell;
    public Cell exitCell;
    public Cell manilaCell;


    float playerX;
    float playerZ;
    float playerY;

    //[Header("Cells")]
    //public GameObject cell;
    

    void Start()
    {
        //player = GetComponent<Transform>();
        SpawnGrid();

    }
    void Update()
    {
        playerX = player.transform.position.x;
        playerZ = player.transform.position.z;
        playerY = player.transform.position.y;
    }

    void SpawnGrid()
    {
        var Cel1 = RandomCellGenerator();
        Instantiate(Cel1, new Vector3(player.position.x, player.position.y + 3, player.position.z), Quaternion.identity);
        Debug.Log("Cell instantiated at");
        Debug.Log(player.position.x);
        Debug.Log(player.position.z);
        Debug.Log(player.position.y + 3);
    }


    void UpdateGrid(Player player)
    {
        int cellSizeX = 1;
        int cellSizeZ = 1;
        int cellSizeY = 1;
        int renderDistance = 1;

        //if (player.transform.position.x > cellSizeX )

        //Instantiate(cell, new Vector3(playerX, playerY, playerZ), Quaternion.identity);
        //Destroy();

    }

    Cell RandomCellGenerator()
    {
        //Cell defaultCell = new Cell(0.94f, 5, Cell.CellType.Default);
        //Cell exitCell = new Cell(0.05f, 0, Cell.CellType.Exit);
        //Cell manilaCell = new Cell(0.01f, 5, Cell.CellType.Manila);

        float randomPercentage = Random.value;

        if (randomPercentage < defaultCell.spawnChance)
        {
            return defaultCell;
        }
        else if (randomPercentage < defaultCell.spawnChance + exitCell.spawnChance)
        {
            return exitCell;
        }
        else
        {
            return manilaCell;
        }

    }
}
