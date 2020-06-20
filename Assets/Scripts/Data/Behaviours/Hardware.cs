using UnityEngine;
public enum HardwareType { CPU, FlashRAM, NetworkInterface }
public class HardwareConfiguration
{
    public int Id;
    public string Name;
    public string Description;
    public HardwareType HardwareType;
    public int Type;
    public int Performance;
    //TODO: Overclock
}