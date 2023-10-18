using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VikingCharacterController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed;
    public float jumpForce;
    private bool isJumping;
    private float moveHorizontal;
    private float moveVertical;
    public Vector3 yon;
    public Animator anim;
    private bool d�nme;


    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();



    }


    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(moveHorizontal, 0, 0) * Time.deltaTime * moveSpeed;
        anim.SetFloat("speed", Mathf.Abs(moveHorizontal));

        if (moveHorizontal > 0 && !d�nme || moveHorizontal < 0 && d�nme)
        {
            D�n();
        }



        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            anim.SetTrigger("ziplama");
        }
        if (transform.position.y < -5)
        {
            SceneManager.LoadScene(4);
        }
    }

    void D�n()
    {
        d�nme = !d�nme;
        transform.rotation = Quaternion.Euler(0, d�nme ? 0 : 180, 0);


    }
}
