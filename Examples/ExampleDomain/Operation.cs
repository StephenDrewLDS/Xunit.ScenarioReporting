namespace Examples.ExampleDomain
{
    class Operation
    {
        public OperationType Type { get; }

        public Operation(OperationType type)
        {
            Type = type;
        }
    }
}