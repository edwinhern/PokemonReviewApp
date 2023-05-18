# Models in Pokemon Review App

## Pokemon

Represents a Pokemon. Includes the following properties:

- `Id`: A unique identifier for each Pokemon.
- `Name`: The name of the Pokemon.
- `BirthDate`: The creation date of the Pokemon record in the database. Despite the name, this does not represent the Pokemon's actual birthdate.

## Category

Represents the category a Pokemon belongs to. Includes the following properties:

- `Id`: A unique identifier for each category.
- `Name`: The name of the category.

## Country

Represents the country a Pokemon is from. Includes the following properties:

- `Id`: A unique identifier for each country.
- `Name`: The name of the country.

## Owner

Represents the owner of a Pokemon. Includes the following properties:

- `Id`: A unique identifier for each owner.
- `Name`: The name of the owner.
- `Gym`: The name of the Gym the owner is associated with.

## Review

Represents a review for a Pokemon. Includes the following properties:

- `Id`: A unique identifier for each review.
- `Title`: The title of the review.
- `Text`: The text content of the review.

## Reviewer

Represents the person who wrote a review. Includes the following properties:

- `Id`: A unique identifier for each reviewer.
- `FirstName`: The first name of the reviewer.
- `LastName`: The last name of the reviewer.
