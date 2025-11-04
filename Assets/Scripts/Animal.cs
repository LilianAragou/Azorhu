using System;
using UnityEngine;
public abstract class Animal
{
    public int id;
    public bool dead = false;
    public event Action OnDie;

    public Animal(int id)
    {
        id = id;
    }
    public void Die()
    {
        dead = true;
        OnDie?.Invoke();
    }
}
