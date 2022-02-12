using UnityEngine;

[CreateAssetMenu(menuName = "Inventory Item Data")]
public class SO_UnitItemData : ScriptableObject
{
    public int id;
    public string displayName;
    public GameObject prefab;
    public int UnitWeight = 1;
    //TODO �������� ���������� �� �� � � ���������� �������� ����� �� ������ SO
}
