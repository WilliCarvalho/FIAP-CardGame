using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBase : LifeBase
{
    public int totalManaRequest;
    public string cardName;
    public string cardDescription;
    public Texture cardImg;


    public TextMesh textLife;
    public TextMesh textMana;
    public TextMesh nameCardText;
    public TextMesh descriptionCardText;
    public Renderer renderImgCard;
    
    // Start is called before the first frame update
    protected void Start()
    {
        base.Start();

        textLife.text = currentlife.ToString();
        textMana.text = totalManaRequest.ToString();
        nameCardText.text = cardName;
        descriptionCardText.text = cardDescription;
        renderImgCard.material.mainTexture = cardImg;
        
    }

    // Update is called once per frame
    protected void Update()
    {
        base.Update();
    }

    public override void OnDamage()
    {
        
    }

    public override void OnDie()
    {
        

    }
}
