using System;
using TMPro;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _colorSelectPanel, _attackButton;
    [SerializeField] private TextMeshProUGUI _stateText;

    private void Awake()
    {
        // GameManager.OnGameStateChanged += GameManagerOnGameChangeStateChanged;
    }

    private void OnDestroy()
    {
        // GameManager.OnGameStateChanged -= GameManagerOnGameChangeStateChanged;
    }

    // private void GameManagerOnGameChangeStateChanged(GameState obj)
    // {
    //     throw new System.NotImplementedException();
    // }

    private void Start()
    {
        throw new NotImplementedException();
    }

    public void AttackPressed()
    {
        
    }
}