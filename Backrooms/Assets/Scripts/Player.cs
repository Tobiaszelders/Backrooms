using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    public int level;
    [SerializeField]
    public int health;

    public void LevelUp()
    {
        level++;
    }

    public void TakeDamage() 
    {
        health--;
    }

    public void Heal()
    {
        health++;
    }
    
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        PlayerData playerData = SaveSystem.loadPlayerData();

        level = playerData.playerLevel;
        health = playerData.playerHealth;

        Vector3 position;
        position.x = playerData.playerPosition[0];
        position.y = playerData.playerPosition[1];
        position.z = playerData.playerPosition[2];
        transform.position = position;
    }

}
