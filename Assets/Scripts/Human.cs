using System;
using UnityEngine;
public class Human : Animal
{
    public int health;
    public int maxHealth;

    public int stamina;
    public int maxStamina;

    public int hunger;
    public int maxHunger;

    public int mentalHealth;

    public int maxSpeed;

    //Growth and Stats
    public int growthSTR;
    public int statSTR;
    public int growthEND;
    public int statEND;
    public int growthCON;
    public int statCON;
    public int growthAGI;
    public int statAGI;
    public int growthPER;
    public int statPER;
    public int growthINT;
    public int statINT;
    public int growthWIL;
    public int statWIL;
    public int growthCHA;
    public int statCHA;

    public Trait[] traits;
    public Skill[] skills;
    public Profession profession;
    public Item[] inventory;
    public Item heldItem;

    public Human(int id) : base(id)
    {

    }
}