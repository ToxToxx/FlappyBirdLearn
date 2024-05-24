using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyGameOverBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.GameOver();
    }
}
