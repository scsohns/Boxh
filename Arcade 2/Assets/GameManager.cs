using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public PlayerScript player;
    public GoalScript goal;

    public Sprite firstPlayer;
    public Sprite secondPlayer;
    public Sprite thirdPlayer;

    private double x;
    private double y;
    private PlayerScript p1;
    private GoalScript g1;
    private double v = .09; //variance
    private bool cleared;
    


    // Use this for initialization
    void Start () {
        p1 = Instantiate(player);
        g1 = Instantiate(goal);
        ChangeSprite();
        x = goal.transform.position.x;
        y = goal.transform.position.y;
        cleared = false;
        
	}
	
	// Update is called once per frame
	void Update () {

        if (!cleared)
        {
            if ((p1.transform.position.x + v >= x) && (p1.transform.position.x - v <= x) && (p1.transform.position.y + v >= y) && (p1.transform.position.y - v <= y))
            {
                Win();
                
                
            }
        }
        
    }

    public void Win()
    {
        p1.Freeze();
        p1.transform.position = g1.transform.position;
        print("win");
        
        
        SceneChanger.SceneChange();
        
        
    }

    private void ChangeSprite()
    {
        string curr = SceneChanger.getScene();
        if (curr == "StageOne")
        {
            p1.SpriteChange(firstPlayer);
        }
        else if (curr == "StageTwo")
        {
            p1.SpriteChange(secondPlayer);

        }
        else if (curr == "StageThree")
        {
            p1.SpriteChange(thirdPlayer);
        }
    }


}
