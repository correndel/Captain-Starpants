using UnityEngine;

public class enemy_floater_hit : MonoBehaviour
{
    public int health = 100;
    public GameObject hitEffect_loc;
    public GameObject hitEffect_1;
    public GameObject hitEffect_2;
    public GameObject hpBar;

    private void Start()
    {
        int scaleX = Mathf.FloorToInt(gameObject.transform.localScale.x);
        if (scaleX == 0)
        {
            scaleX = 1;
        }
        health = scaleX * health;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DamageHealth();
            DamagePlayer();
        }
    }

    private void DamageHealth()
    {
        health -= 35;
        ResizeHPBar();

        if (health <= 0)
        {
            Destroy(gameObject, .5f);
            GameObject hit1 = Instantiate(hitEffect_1, hitEffect_loc.transform, false);
            GameObject hit2 = Instantiate(hitEffect_2, hitEffect_loc.transform, false);
            calculate_score.score += 100;
        }
    }

    private void DamagePlayer()
    {
        player_globals.shield -= 10;
    }

    private void ResizeHPBar()
    {
        float hpX = hpBar.transform.localScale.x;
        float hpY = hpBar.transform.localScale.y;
        if (hpX > 0)
        {
            hpX -= (4 * 100 / health);
        }
        else
        {
            hpX = 0;
        }
        Vector3 hpScale = new Vector3(hpX, hpY);
        hpBar.transform.localScale = hpScale;
        hpBar.transform.localPosition = new Vector2(hpBar.transform.localPosition.x + hpX / 4, hpBar.transform.localPosition.y);
    }
}
