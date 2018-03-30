using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameManger gameManager;

    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }

}
