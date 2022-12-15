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

    [Header("Render")]
    public int renderDistance;
    //public int initialCells = 9;
    public int initialCellRows;
    public int initialCellColumns; //square 3x3   rows horizantol - columns vertical

    List<Cell> activeCells;

    float cellSizeX = 1;
    float cellSizeZ = 1;
    float cellSizeY = 1;

    float playerX;
    float playerZ;
    float playerY;

    void Start()
    {
        //player = GetComponent<Transform>();
        SpawnGrid();

    }
    void Update()
    {
        playerX = player.position.x;
        playerZ = player.position.z;
        playerY = player.position.y;
    }

    void SpawnGrid()
    {
        for (int i = 0; i < initialCellColumns; i++)
        {
            float x = player.position.x - cellSizeX * i;
            for (int j = 0; j < initialCellRows; j++)
            {
                float z = player.position.z - cellSizeZ * j;
                var cell = RandomCellGenerator();
                Instantiate(cell, new Vector3(x + (initialCellColumns / 2), player.position.y + 5, z + (initialCellRows / 2)), Quaternion.identity);

            }
        }

    }


    void UpdateGrid()
    {
        //if(playerX > )
        

        //if (player.transform.position.x > cellSizeX )

        //Instantiate(cell, new Vector3(playerX, playerY, playerZ), Quaternion.identity);
        //Destroy();

    }

    Cell RandomCellGenerator()
    {
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
