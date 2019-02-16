using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GridSystem;

public class PositionTester : MonoBehaviour {
    public int x;
    public int y;
    public BaseGrid grid;
    public TurnManager turn;
    public int maxRangeHzPlayer1;
    public int maxRangeVtPlayer1;

    public void Start()
    {
        turn = FindObjectOfType<TurnManager>();
        transform.position = grid.GetWorldPosition(x, y);       
        turn.isTurn = true;
        
    }

	public void GoToLeft()
    {
        if (x > 0 && turn.isTurn == true)                           // controllo se non sono a bordo mappa + se è il mio turno 
        {
            x--;
            transform.position = grid.GetWorldPosition(x, y);       // movimento player sinstra
            turn.isTurn = false;                                    // fine turno
            turn.ContRound += 1;                                    // incremento round (optional)
            maxRangeHzPlayer1 = x;                                  // setto range orizzontale player 1
            
        }
    }

    public void GoToRight()
    {
        if (x < 9 && turn.isTurn == true)
        {
            x++;
            transform.position = grid.GetWorldPosition(x, y);
            turn.isTurn = false;
            turn.ContRound += 1;
            maxRangeHzPlayer1 = x;
           
        }
    }

    public void GoToDown()
    {
        if (y > 0 && turn.isTurn == true)
        {
            y--;
            transform.position = grid.GetWorldPosition(x, y);
            turn.isTurn = false;
            turn.ContRound += 1;
            maxRangeVtPlayer1 = y;                                 //setto range verticale player 1
        }
    }

    public void GoToUp()
    {
        if (y < 9 && turn.isTurn == true)
        {
            y++;
            transform.position = grid.GetWorldPosition(x, y);
            turn.isTurn = false;
            turn.ContRound += 1;
            maxRangeVtPlayer1 = y;
        }
    }

    public void ToPass()
    {

        turn.isTurn = false;                                       //salto turno

    }

}
