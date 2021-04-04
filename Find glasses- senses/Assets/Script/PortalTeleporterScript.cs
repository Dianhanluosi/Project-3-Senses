using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTeleporterScript : MonoBehaviour
{

    public Transform player;
    public Transform receiver;

    private bool playerIsOverLapping = false;

    // Update is called once per frame
    void Update()
    {
        if (playerIsOverLapping)
        {
            Vector3 portaltoPlayer = player.position - transform.position;
            float dotProduct = Vector3.Dot(transform.up, portaltoPlayer);

            if (dotProduct < 0f)
            {
                float rotationDiff = Quaternion.Angle(transform.rotation, receiver.rotation);
                rotationDiff += 180;
                player.Rotate(Vector3.up, rotationDiff);

                Vector3 positionOffset = Quaternion.Euler(0f, rotationDiff, 0f) * portaltoPlayer;
                player.position = receiver.position + positionOffset;

                playerIsOverLapping = false;

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverLapping = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverLapping = false;
        }
    }
}
