# Pokemon Review App

This is a web API for reviewing Pokemon, built with ASP.NET 6.

## Models

The API includes several models, including:

- `Pokemon`: Represents a Pokemon.
- `Category`: Represents the category a Pokemon belongs to.
- `Country`: Represents the country a Pokemon is from.
- `Owner`: Represents the owner of a Pokemon.
- `Review`: Represents a review for a Pokemon.
- `Reviewer`: Represents the person who wrote a review.

For detailed descriptions of these models and their properties, please see the [MODELS.md](./PokemonReviewApp/Models/MODELS.md) file.

### PokemonCategory

The `PokemonCategory` model is a join entity that enables the many-to-many relationship between `Pokemon` and `Category`. Each `PokemonCategory` has an associated `PokemonId` and `CategoryId`, which correspond to the `Id` properties of a `Pokemon` and `Category` respectively. The `Pokemon` and `Category` properties are navigation properties that provide direct access to the associated `Pokemon` and `Category`.

### PokemonOwner

The `PokemonOwner` model is a join entity that enables the many-to-many relationship between `Pokemon` and `Owner`. Each `PokemonOwner` has an associated `PokemonId` and `OwnerId`, which correspond to the `Id` properties of a `Pokemon` and `Owner` respectively. The `Pokemon` and `Owner` properties are navigation properties that provide direct access to the associated `Pokemon` and `Owner`.
