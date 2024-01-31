using Unity.Mathematics;

[System.Serializable]
public struct Items
{
    public string Name;
    public int ID;
    public int Quantity;

    public Items(string _name, int _id, int _quantity)
    {
        Name = _name;
        ID = _id;
        Quantity = _quantity;
    }
}
