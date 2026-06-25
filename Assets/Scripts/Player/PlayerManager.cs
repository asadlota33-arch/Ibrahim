using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private string playerName = "Player";
    [SerializeField] private CarController carController;
    
    private bool isLocalPlayer = true;
    private int playerId;

    private void Start()
    {
        if (carController == null)
            carController = GetComponent<CarController>();
    }

    public void SetPlayerInfo(string name, int id, bool isLocal)
    {
        playerName = name;
        playerId = id;
        isLocalPlayer = isLocal;
    }

    public string GetPlayerName()
    {
        return playerName;
    }

    public int GetPlayerId()
    {
        return playerId;
    }

    public bool IsLocalPlayer()
    {
        return isLocalPlayer;
    }

    public CarController GetCarController()
    {
        return carController;
    }
}
