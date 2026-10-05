namespace Day3.Inheritance;

public abstract class KeywordBase
{
    protected string _name = "base";
    public virtual string Label => _name;
    public abstract string Tag { get; }
}

public class KeywordChild : KeywordBase
{
    public override string Tag => "child";
    public sealed override string Label => base.Label + "+child";

    public string Reveal()
    {
        return _name;
    }
}

public class KeywordHider : KeywordBase
{
    public override string Tag => "hider";
    public new string Label => "hidden";
}

public sealed class KeywordFinal;

public class ChildKeywordFinal : KeywordChild
{
    public override string Tag => "test";

    // public override string Label => base.Label + "+child";
    public new string Label => base.Label + "+child";
}

public abstract class A
{
    public abstract void Test();
}

public class B : A
{
    public sealed override void Test()
    {
        throw new NotImplementedException();
    }
}

public class C : B
{
}