namespace Class13
{
    // Sealed at the class level prevents use from heriting from it in other classes.
    public sealed class SeniorManager : Manager
    {
        // I cannot override Pay here because it is 'sealed' in Manager
        // SeniorManager still inherids the Pay method from the Manager class but,
        // I am just prevented from overriding it further.
    }
}
