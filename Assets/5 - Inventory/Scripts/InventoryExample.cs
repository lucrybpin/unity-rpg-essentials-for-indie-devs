using UnityEngine;

public class InventoryExample : MonoBehaviour
{
    [SerializeField] Inventory _inventory;
    [SerializeField] InventoryView _view;
    [SerializeField] Item _axe;
    [SerializeField] Item _brokenAxe;
    [SerializeField] Item _gem;

    void Awake()
    {
        _inventory = new Inventory(4);
        _view.OnItemSwap += Swap;
        _view.Render(_inventory);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            AddAxe();
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            RemoveAxe();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            AddBrokenAxe();
        }
        else if (Input.GetKeyDown(KeyCode.W))
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
        _view.Render(_inventory);
    }

    public void AddBrokenAxe()
    {
        _inventory.AddItem(_brokenAxe);
        _view.Render(_inventory);
    }

    public void AddGem()
    {
        _inventory.AddItem(_gem);
        _view.Render(_inventory);
    }

    public void RemoveAxe()
    {
        _inventory.RemoveItem(_axe);
        _view.Render(_inventory);
    }

    public void RemoveBrokenAxe()
    {
        _inventory.RemoveItem(_brokenAxe);
        _view.Render(_inventory);
    }

    public void RemoveGem()
    {
        _inventory.RemoveItem(_gem);
        _view.Render(_inventory);
    }

    public void Swap(int index1, int index2)
    {
        _inventory.Swap(index1, index2);
        _view.Render(_inventory);
    }

}
