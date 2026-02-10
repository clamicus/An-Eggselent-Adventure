using UnityEngine;

public class Level2Sign : MonoBehaviour
{

    private GameObject ObjJumpTutorial;

    void Start()
    {
        ObjJumpTutorial = GameObject.Find("CanvasJumpTutorial");
        ObjJumpTutorial.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerTouched();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            ObjJumpTutorial.SetActive(false);
        }
    }

    void playerTouched()
    {
        ObjJumpTutorial.SetActive(true);
    }
}
