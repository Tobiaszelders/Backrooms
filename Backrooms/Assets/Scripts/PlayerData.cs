using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData
{
    public int playerLevel;
    public int playerHealth;
    public float[] playerPosition;
    // ----- data for future -----
    // public int level (The floor level)
    // public float skills
    // public object inventory
    // public int kills
    // public float relation (with factions / npc's)
    // ===========================





    // constructor
    public PlayerData (Player player)
    {
        playerLevel = player.level;
        playerHealth = player.health;

        playerPosition = new float[3];
        playerPosition[0] = player.transform.position.x;
        playerPosition[1] = player.transform.position.y;
        playerPosition[2] = player.transform.position.z;
    }

}
