using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    [SerializeField] AudioSource musicAudio,audioSource;

    public AudioClip RatSqueakSound;
    public AudioClip TurningPagesSound;
    public AudioClip HelikopterSound;
    public AudioClip SnowSound;
    public AudioClip TreasureSound;
    public AudioClip CoziesSound;
    public AudioClip RoboSound;


    public enum Sound
    {
        RatSqueak,
        TurningPages,
        Helikopter,
        Snow,
        Treasure,
        Cozies,
    }
   
    public  void RatSqueak()
    {
        
        audioSource.PlayOneShot(RatSqueakSound);
    }
    public void TurningPages()
    {

        audioSource.PlayOneShot(TurningPagesSound);
    }
    public void Helikopter()
    {

        audioSource.PlayOneShot(HelikopterSound);
    }
    public void Snow()
    {

        
        audioSource.PlayOneShot(SnowSound);
    }
    public void Treasure()
    {

        audioSource.PlayOneShot(TreasureSound);
    }
    public void Cozies()
    {

       
        audioSource.PlayOneShot(CoziesSound);
    }
    public void Robo()
    {

        audioSource.PlayOneShot(RoboSound);
    }
}
