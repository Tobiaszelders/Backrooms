using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// static class is a class that can't be instantiated
public static class SaveSystem
{
    public static void SavePlayer(Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.smyl"; // any file type name is okay
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData playerData = new PlayerData(player); // using constructor

        formatter.Serialize(stream, playerData);
        stream.Close();
    }

    public static PlayerData loadPlayerData()
    {
        string path = Application.persistentDataPath + "/player.smyl";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData playerData = formatter.Deserialize(stream) as PlayerData;

            stream.Close();

            return playerData;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }

    }
}
