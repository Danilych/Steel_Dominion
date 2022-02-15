using UnityEngine;

[CreateAssetMenu(menuName = "Inventory Item Data")]
public class SO_UnitItemData : ScriptableObject
{
    public int id;
    public string displayName;
    public GameObject prefab;
    public int UnitWeight = 1;
    public Sprite unitSprite;
    //TODO �������� ���������� �� �� � � ���������� �������� ����� �� ������ SO




    // INVENTORY ITEM
    public string GetName()
    {
        return displayName;
    }

    public Sprite GetSprite()
    {
        return unitSprite;
    }

    public int GetWeight()
    {
        return UnitWeight;
    }

    public int GetId()
    {
        return id;
    }

    public GameObject GetPrefab()
    {
        return prefab;
    }
    //////////////////
}
