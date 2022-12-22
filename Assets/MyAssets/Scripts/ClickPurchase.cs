using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPurchase : MonoBehaviour
{
    private Transform other;
    private GameObject GO1;
    public Skiip s;
    public GetListedNFTWebWallet g;
    // Start is called before the first frame update
    void Start()
    {
        s = GameObject.FindWithTag("GO1").GetComponent<Skiip>();
        g = GameObject.FindWithTag("GO1").GetComponent<GetListedNFTWebWallet>();


    }

    // Update is called once per frame
    void Update()
    {    
        if (Input.GetKey(KeyCode.P))
        { 
            g.PurchaseItem();
        }
        else if (Input.GetKey(KeyCode.G)) {

            s.back2Game();
        }
    }
}
