using UnityEngine;

public class RegularBubble : Bubble
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            speed = 0f;
            Pop();
        }
    }
}
