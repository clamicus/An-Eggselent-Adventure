using UnityEngine;

public class Lava : MonoBehaviour
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
            var gameControlScript = gameControl.GetComponent<GameControl>();
            gameControlScript.death();
            Destroy(other.gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }

}
