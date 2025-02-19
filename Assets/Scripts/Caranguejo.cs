using UnityEngine;

public class Caranguejo : MonoBehaviour
{
    public float speed;
    public float distance;

    bool flip;

    public Transform groundDetect;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D hit = Physics2D.Raycast(groundDetect.position, Vector2.down, distance);

        Debug.DrawRay(groundDetect.position, Vector2.down, Color.red, distance);

        if (hit.collider == null)
        {
            if (flip)
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                flip = false;

            }
            else
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                flip = true;               
            }
        }

    }
}
