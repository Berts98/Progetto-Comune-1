using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GridSystem;

public class InputController : MonoBehaviour {
    public KeyCode UpButton;
    public KeyCode DownButton;
    public KeyCode LeftButton;
    public KeyCode RightButton;
    public KeyCode PassButton;
    public KeyCode AttackBaseButton;
    public TurnManager turn;

    void Start()
    {
        turn = FindObjectOfType<TurnManager>();
    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown(LeftButton))
        {
            ///left
            SendMessage("GoToLeft");
            
        }

        if (Input.GetKeyDown(RightButton))
        {
            ///right
            SendMessage("GoToRight");
           
        }

        if (Input.GetKeyDown(UpButton))
        {
            ///up
            SendMessage("GoToUp");
           
        }

        if (Input.GetKeyDown(DownButton))
        {
            ///down
            SendMessage("GoToDown");
          
        }

        if (Input.GetKeyDown(PassButton))
        {
            ///passa il turno
            SendMessage("ToPass");
         
        }

        if (Input.GetKeyDown(AttackBaseButton))
        {
            ///attacco base p1
            if (turn.isTurn == true)
            {
                SendMessage("ToAttackBase1");
            }

            ///attaco base p2
            else if (turn.isTurn == false)
            {
                SendMessage("ToAttackBase2");
            }
        }
    }
}
