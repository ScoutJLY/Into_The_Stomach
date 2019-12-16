using System.IO;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    void Start()
    {
        /*
        Debug.Log("Game Handler has started.");

        PlayerData playerData = new PlayerData();
        playerData.position = new Vector3(4, 0, 4);
        playerData.highScore = 511;

        string json = JsonUtility.ToJson(playerData);
        Debug.Log(json);

        File.WriteAllText(Application.dataPath + "/saveFile.json", json);
        */
        
        string json = File.ReadAllText(Application.dataPath + "saveFile.json");
        PlayerData loadedPlayerData = JsonUtility.FromJson<PlayerData>(json);
        Debug.Log("Position: " + loadedPlayerData.position);
        Debug.Log("Highscore: " + loadedPlayerData.highScore);
        
    }   

    private class PlayerData
    {
        public Vector3 position;
        public int highScore;
    }
}
