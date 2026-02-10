
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{

    public int Eggs;
    public int minimumEggs;

    public Text scoreEggs;
    public Text GameOverText;

    private GameObject ObjGameOverUI;
  

    public bool alive;


    void Start()
    {
        ObjGameOverUI = GameObject.Find("CanvasGameOver");
        ObjGameOverUI.SetActive(false);
        alive = true;
        //Set Cursor to not be visible
        Cursor.visible = false;
    }


    void Update()
    {
        scoreEggs.text = "Eggs collected: " + Eggs.ToString();
    }

    public void death()
    {
        alive = false;
        gameOver();
    }

    public void nest()
    {
        if (alive == true && Eggs >= minimumEggs)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            Debug.Log("nest touched");
        }
        
    }

    private void gameOver()
    {
        ObjGameOverUI.SetActive(true);

        if (alive == false)
        {
            GameOverText.text = ("Oh NO! you've died");
            //Set Cursor to not be visible
            Cursor.visible = true;
        }

    }

}
