using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{ 
    [SerializeField] public float spawnChance;
    [SerializeField] public float entitySpawnChance;
    //[SerializeField] private Vector3? position;
    [SerializeField] public CellType cellType;

    public enum CellType
    {
        Default,
        Spawn,
        Exit,
        Manila
    }

    public Cell(float SpawnChance, float EntitySpawnChance, CellType CellType)
    {
        spawnChance = SpawnChance;
        entitySpawnChance = EntitySpawnChance;
        //position = Position;
        cellType = CellType;
    }

}
