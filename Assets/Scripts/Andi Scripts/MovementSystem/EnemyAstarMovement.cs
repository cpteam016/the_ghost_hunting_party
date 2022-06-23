using System.Collections.Generic;
using System.Collections;
using Andi_Scripts;
using Pathfinding;
using UnityEngine;

public class EnemyAstarMovement : MonoBehaviour
{
    [Header("Main Configuration")]
    private Transform destination;
    public Transform playerTransform;
    public Transform playerTransform1;
    public Transform playerTransform2;
    public Transform playerTransform3;
    public Transform garageSpot;
    public Transform gardenSpot;
    public Transform livingroomSpot;
    public Transform hallway1Spot;
    public Transform hallway2Spot;
    public Transform storageSpot;
    public Transform bathroomSpot;
    public Transform masterbedroomSpot;
    public Transform masterbathroomSpot;
    public Transform bedroom1Spot;
    public Transform bedroom2Spot;
    public Transform dinnerSpot;
    public Transform kitchenSpot;
    public Transform randomizedSpot;
    private float randomNumber;

    // private Animator animator;

    // List untuk penanda sedang di klik
    static List<EnemyAstarMovement> moveableObjects = new List<EnemyAstarMovement>();
    private AIDestinationSetter setter;
    private bool selected;
    private Vector3 target;
    IAstarAI ai;
    public GameObject player;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject inventoryStatus;
    private InventoryStatus hidingStatus;
    public PlayerStatus statusPlayer;
    public float distancePlayer;
    public float distancePlayer1;
    public float distancePlayer2;
    public float distancePlayer3;

    private CircleCollider2D trigger;
    private Rigidbody2D rb;

    private bool isFaint = false;

    private void Awake()
    {
        hidingStatus = inventoryStatus.GetComponent<InventoryStatus>();
        ai = GetComponent<IAstarAI>();
        moveableObjects.Add(this);
        setter = GetComponent<AIDestinationSetter>();
        rb = GetComponent<Rigidbody2D>();
        randomNumber = Random.Range(0, 130);
        StartCoroutine(spotsRandomizer());
        // animator = GetComponentInChildren<Animator>();
    }

    private void Update()
    {
            
        if (distancePlayer < 5f) {
        if (hidingStatus.hidingPlayer == false){
        if (statusPlayer.captured == false){
        if (statusPlayer.scared == true){
        destination = playerTransform;
        } else {
        destination = randomizedSpot;
        }
        } else {
        destination = randomizedSpot;    
        }
        } else {
        destination = randomizedSpot;    
        }
        } else if (distancePlayer1 < 5f) {
        if (hidingStatus.hidingPlayer1 == false){
        if (statusPlayer.captured1 == false){
        if (statusPlayer.scared1 == true){
        destination = playerTransform1;
        } else {
        destination = randomizedSpot;
        }
        } else {
        destination = randomizedSpot;    
        }
        } else {
        destination = randomizedSpot;    
        }
        } else if (distancePlayer2 < 5f) {
        if (hidingStatus.hidingPlayer2 == false){
        if (statusPlayer.captured2 == false){
        if (statusPlayer.scared2 == true){
        destination = playerTransform2;
        } else {
        destination = randomizedSpot;
        }
        } else {
        destination = randomizedSpot;    
        }
        } else {
        destination = randomizedSpot;    
        }
        } else if (distancePlayer3 < 5f) {
        if (hidingStatus.hidingPlayer3 == false){
        if (statusPlayer.captured3 == false){
        if (statusPlayer.scared3 == true){
        destination = playerTransform3;
        } else {
        destination = randomizedSpot;
        }
        } else {
        destination = randomizedSpot;    
        }
        } else {
        destination = randomizedSpot;    
        }
        } else {
        destination = randomizedSpot;       
        }

        
        if (randomNumber < 10) {
        randomizedSpot = garageSpot;    
        } else if (randomNumber > 10 && randomNumber < 20){
        randomizedSpot = gardenSpot;    
        } else if (randomNumber > 20 && randomNumber < 30){
        randomizedSpot = storageSpot;    
        } else if (randomNumber > 30 && randomNumber < 40){
        randomizedSpot = livingroomSpot;    
        } else if (randomNumber > 40 && randomNumber < 50){
        randomizedSpot = hallway1Spot;    
        } else if (randomNumber > 50 && randomNumber < 60){
        randomizedSpot = hallway2Spot;    
        } else if (randomNumber > 60 && randomNumber < 70){
        randomizedSpot = kitchenSpot;    
        } else if (randomNumber > 70 && randomNumber < 80){
        randomizedSpot = masterbedroomSpot;    
        } else if (randomNumber > 80 && randomNumber < 90){
        randomizedSpot = masterbathroomSpot;    
        } else if (randomNumber > 90 && randomNumber < 100){
        randomizedSpot = bedroom1Spot;    
        } else if (randomNumber > 100 && randomNumber < 110){
        randomizedSpot = bedroom2Spot;    
        } else if (randomNumber > 110 && randomNumber < 120){
        randomizedSpot = bathroomSpot;    
        } else if (randomNumber > 120 && randomNumber < 130){
        randomizedSpot = dinnerSpot;    
        }

        distancePlayer = Vector2.Distance(player.transform.position, gameObject.transform.position);
        distancePlayer1 = Vector2.Distance(player1.transform.position, gameObject.transform.position);
        distancePlayer2 = Vector2.Distance(player2.transform.position, gameObject.transform.position);
        distancePlayer3 = Vector2.Distance(player3.transform.position, gameObject.transform.position);

        // animator.SetBool("IsWalk", isWalk);

        setter.target = destination;

        if (ai.isStopped && transform.position == destination.position)
        {
            setter.target = null;
        }
    }

    public IEnumerator spotsRandomizer() {
    while (true){    
    yield return new WaitForSeconds (5f);
    randomNumber = Random.Range(0, 130);
    }
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

}