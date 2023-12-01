using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMovement : MonoBehaviour
{
    public Camera cam;
<<<<<<< HEAD

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

=======

    private void Update()
    {
        // Get the mouse position in world coordinates
        Vector3 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);

        // Calculate the direction from the weapon to the mouse
        Vector3 direction = mousePosition - transform.position;

        // Calculate the angle in degrees
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // Rotate the weapon relative to the player's rotation
        transform.rotation = Quaternion.Euler(0, 0, angle-90f);
>>>>>>> enemies
    }
}
