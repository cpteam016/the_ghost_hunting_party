using Pathfinding;
using UnityEngine;

[RequireComponent(typeof(AIDestinationSetter))]
[RequireComponent(typeof(AIPath))]
public class UnitRTS : MonoBehaviour
{
    private GameObject selectedGameObject;
    private AIDestinationSetter target;
    private IAstarAI ai;

    [Header("Following Settings")] 
    public GameObject destination;
    // public Transform destination;
    // public GameObject playerShadow;

    private void Awake()
    {
        selectedGameObject = transform.Find("Selected").gameObject;
        target = GetComponent<AIDestinationSetter>();
        SetSelectedVisible(false);
    }

    public void SetSelectedVisible(bool visible)
    {
        selectedGameObject.SetActive(visible);
    }

    public void MoveTo(Vector3 targetPosition)
    {
        // set move position
        destination.transform.position = targetPosition;
        destination.GetComponent<ShadowFollower>().SetActive(true);
        target.target = destination.transform;
    }
}