using UnityEngine;

public class Nest : MonoBehaviour
{
    private GameObject gameControl;
    void Start()
    {
        gameControl = GameObject.Find("GameControl");
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerTouched();
        }
    }

    void playerTouched()
    {
        var gameControlScript = gameControl.GetComponent<GameControl>();
        gameControlScript.nest();
    }
}
