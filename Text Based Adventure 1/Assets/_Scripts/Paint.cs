using UnityEngine;

public class Paint : MonoBehaviour {

    public int Hurt;
    //Image myButton;

    //void Start()
    //{
    //    Debug.Log("Button should works");
    //    myButton = GetComponent<Image>();
    //}

    public void GetHurt()
    {
        if (Player.playerStat.Health <= 100 && Player.playerStat.Health != 0)
        {
            Debug.Log("Button is clicked");
            Player.playerStat.Health = Player.playerStat.Health - Hurt;
            Debug.Log("You were hurt by: " + Hurt + " damage");
        }if (Player.playerStat.Health <= 0)
        {
            Debug.Log("GAME OVER");
        } 
    }
}
