using UnityEngine;
using UnityEngine.UI;


public class DyeByWater : MonoBehaviour
{

    [SerializeField] private float Timer = 10f;
    public Image[] spritesOfImage;
    public Sprite spriteOffAir;
    public Sprite spriteOnAir;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Water"))
        {
            Times();
            if (Timer <= 8f && Timer > 6f)
            {
                spritesOfImage[0].sprite = spriteOffAir;
            }
            else if (Timer <= 6f && Timer > 4f)
            {
                spritesOfImage[1].sprite = spriteOffAir;
            }
            else if (Timer <= 4f && Timer > 2f)
            {
                spritesOfImage[2].sprite = spriteOffAir;
            }
            else if (Timer <= 2f && Timer > 0.1f)
            {
                spritesOfImage[3].sprite = spriteOffAir;
            }
            else if (Timer <= 0.1f)
            {
                spritesOfImage[4].sprite = spriteOffAir;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Water"))
        {
            Timer = 10f;
            for (int i = 0; i < spritesOfImage.Length; i++)
            {
                spritesOfImage[i].sprite = spriteOnAir;
            }
        }
    }
    private void Times()
    {
        if (Timer <= 0.1f)
        {
            GameManeger.Instance.Lose();
        }
        else
        {
            Timer -= 1 * Time.deltaTime;
        }
    }
}
