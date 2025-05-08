
        public string? Image { get; set; }

        public string? Address { get; set; }

    }

    public record Command(UserData User) : IRequest<UserEnvelope>;
            person.Email = message.User.Email ?? person.Email;
            person.Bio = message.User.Bio ?? person.Bio;
            person.Image = message.User.Image ?? person.Image;
            person.Address = message.User.Address ?? person.Address;

            if (!string.IsNullOrWhiteSpace(message.User.Password))
            {