using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LifeBase : MonoBehaviour
{

    public int totalLife;

    private int currentlife;
    
    // Start is called before the first frame update
    protected void Start()
    {
        currentlife = totalLife;
    }

    // Update is called once per frame
    protected void Update()
    {
        
    }

    public void ApplyDamage(int damage)
    {
        currentlife -= damage;
        OnDamage();

        if(currentlife <= 0)
        {
            OnDie();
        }
    }

    public abstract void OnDamage();
    public abstract void OnDie();
}
