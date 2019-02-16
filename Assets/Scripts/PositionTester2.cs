using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GridSystem;

public class PositionTester2 : MonoBehaviour {

    public int x;
    public int y;
    public BaseGrid grid;
    public TurnManager turn;
    public int maxRangeHzPlayer2;
    public int maxRangeVtPlayer2;

    public void Start()
    {
        turn = FindObjectOfType<TurnManager>();
        transform.position = grid.GetWorldPosition(x, y);
        
    }

 

    public void GoToLeft()
    {
        if (x > 0 && turn.isTurn == false)
        {
            x--;
            transform.position = grid.GetWorldPosition(x, y);
            turn.isTurn = true;
            turn.ContRound += 1;
            maxRangeHzPlayer2 = x;
        }
    }

    public void GoToRight()
    {
        if (x < 9 && turn.isTurn == false)
        {
            x++;
            transform.position = grid.GetWorldPosition(x, y);
            turn.isTurn = true;
            turn.ContRound += 1;
            maxRangeHzPlayer2 = x;
        }
    }

    public void GoToDown()
    {
        if (y > 0 && turn.isTurn == false)
        {
            y--;
            transform.position = grid.GetWorldPosition(x, y);
            turn.isTurn = true;
            turn.ContRound += 1;
            maxRangeVtPlayer2 = y;
        }
    }

    public void GoToUp()
    {
        if (y < 9 && turn.isTurn == false)
        {
            y++;
            transform.position = grid.GetWorldPosition(x, y);
            turn.isTurn = true;
            turn.ContRound += 1;
            maxRangeVtPlayer2 = y;

        }
    }

    public void ToPass()
    {

        turn.isTurn = true;

    }

   
   
}
