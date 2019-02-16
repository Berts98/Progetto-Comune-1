using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GridSystem;

public class AttackBase1 : MonoBehaviour {
    public LifeManager lm;
    public TurnManager turn;
    public float att = 50;
    public PositionTester maxP1;
    public PositionTester2 maxP2;
    public int RangeHz;
    public int RangeVt;

    // Use this for initialization
    void Start () {

        maxP1 = FindObjectOfType<PositionTester>();
        maxP2 = FindObjectOfType<PositionTester2>();
        lm = FindObjectOfType<LifeManager>();
        turn = FindObjectOfType<TurnManager>();
       
    }
	

    public void ToAttackBase1()
    {
        RangeHz = maxP1.maxRangeHzPlayer1 - maxP2.maxRangeHzPlayer2;            // calcolo range orizzontale
        RangeVt = maxP1.maxRangeVtPlayer1 - maxP2.maxRangeVtPlayer2;            // calcolo range verticale
        if (RangeHz == 1 || RangeHz == -1 || RangeVt == 1 || RangeVt == -1)     //controllo range attacoo
        {   
            lm.lifePlayer2 -= att;                                              //tolgo vita player
            turn.isTurn = false;
            turn.ContRound += 1;
        }

    }

}
