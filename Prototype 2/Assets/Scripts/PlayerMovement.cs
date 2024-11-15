using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private readonly float speed = 20f;

    [SerializeField] private readonly float limitX = 15f;

    [SerializeField] private GameObject projectilePrefab;

        void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        
        transform.Translate(inputX * speed * Vector3.right * Time.deltaTime);

        if (transform.position.x >= limitX)
            transform.position = Vector3.right * limitX;

        if (transform.position.x <= -limitX)
            transform.position = Vector3.right * -limitX;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
