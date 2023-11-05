using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    
    public Camera cam;

    public float moveSpeed = 10f;

    private Vector2 mousePos;

    private Vector2 movement;

    private GameObject playerObj = null;

    // Update is called once per frame
    void Update()
    {
        playerObj = GameObject.Find("Player");
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        //Debug.Log("Player Position: X = " + playerObj.transform.position.x + " --- Y = " + playerObj.transform.position.y);
        movement.x = playerObj.transform.position.x;
        movement.y = playerObj.transform.position.y;
    }

    private void FixedUpdate()
    {
        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
        rb.MovePosition(movement);

    }
}
