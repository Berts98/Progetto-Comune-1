using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GridSystem;

public class AbilityUtility : MonoBehaviour
{

    public int att = 2;
    public PositionUtility Utility1;
    public BaseGrid grid;
    public KeyCode abilityButton;
    public LifeManager lm;
    public TurnManager turn;
    public PositionTester2 Tester2;
    public int x, y;
    public int rangeHz;
    public int rangeVt;
    public bool isAbility;
    public InputController input;

    public int CountStun = 1;
    public PositionTester2 stun;


    // Use this for initialization
    void Start()
    {
        Utility1 = FindObjectOfType<PositionUtility>();
        Tester2 = FindObjectOfType<PositionTester2>();
        lm = FindObjectOfType<LifeManager>();
        turn = FindObjectOfType<TurnManager>();
        isAbility = false;
        input = GetComponent<InputController>();

    }

    // Update is called once per frame
    void Update()
    {
        SetAbility();
        SetDirectionAbility();
    }

    public void SetAbility()
    {

        //abilito abilità
        if (Input.GetKeyDown(abilityButton) && turn.isTurn == true && isAbility == false)
        {

            isAbility = true;
            //disabilito input controller per i movimenti(wasd)
            input.enabled = !input.enabled;

        }
        else if (Input.GetKeyDown(abilityButton) && turn.isTurn == true && isAbility == true)
        {
            isAbility = false;
            //riabilito input controller per i movimenti(wasd)
            input.enabled = true;
        }
    }

    public void SetDirectionAbility()
    {
        SetRange();
        //destra
        if (Input.GetKeyDown(KeyCode.D) && rangeHz >= -3 && isAbility == true)
        {
            lm.lifePlayer2 -= att;                                                          // fare if controllo unità nemica 
            turn.isTurn = false;
            isAbility = false;
            //riabilito input controller per i movimenti(wasd)
            input.enabled = true;

        }
        //sinistra
        if (Input.GetKeyDown(KeyCode.A) && rangeHz <= 3 && isAbility == true)
        {
            lm.lifePlayer2 -= att;
            turn.isTurn = false;
            isAbility = false;
            //riabilito input controller per i movimenti(wasd)
            input.enabled = true;
        }
        //sopra
        if (Input.GetKeyDown(KeyCode.W) && rangeVt >= -3 && isAbility == true)
        {
            lm.lifePlayer2 -= att;
            turn.isTurn = false;
            isAbility = false;
            //riabilito input controller per i movimenti(wasd)
            input.enabled = true;
        }
        //sotto
        if (Input.GetKeyDown(KeyCode.S) && rangeVt <= 3 && isAbility == true)
        {
            lm.lifePlayer2 -= att;
            turn.isTurn = false;
            isAbility = false;
            //riabilito input controller per i movimenti(wasd)
            input.enabled = true;

        }
    }

    public void Stun()
    {
        if ()
        {

        }
    }

    //set up range verticale e orrizontale per portata ability
    public void SetRange()
    {
        rangeHz = Utility1.maxRangeHzUtility1 - Tester2.maxRangeHzPlayer2;
        rangeVt = Utility1.maxRangeVtUtility1 - Tester2.maxRangeVtPlayer2;
    }
}
