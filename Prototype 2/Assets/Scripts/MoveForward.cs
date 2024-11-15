using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private readonly float speed = 20f;

    private float LimitZ = 30f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Vector3.forward * Time.deltaTime);

        if(Mathf.Abs(transform.position.z) >= LimitZ)
        {
            Destroy(gameObject);
        }
        else if(Mathf.Abs(transform.position.z) <= -LimitZ)
        {
            Destroy(gameObject);
        }

        if(transform.position.z < -LimitZ)
        {
            Debug.Log("I just lost the game.");
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);
        Destroy(gameObject);
    }
}
