using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    Animator animator;

    bool isFloor;
    [SerializeField] private float distance;
    Rigidbody2D rb;
    [SerializeField] private float jumpForce;
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private GameObject projetil;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, distance, layerMask);

        isFloor = hit.collider;

        if (hit.collider != null)
        {

        }
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // variaveis locais 
        float y = Input.GetAxis("Vertical");// variaveis locais 

        Vector2 position = new Vector2(x, y);

        // Vector2 pos = new Vector2(x, y);

        // transform.position += (Vector3.right * pos.x * 5 + Vector3.up * pos.y * 5) * Time.deltaTime;
        transform.position += (Vector3.right * position.x + Vector3.up * position.y) * speed * Time.deltaTime;

        animator.SetFloat("mover", position.magnitude);


        Vector3 rotateY = transform.eulerAngles;

        if (position.x < 0)
        {
            rotateY.y = 180f;
        }
        else if (position.x > 0)
        {
            rotateY.y = 0f;
        }

        transform.eulerAngles = rotateY;

        if (Input.GetButtonDown("Jump") && isFloor)
        {
            //  rb.AddForce(Vector3.up * jumpForce);
            rb.AddForce(Vector2.up * jumpForce);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projetil, transform.position, transform.rotation);
        }
    }
}
