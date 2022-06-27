using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;

    //variabel untuk padel kanan dan kiri sehingga dapat bergerak sendiri2 
    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rig;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        Debug.Log("Kecepatan Paddle: " + speed);

    }

    // Update is called once per frame
    private void Update()
    {

        MoveObject(GetInput());

    }

    private Vector2 GetInput()
    {

        //ambil input
        if (Input.GetKey(upKey))
        {
            //Gerakan keatas
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            //Gerakan kebawah
            return Vector2.down * speed;
        }
        //untuk memberhetikan paddle
        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        //Gerakan object pake input
        /*transform.Translate(movement * Time.deltaTime);*/
        rig.velocity = movement;
    }
}
