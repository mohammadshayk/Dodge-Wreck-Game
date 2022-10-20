using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public Manager gameManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
