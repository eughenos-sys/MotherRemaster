using UnityEngine;
public enum HardwareType { CPU, FlashRAM, NetworkInterface }
[CreateAssetMenu(fileName = "HardwareConfiguration", menuName = "Mother/Hardware", order = 1)]
public class HardwareConfiguration:ScriptableObject
{
    public int Id;
    public string Name;
    public string Description;
    public HardwareType HardwareType;
    public int Type;
    public int Performance;
    //TODO: Overclock
}