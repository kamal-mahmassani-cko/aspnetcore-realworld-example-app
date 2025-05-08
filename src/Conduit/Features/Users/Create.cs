
    public class Handler(
        ConduitContext context,
                IPasswordHasher passwordHasher,
        IJwtTokenGenerator jwtTokenGenerator,
        IMapper mapper
    ) : IRequestHandler<Command, UserEnvelope>
            };

            await context.Persons.AddAsync(person, cancellationToken);
            await context.SaveChangesAsync (cancellationToken);

            var user = mapper.Map<Person, User>(person);
            user.Token = jwtTokenGenerator.CreateToken(