using CodeMonkey.MonoBehaviours;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameManager Instance;

    [Header("GameSettings")] public bool isFirst = false;
    public CameraFollow cameraFollow;
    public Transform playerTransform;

    public float zoomScale = 200f;
    // public Transform playerTransform; // 2nd player
    // public Transform playerTransform; // 3rd player
    // public Transform playerTransform; // 4th player
    // public Transform playerTransform; // 5th player

    // public GameState State;
    // public static event Action<GameState> OnGameStateChanged; 

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        Time.timeScale = 1;

        cameraFollow.Setup(() => playerTransform.position, () => 200f, true, true);

        // Temporary set game state.
        // UpdateGameState(GameState.SelectColor);
    }

    private void ZoomIn()
    {
        zoomScale -= 40f;
        if (zoomScale < 40f) zoomScale = 40f;
    }

    private void ZoomOut()
    {
        zoomScale += 40f;
        if (zoomScale > 200f) zoomScale = 200f;
    }

    // private void UpdateGameState(GameState newState)
    // {
    //     State = newState;
    //
    //     switch (newState)
    //     {
    //         case GameState.SelectColor:
    //             break;
    //         case GameState.PlayerTurn:
    //             break;
    //         case GameState.EnemyTurn:
    //             break;
    //         case GameState.Victory:
    //             break;
    //         case GameState.Lose:
    //             break;
    //         default:
    //             throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
    //     }
    //     
    //     OnGameStateChanged?.Invoke(newState);
    // }
}

// Unknown gamestate
// public enum GameState
// {
//     SelectColor,
//     PlayerTurn,
//     EnemyTurn,
//     Victory,
//     Lose
// }