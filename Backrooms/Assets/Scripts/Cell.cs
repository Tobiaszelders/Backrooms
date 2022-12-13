using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{ 
    [SerializeField] private int spawnChance;
    [SerializeField] private int entitySpawnChance;
    [SerializeField] private Vector3 position;
    [SerializeField] private CellType cellType;

    public enum CellType
    {
        Default,
        Spawn,
        Exit,
        Manila
    }

    public Cell(int SpawnChance, int EntitySpawnChance, Vector3 Position, CellType CellType)
    {
        spawnChance = SpawnChance;
        entitySpawnChance = EntitySpawnChance;
        position = Position;
        cellType = CellType;
    }

}
