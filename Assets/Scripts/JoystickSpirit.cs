using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickSpirit : MonoBehaviour
{
    public float speed;
    public VariableJoystick variableJoystick;
    public Rigidbody2D rb;

    private bool isFacingRight = true; 
    private Animator anim;

    public void FixedUpdate()
    {
        anim.SetFloat("Speed", Mathf.Abs(variableJoystick.Horizontal));

        rb.velocity = new Vector2(variableJoystick.Horizontal * speed, variableJoystick.Vertical * speed);

        //если нажали клавишу для перемещения вправо, а персонаж направлен влево
        if (variableJoystick.Horizontal > 0 && !isFacingRight)
            //отражаем персонажа вправо
            Flip();
        //обратная ситуация. отражаем персонажа влево
        else if (variableJoystick.Horizontal < 0 && isFacingRight)
            Flip();
    }

    public Vector3 target_move;
    public Transform Point;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Point.position, Time.deltaTime);
        transform.Translate(target_move * speed * Time.deltaTime);

        var dist = (transform.position - Camera.main.transform.position).z;
        var leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).x;
        var rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).x;
        var topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).y;
        var bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, dist)).y;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, leftBorder, rightBorder),
            Mathf.Clamp(transform.position.y, topBorder, bottomBorder),
            transform.position.z);
    }

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Flip()
    {
        //меняем направление движения персонажа
        isFacingRight = !isFacingRight;
        //получаем размеры персонажа
        Vector3 theScale = transform.localScale;
        //зеркально отражаем персонажа по оси Х
        theScale.x *= -1;
        //задаем новый размер персонажа, равный старому, но зеркально отраженный
        transform.localScale = theScale;
    }

    //private BoxCollider2D boxCollider;
    //void Start()
    //{
    //    boxCollider = gameObject.GetComponent<BoxCollider2D>();
    //    boxCollider.isTrigger = true;
    //}
}
