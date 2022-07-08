using UnityEngine;

enum DayOfWeek 
{
    Monday,
    Tuesday,
    Wednesday,
}

enum Direction
{
    North,
    South,
    West,
    East,
}

public class EnumPractice : MonoBehaviour
{
    [SerializeField] DayOfWeek day;
    [SerializeField] Direction direction;

    [SerializeField] Vector2 directionVec;

    void OnValidate()
    {
        directionVec = DirectionToVector(direction);
    }

    Vector2 DirectionToVector(Direction direction)
    {
        if (direction == Direction.East)
            return new Vector2(1,0);

        if (direction == Direction.West)
            return new Vector2(-1, 0);

        if (direction == Direction.North)
            return new Vector2(0, 1);

        if (direction == Direction.South)
            return new Vector2(0, -1);

        return Vector2.zero;
    }
}