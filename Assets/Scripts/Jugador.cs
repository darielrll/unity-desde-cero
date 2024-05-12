using UnityEngine;

public class Jugador : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 15f;

    private void Start()
    {
        
    }

    private void Awake()
    {
        this.rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        Vector3 movement = new Vector3(moveHorizontal * this.speed,
                                        this.rb.linearVelocity.y,
                                        moveVertical * speed);

        this.rb.linearVelocity = movement;
    }
}
