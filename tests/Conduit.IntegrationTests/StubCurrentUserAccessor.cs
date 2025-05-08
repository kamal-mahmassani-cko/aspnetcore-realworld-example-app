public class StubCurrentUserAccessor(string userName) : ICurrentUserAccessor
{
    public string GetCurrentUsername() => userName;
}