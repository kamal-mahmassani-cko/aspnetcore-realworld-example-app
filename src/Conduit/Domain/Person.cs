
    public string? Image { get; set; }

    public string? Address { get; set; }

    [JsonIgnore]
    public List<ArticleFavorite> ArticleFavorites { get; init; } = new();
