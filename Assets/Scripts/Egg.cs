using UnityEngine;

public class Egg : MonoBehaviour
{
    private GameObject gameControl;
    void Start()
    {
        gameControl = GameObject.Find("GameControl"); 
    }

    // Update is called once per frame
    void Update()
    {
        // rotate model for movement.
        transform.Rotate(0,0,120 *Time.deltaTime);
    }
    //set if touched variable
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerTouched();
        }
    }
    // desroy egg, incease score
    void playerTouched()
    {
        var gameControlScript = gameControl.GetComponent<GameControl>();

        gameControlScript.Eggs = gameControlScript.Eggs + 1;

        Destroy(gameObject);
    }
}
