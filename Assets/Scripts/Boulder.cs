using UnityEngine;

public class Boulder : MonoBehaviour
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
       
    }

}
