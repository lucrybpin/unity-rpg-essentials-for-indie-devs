using UnityEngine;

public class InventoryExample : MonoBehaviour
{
    [SerializeField] Inventory _inventory;
    [SerializeField] Item _axe;
    [SerializeField] Item _brokenAxe;
    [SerializeField] Item _gem;

    void Awake()
    {
        _inventory = new Inventory(4);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            AddAxe();
        }
        else  if(Input.GetKeyDown(KeyCode.Q))
        {
            RemoveAxe();
        }

        else  if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            AddBrokenAxe();
        }
        else  if (Input.GetKeyDown(KeyCode.W))
        {
            RemoveBrokenAxe();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            AddGem();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            RemoveGem();
        }

        else if (Input.GetKeyDown(KeyCode.Z))
        {
            Swap(0, 1);
        }

    }

    public void AddAxe()
    {
        _inventory.AddItem(_axe);
    }

    public void AddBrokenAxe()
    {
        _inventory.AddItem(_brokenAxe);
    }

    public void AddGem()
    {
        _inventory.AddItem(_gem);
    }

    public void RemoveAxe()
    {
        _inventory.RemoveItem(_axe);
    }

    public void RemoveBrokenAxe()
    {
        _inventory.RemoveItem(_brokenAxe);
    }

    public void RemoveGem()
    {
        _inventory.RemoveItem(_gem);
    }

    public void Swap(int index1, int index2)
    {
        _inventory.Swap(index1, index2);
    }

}
