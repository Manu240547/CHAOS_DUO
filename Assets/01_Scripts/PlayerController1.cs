using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float moveSpeed = 4f; // Velocidad de movimiento de Ecko
    public float jumpForce = 7f; // Fuerza de salto
    public Rigidbody2D rb; // Referencia al Rigidbody2D para aplicar físicas
    public Animator animator; // Referencia al Animator para controlar las animaciones
    public bool canJump = true; // Controla si puede saltar 
    float xInitial, yInitial;

    private void Start()
    {
<<<<<<< HEAD
        xInitial = transform.position.x;
        yInitial = transform.position.y;
=======
        animator.SetBool("Grounded", true);
>>>>>>> 453a41a (ANIMACION E IMPLEMENTACION LAS MISMAS)
    }

    void Update()
    {
        Movement();
        Mirror();
        Jump();
<<<<<<< HEAD
=======
        Action();
        animator.SetFloat("FallingSpeed", rb.velocity.y);
        
>>>>>>> 453a41a (ANIMACION E IMPLEMENTACION LAS MISMAS)
    }
    void Movement()
    {
        float x = Input.GetAxis("Horizontal1");
        rb.velocity = new Vector2(x * moveSpeed, rb.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(x));

    }
    void Mirror()
    {
        if (rb.velocity.x < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        } else if (rb.velocity.x > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
    void Jump()
    {
        if (canJump)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                canJump = false;
<<<<<<< HEAD
            }
        }
    }
=======
                animator.SetBool("Grounded", false);
            }
        }
    }

    void Action()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("Action");
        }    
    }
>>>>>>> 453a41a (ANIMACION E IMPLEMENTACION LAS MISMAS)
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            canJump = true;
<<<<<<< HEAD
=======
            animator.SetBool("Grounded", true);
>>>>>>> 453a41a (ANIMACION E IMPLEMENTACION LAS MISMAS)
        }
    }

    public void Resurect()
    {
        transform.position = new Vector3(xInitial, yInitial, 0);
    }
}

