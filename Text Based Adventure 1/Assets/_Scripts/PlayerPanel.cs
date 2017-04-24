using UnityEngine;
using UnityEngine.UI;

public class PlayerPanel : MonoBehaviour {

    public Text text;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        //print("Health: " + Player.playerStat.Health);
        //print("Defence: " + Player.playerStat.Defence);
        //print("Attack: " + Player.playerStat.Attack);

        text.text = 
            "Name: " + Player.playerStat.PlayerName +
            "\nHealth: " + Player.playerStat.Health +
            "\nAttack: " + Player.playerStat.Attack +
            "\nDefence: " + Player.playerStat.Defence;
    }
}
