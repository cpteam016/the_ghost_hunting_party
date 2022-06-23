using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    [Header("Attack Target")] [SerializeField]
    private Transform target;

    public Transform homePos;
    [SerializeField] private float speed;
    [SerializeField] private float maxRange;
    [SerializeField] private float minRange;

    [Header("Collider Parameters")]
    [SerializeField] private CircleCollider2D circleCollider;

    [Header("Player Layer")] [SerializeField]
    private LayerMask playerLayer;

    private Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        // target = FindObjectOfType<PlayerAstarMovement>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerInSight())
        {
            if (target != null)
            {
                if (Vector3.Distance(target.position, transform.position) <= maxRange &&
                    Vector3.Distance(target.position, transform.position) >= minRange)
                {
                    {
                        FollowPlayer();
                    }
                }
                // else if (Vector3.Distance(target.position, transform.position) >= maxRange)
                // {
                //     GoHome();
                // }
            }
            else
            {
                GoHome();
            }
        }
    }

    public void FollowPlayer()
    {
        if (PlayerInSight())
            transform.position =
                Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }

    public void GoHome()
    {
        transform.position = Vector3.MoveTowards(transform.position, homePos.position, speed * Time.deltaTime);
        target = null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(
            circleCollider.bounds.center,
            maxRange);
    }

    private bool PlayerInSight()
    {
        RaycastHit2D hit = Physics2D.CircleCast(
            circleCollider.bounds.center + transform.right * maxRange * transform.localScale.x ,
            maxRange,
            Vector2.left,
            0,
            playerLayer
        );

        if (hit.collider != null)
            Debug.Log("Detected! tag: " + hit.collider.tag + "name: " + hit.collider.name);
        // should hit the player
        if (hit.collider.CompareTag("Player"))
            target = hit.transform;

        return hit.collider != null;
    }
}