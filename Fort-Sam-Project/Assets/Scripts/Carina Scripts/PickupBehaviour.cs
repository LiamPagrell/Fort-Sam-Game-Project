using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBehaviour : MonoBehaviour
{
    //[SerializeField] List<GameObject> pickItems = new List<GameObject>();
    public GameObject roboteyes;
    public GameObject cat;
    public GameObject rat;
    //public GameObject bed;
    public GameObject remote;
    public GameObject checkmark;
    public GameObject key;
    public GameObject toyFish;
    public GameObject cheese;
    //[SerializeField] AudioSource clickSound;
    //public GameObject cat;
    Movement player;
    public SoundManager soundManager;
    private static Inventory inventory;
    private static UI_Inventory uiInventory;

    float checkDistance;
    public float pickUpDistance = 4f;

    public bool GotCheese; 

    void Start()
    {
        player = FindObjectOfType<Movement>();
        GotCheese = false;

        if (inventory == null)
        {
            inventory = new Inventory();
        }

        if (uiInventory == null)
        {
            uiInventory = FindObjectOfType<UI_Inventory>();
            uiInventory.SetInventory(inventory);
        }
    }

    public static void ResetInventory()
    {
        inventory = null;
        uiInventory = null;
    }

    private void OnMouseDown()
    {
        checkDistance = Vector2.Distance(this.transform.position, player.transform.position);

        if (Input.GetMouseButtonDown(0) && checkDistance < pickUpDistance && CompareTag("Interactable"))
        {
            ItemWorld itemWorld = GetComponent<ItemWorld>();
            if (Input.GetMouseButtonDown(0))
            {
                ClickOnThings(itemWorld.itemType);
                //Debug.Log(this.gameObject.name + " clicked");
                if (itemWorld != null)
                {
                    //touching item
                    inventory.AddItem(itemWorld.GetItem());
                    uiInventory.RefreshInventoryItems();
                    itemWorld.DestroySelf();
                }
            }
        }

        //else if (Input.GetMouseButtonDown(0) && checkDistance < pickUpDistance && CompareTag("Pillow") && !isInteractable)
        //{
        //    isInteractable = true;
        //    Debug.Log("Mouse click!");
        //    Destroy(gameObject);
        //}
    }

    private void ClickOnThings(ItemType itemType)
    {
        //SoundManager.Instance.PlayRatAudio(clickSound);

        switch (itemType)
        {
            //case ItemType.Ball: Ball(); break;
            case ItemType.Remote:Remote(); break;
            //case ItemType.Skruvmejsel: Skruvmejsel(); break;
           // case ItemType.BedCoverAndPillow: BedCoverAndPillow(); break;
            case ItemType.Book: Book(); break;
            case ItemType.Cheese: Cheese(); break;
            case ItemType.ToyFish: ToyFish(); break;
            default:
                break;

                //case ItemType.Remote: return ItemAssets.Instance.remote;
                //case ItemType.Ball: return ItemAssets.Instance.ball;
                //case ItemType.BedCoverAndPillow: return ItemAssets.Instance.bedcoverandpillow;
                //case ItemType.Book: return ItemAssets.Instance.book;
        }
    }

    //private void Ball()
    //{
       
    //    player.gameObject.GetComponent<Animator>().SetTrigger("PickingUpLow");
    //}
    private void Remote()
    {    
        remote.gameObject.GetComponent<Animator>().SetTrigger("Remote");
        //player.gameObject.GetComponent<Animator>().SetTrigger("PickingUpMedium");
        GameObject.Find("BackAnims").GetComponent<Animator>().SetTrigger("itemGot");
        //cat.gameObject.GetComponent<Animator>().SetTrigger("CatActive");
    }
    //private void Skruvmejsel()
    //{

    //    player.gameObject.GetComponent<Animator>().SetTrigger("PickingUpMedium");
    //}
    public void BedCoverAndPillow()
    {
        //bed.gameObject.GetComponent<Animator>().SetTrigger("Sheet");
        player.gameObject.GetComponent<Animator>().SetTrigger("PickingUpMedium");
        cat.gameObject.GetComponent<Animator>().SetTrigger("CatActive");
        rat.gameObject.GetComponent<Animator>().SetTrigger("RatRun");
        soundManager.Cozies();
        soundManager.Purr();
        checkmark.SetActive(true);    
        //roboteyes.gameObject.GetComponent<Animator>().SetTrigger("CatJump");
        //cat.gameObject.GetComponent<Animator>().SetTrigger("CatAnim");
        //rat.gameObject.GetComponent<Animator>().SetTrigger("RatAnim");
        //StartCoroutine(Wait());
    }

    private void ToyFish()
    {
        player.gameObject.GetComponent<Animator>().SetTrigger("PickingUpMedium");
    }

    private void Book()
    {
        player.gameObject.GetComponent<Animator>().SetTrigger("PickingUpLow");
    }

    private void Cheese()
    {
        GotCheese = true;
        player.gameObject.GetComponent<Animator>().SetTrigger("PickingUpMedium");
        player.gameObject.GetComponent<Movement>().StopMovement();
        player.gameObject.GetComponent<Movement>().enabled = false;
        Invoke(nameof(Wait), 0.5f);
    }
    public void Wait()
    {
        player.gameObject.GetComponent<Movement>().enabled = true;
        player.StartMovement();
    }
}
