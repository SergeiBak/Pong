using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BouncySurface : MonoBehaviour
{
    [SerializeField]
    private float bounceStrength;

    public EventTrigger.TriggerEvent audioTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            Vector2 normal = collision.GetContact(0).normal; // get vector pointing away from surface collision
            ball.AddForce(-normal * bounceStrength);

            BaseEventData eventData = new BaseEventData(EventSystem.current);
            audioTrigger.Invoke(eventData);
        }
    }
}
