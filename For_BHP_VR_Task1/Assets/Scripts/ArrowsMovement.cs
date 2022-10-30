using UnityEngine;
public class ArrowsMovement : MonoBehaviour
{
    [Header("Jak szybko ma siê poruszaæ termomert?")]
    [SerializeField] float movementSpeed;

    //Zmienne potrzebne do poruszania obiektu
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
 
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        rb.velocity = new Vector2(horizontalInput * movementSpeed, verticalInput * movementSpeed);
    }

}
