using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed;
   
    void Start()
    {

    }
 
    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // variaveis locais 
        float v = Input.GetAxis("Vertical");// variaveis locais 

        // Vector2 pos = new Vector2(h, v);

        // transform.position += (Vector3.right * pos.x * 5 + Vector3.up * pos.y * 5) * Time.deltaTime;
        transform.position += (Vector3.right * h * speed + Vector3.up * v * speed) * Time.deltaTime;


    }
}
