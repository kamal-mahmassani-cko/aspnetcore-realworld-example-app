    /// <returns></returns>
    public static async Task<User> CreateDefaultUser(SliceFixture fixture)
    {
        var command = new Create.Command(new Create.UserData(DefaultUserName, "email", "password"));

        var commandResult = await fixture.SendAsync(command);
        return commandResult.User;
}

