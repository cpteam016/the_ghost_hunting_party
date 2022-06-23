using UnityEngine;

namespace Andi_Scripts.MovementSystem
{
    public class Player : MonoBehaviour
    {
        [Header("Main Configuration")] [SerializeField]
        private bool isChased;

        [SerializeField] private Camera cam;
        [SerializeField] private Transform destination;
        [SerializeField] private GameObject body;

        private bool isFaint = false;

        private void Awake()
        {
        }
    }
}