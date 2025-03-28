# OpenApiGenerationNullability
Demonstrates a problem with Open API generation using Microsoft.AspNetCore.OpenApi
The project generates OpenApiGenerationNullability.json.
In that document a list of AmTranslation objects is used in 2 different classes.
In that case it seems that the reference generated in the second class is not correct.
In AmEnvironment the reference is: "$ref": "#/components/schemas/#/properties/application/properties/translations/items"
But it should be: "$ref": "#/components/schemas/AmTranslation" (as it is correct in AmApplication)

Seems this is already reported and should be fixed in 9.0.4: https://github.com/dotnet/aspnetcore/issues/60381

