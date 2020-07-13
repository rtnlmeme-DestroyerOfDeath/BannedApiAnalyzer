BannedApiAnalyzer provides warnings that indicate banned API rule violations in C# and/or Visual Basic code. The warnings are organized into rule areas. This section provides an explanation of each of the default BannedApiAnalyzer rules. 

### Rule areas

**[API Design Rules](docs/ApiDesignRules.md)**

Rules related to API design and usage.

### Additional documentation


Updated rules for symbol file:

Lines starting with # are ignored.

Each line must define a symbol, according to the csharp documentation string speficications.
[documentation](https://docs.microsoft.com/en-us/dotnet/api/system.type.getproperties?view=netcore-3.1).

Optionally a message.
Optionally a warning level.

Syntax:
symbol;message;warningLevel

Valid values for warningLevel are
- Info
- Error
- Warning

The message defaults to empty, the warningLevel defaults to Warning.

To specify a rule with an emtpy message and a warning level of Error, do this:

symbol;;Error







