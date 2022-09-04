using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float minHeight;
    public float maxHeight;
    public GameObject root;
    // Start is called before the first frame update

    void Start()
    {
        ChangeHeight();

    }
    void update(){
        EnemyDead();
    }

    void ChangeHeight(){
        float height=Random.Range(minHeight,maxHeight);
        root.transform.localPosition=new Vector3(0.0f,height,0.0f);
    }
    void OnScrollEnd(){
        ChangeHeight();
    }
    void EnemyDead(){
        if(isDead){
            GameObject.FindWithTag("enemy");
            Debug.Log("enemy発見");
            this.GetComponent<SpriteRenderer>().color+=new Color(0,0,0,-120);

        }
    }
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Meido")){}
        Debug.Log("衝突");
        isDead=true;

    }
}
