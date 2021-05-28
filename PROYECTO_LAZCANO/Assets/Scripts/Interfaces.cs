interface IDamage
{
    bool DoDamage(int vld, bool isPlayer);
} 
interface IBox
{
    int getID();
    int OpenBox();
}
public enum BoxID
{
    HEALTH = 0, AMMO = 1
};