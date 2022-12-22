using UnityEngine;

public class pickup_repair_hit : MonoBehaviour
{
    public GameObject hitEffect;
    public int shieldAdd = 10;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Captain Starpants")
        {
            player_globals.shield += shieldAdd;
            Destroy(gameObject, .1f);
            GameObject hit1 = Instantiate(hitEffect, collision.transform, false);
        }
    }
}
