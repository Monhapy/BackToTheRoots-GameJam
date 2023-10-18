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
    private bool dönme;


    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();



    }


    void Update()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(moveHorizontal, 0, 0) * Time.deltaTime * moveSpeed;
        anim.SetFloat("speed", Mathf.Abs(moveHorizontal));

        if (moveHorizontal > 0 && !dönme || moveHorizontal < 0 && dönme)
        {
            Dön();
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

    void Dön()
    {
        dönme = !dönme;
        transform.rotation = Quaternion.Euler(0, dönme ? 0 : 180, 0);


    }
}
