using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GridSystem;

public class AttackBaseUtility : MonoBehaviour {

    public LifeManager lm;
    public TurnManager turn;
    public int att = 3;
    public PositionUtility Utility1;
    public PositionTester2 Tester2;
    public int RangeHz;
    public int RangeVt;
    public bool isAttack;
    public InputController input;
    public KeyCode attackButtonUtility;


    // Use this for initialization
    void Start ()
    {

        Utility1 = FindObjectOfType<PositionUtility>();
        Tester2 = FindObjectOfType<PositionTester2>();
        lm = FindObjectOfType<LifeManager>();
        turn = FindObjectOfType<TurnManager>();
        input = GetComponent<InputController>();
        isAttack = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        SetAttackBase();
        SetDirectionAttackBase();
    }

    public void SetRange()
    {

        RangeHz = Utility1.maxRangeHzUtility1 - Tester2.maxRangeHzPlayer2;
        RangeVt = Utility1.maxRangeVtUtility1 - Tester2.maxRangeVtPlayer2;
                                                                                                            // da fare calcolo obliquo
    }


    public void SetAttackBase()
    {
        if (Input.GetKeyDown(attackButtonUtility) && turn.isTurn == true && isAttack == false)
        {
            isAttack = true;
            input.enabled = !input.enabled;


        }
        else if (Input.GetKeyDown(attackButtonUtility) && turn.isTurn == true && isAttack == true)
        {
            isAttack = false;
            input.enabled = true;
        }
    }

    public void SetDirectionAttackBase()
    {
        SetRange();
        if (Input.GetKeyDown(KeyCode.D) && RangeHz >= -3 && isAttack == true)
        {
            lm.lifePlayer2 -= att;
            isAttack = false;
            turn.isTurn = false;
            input.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.A) && RangeHz <= 3 && isAttack == true)
        {
            lm.lifePlayer2 -= att;
            isAttack = false;
            turn.isTurn = false;
            input.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.W) && RangeVt >= -3 && isAttack == true)
        {
            lm.lifePlayer2 -= att;
            isAttack = false;
            turn.isTurn = false;
            input.enabled = true;
        }

        if (Input.GetKeyDown(KeyCode.S) && RangeVt <= 3 && isAttack == true)
        {
            lm.lifePlayer2 -= att;
            isAttack = false;
            turn.isTurn = false;
            input.enabled = true;
        }
    }
}
