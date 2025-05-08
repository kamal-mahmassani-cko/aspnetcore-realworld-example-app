    [Fact]
    public async Task Expect_Create_User()
    {
        var command = new Create.Command(new Create.UserData("username", "email", "password"));

        await SendAsync(command);

        Assert.NotNull(created);
        Assert.Equal(created.Hash, await new PasswordHasher().Hash("password", created.Salt));
    }
}