namespace Day3.Enums;

[Flags]
public enum BorderSides
{
    None = 0,
    Left = 1,
    Right = 1 << 1,
    Top = 1 << 2,
    Bottom = 1 << 3
}
