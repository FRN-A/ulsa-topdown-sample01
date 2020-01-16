using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2D : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 5f;

    void Update()
    {
        transform.Translate(Axis * moveSpeed * Time.deltaTime);
    }

    Vector2 Axis
    {
        get => new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
    }
}
