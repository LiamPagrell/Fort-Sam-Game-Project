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
    public AudioClip LampSound;
    public AudioClip GlobeSound;
    public AudioClip PurrSound;
    public AudioClip MeowSound;
    public AudioClip PipSound;
    public AudioClip StrumSound;
    public AudioClip TvNewsSound;
    public AudioClip KettleSound;
    public AudioClip ToastedSound;
    public AudioClip DoorOpeningSound;
    public AudioClip WaterSplashSound;
    public AudioClip CelebrationSound;
    public AudioClip samYawnSound;
    public AudioClip catPetSound;


    public enum Sound
    {
        RatSqueak,
        TurningPages,
        Helikopter,
        Snow,
        Treasure,
        Cozies,
        Lamp,
        Globe,
        Purr,
        Meow,
        Pip,
        Strum,
        TvNews,
        Kettle,
        Toasted,
        DoorOpening,
        WaterSplash,
        Celebration,
        Yawn,
        CatPet,
    }
   
    public void RatSqueak()
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
    public void Lamp()
    {

        audioSource.PlayOneShot(LampSound);
    }
    public void Globe()
    {

        audioSource.PlayOneShot(GlobeSound);
    }
    public void Purr()
    {

        audioSource.PlayOneShot(PurrSound);
    }

    public void Meow()
    {

        audioSource.PlayOneShot(MeowSound);
    }
    public void Pip()
    {

        audioSource.PlayOneShot(PipSound);
    }
    public void Strum()
    {

        audioSource.PlayOneShot(StrumSound);
    }
    public void TvNews()
    {

        audioSource.PlayOneShot(TvNewsSound);
    }
    public void Kettle()
    {

        audioSource.PlayOneShot(KettleSound);
    }
    public void Toasted()
    {

        audioSource.PlayOneShot(ToastedSound);
    }

    public void WaterSplash()
    {
        audioSource.PlayOneShot(WaterSplashSound);
    }

    public void DoorOpening()
    {
        audioSource.PlayOneShot(DoorOpeningSound);
    }

    public void Celebration()
    {

        audioSource.PlayOneShot(CelebrationSound);
    }

    public void Yawn()
    {
        audioSource.PlayOneShot(samYawnSound);
    }

    public void CatPetPurr()
    {
        audioSource.PlayOneShot(catPetSound);
    }
}
