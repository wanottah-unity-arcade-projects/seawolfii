﻿
using UnityEngine;

//
// Sea Wolf v2021.02.03
//
// 2021.01.24
//

public class Player1TorpedoController1 : MonoBehaviour
{
    public float torpedoSpeed;

    private const int TORPEDO_1 = 0;


    void Update()
    {
        MoveTorpedo();
    }


    private void MoveTorpedo()
    {
        Vector3 direction = (Player1Controller.player1.torpedoTargetPosition[TORPEDO_1] - transform.position).normalized;

        transform.position += direction * torpedoSpeed * Time.deltaTime;

        if (Vector3.Distance(Player1Controller.player1.torpedoTargetPosition[TORPEDO_1], transform.position) <= 0.1f)
        {
            gameObject.SetActive(false);

            Player1Controller.player1.torpedoTarget[TORPEDO_1].gameObject.SetActive(false);
        }
    }


    void OnCollisionEnter2D(Collision2D target)
    {
        if (target.collider.CompareTag("Player 2 Torpedo"))
        {
            gameObject.SetActive(false);
        }

        if (target.collider.CompareTag("Sea Mine"))
        {
            gameObject.SetActive(false);
        }

        if (target.collider.CompareTag("Aircraft Carrier"))
        {
            gameObject.SetActive(false);
        }

        if (target.collider.CompareTag("Battle Ship"))
        {
            gameObject.SetActive(false);
        }

        if (target.collider.CompareTag("Cruiser"))
        {
            gameObject.SetActive(false);
        }

        if (target.collider.CompareTag("Destroyer"))
        {
            gameObject.SetActive(false);
        }

        if (target.collider.CompareTag("Fast Torpedo Boat"))
        {
            gameObject.SetActive(false);
        }

        if (target.collider.CompareTag("Submarine"))
        {
            gameObject.SetActive(false);
        }

        if (target.collider.CompareTag("Frigate"))
        {
            gameObject.SetActive(false);
        }

        Player1Controller.player1.torpedoTarget[TORPEDO_1].gameObject.SetActive(false);
    }


} // end of class
