using UnityEngine;

public class PipeIncreaseScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<FlyBehavior>() != null)
        {
            Score.Instance.UpdateScore();
        }
    }
}
