using UnityEngine;

public class shootingSquares : MonoBehaviour
{
    public GameObject Square;
    public float speed = 5f;
    public Rigidbody2D rb;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector2(speed, 0f));
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("wall")){
            Destroy(Square);
        }

    }
}
