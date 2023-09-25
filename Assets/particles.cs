using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HorseBrushing : MonoBehaviour
{
    public ParticleSystem dirtParticles; // Assign your Particle System in the Inspector.
    public Transform brushTransform; // Assign the GameObject representing the brush.

    private bool isBrushing = false;

    private void Update()
    {
        // Check if the brush is in contact with the horse.
        if (IsTouchingHorse())
        {
            // If not already brushing, start emitting dirt particles.
            if (!isBrushing)
            {
                dirtParticles.Play();
                isBrushing = true;
            }
        }
        else
        {
            // If not touching the horse, stop emitting dirt particles.
            if (isBrushing)
            {
                dirtParticles.Stop();
                isBrushing = false;
            }
        }
    }

    private bool IsTouchingHorse()
    {
        // Perform raycasting to detect if the brush is touching the horse.
        RaycastHit hit;
        if (Physics.Raycast(brushTransform.position, brushTransform.forward, out hit))
        {
            // Check if the hit object is the horse or has a tag to identify it as the horse.
            if (hit.collider.CompareTag("Horse"))
            {
                return true;
            }
        }
        return false;
    }
}
