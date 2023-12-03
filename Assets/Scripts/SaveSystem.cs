using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    private static string SavePath => Application.persistentDataPath + "/player.fun";

    public static void SavePlayer(Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        using (FileStream stream = new FileStream(SavePath, FileMode.Create))
        {
            PlayerData data = new PlayerData(player);
            formatter.Serialize(stream, data);
        }
    }

    public static PlayerData LoadPlayer()
    {
        if (PlayerDataExists())
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream(SavePath, FileMode.Open))
            {
                PlayerData data = formatter.Deserialize(stream) as PlayerData;
                return data;
            }
        }
        else
        {
            Debug.LogError("Save file not found at " + SavePath);
            return null;
        }
    }

    public static bool PlayerDataExists()
    {
        return File.Exists(SavePath);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void OnApplicationQuit()
    {
        // Save the player data when the application quits
        if (GameManager.Instance != null && GameManager.Instance.Player != null)
        {
            SavePlayer(GameManager.Instance.Player);
        }
    }
}
