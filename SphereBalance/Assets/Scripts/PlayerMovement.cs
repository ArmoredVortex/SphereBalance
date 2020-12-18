using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    void FixedUpdate(){
        float horizontalMovement = Input.GetAxis("Horizontal");
        float VerticalMovement = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalMovement,0,VerticalMovement);
        rigidbody.AddForce(movement*speed);
        if(rigidbody.position.y < 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

