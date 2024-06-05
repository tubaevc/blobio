namespace Slimes.Enemies
{
    public enum AIState
    {
        Null = 0,
        ChasingBait = 1,  //her coroutine için bir enum
        ChasingEnemy = 2,
        Fleeing = 3,
        Wandering = 4
    }
}