using Andi_Scripts;
using UnityEngine;

public class PlayerAstarMovement : MonoBehaviour
{
    [Header("Main Configuration")] public bool isChased;
    public Camera cam;
    public Transform destination;
    public GameObject body;

    private bool isFaint = false;
    
    private void Update()
    {
        if (CanMoveOrInteract() == false) return;
    }

    bool CanMoveOrInteract()
    {
        // ReSharper disable once ReplaceWithSingleAssignment.True
        var can = true;

        if (FindObjectOfType<InteractionSystem>().isExamining)
            can = false;
        if (FindObjectOfType<InventorySystem>().isOpen)
            can = false;
        if (isFaint) can = false;

        return can;
    }

    private void OnDrawGizmosSelected()
    {
        // Gizmos check
        Gizmos.color = Color.yellow;
    }

    public void Chased()
    {
        isChased = true;
        // Set level to reset
        // FindObjectOfType<LevelManager>().Restart():
    }


    public void ResetPlayer()
    {
        isFaint = false;
        isChased = false;
    }
}