using UnityEngine;

public class InventoryExample : MonoBehaviour
{
    [SerializeField] Inventory _inventory;
    [SerializeField] Item _axe;

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
    }

    public void AddAxe()
    {
        _inventory.AddItem(_axe);
    }
}
