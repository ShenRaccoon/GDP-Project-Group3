using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeAndStamina : MonoBehaviour
{

    public int life;
    public float stamina;
    public Text lifeText;
    public Text staminaText;
    public bool affectedByTj;

    void Start()
    {
        life = 3;
        stamina = 100f;
        affectedByTj = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (stamina > 100)
        {
            stamina = 100;
        }
        else if (stamina < 0)
        {
            stamina = 0;
        }

        LoseLife();
        RefillStamina();
        TrojanVirus();
        stamina -= 1 * Time.deltaTime;
        lifeText.text = "Life: " + life;
        staminaText.text = "Stamina: " + (int)stamina;
    }

    public void LoseLife()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            life -= 1;
            Debug.Log("You have lost a life!");
        }
    }

    public void TrojanVirus()
    {
        if (Input.GetKeyUp(KeyCode.T))
        {
            affectedByTj = !affectedByTj;
            if (affectedByTj)
            {
                Debug.Log("You have been infected by a trojan");
            }
            else
            {
                Debug.Log("You are not infected by a trojan");
            }
        }
    }

    public void RefillStamina()
    {
        if (Input.GetKeyUp(KeyCode.G))
        {
            stamina += 50f;
            Debug.Log("You have refilled your stamina by 50!");
            if (affectedByTj)
            {
                life -= 1;
                affectedByTj = false;
                Debug.Log("You took damage,and are no longer affected by the trojan");
            }
        }
    }

}
