# Fondamenti_CSH - C# Fundamentals Exercises

## Project Overview

This is a collection of C# console application exercises for learning fundamental programming concepts. The project contains 24 individual exercise projects covering various C# basics including control flow, collections, algorithms, and simple interactive applications.

**Repository Origin**: Personal learning exercises for C# fundamentals.

## Technology Stack

- **Language**: C# 
- **Framework**: .NET 10.0
- **Project Type**: Console Applications
- **IDE**: JetBrains Rider (configured via `.idea/` directory)
- **Solution Format**: XML-based solution file (`.slnx`)

## Project Structure

```
Fondamenti_CSH/
├── Exercises.slnx              # Solution file listing all projects
├── qodana.yaml                 # JetBrains Qodana code analysis configuration
├── .idea/                      # Rider IDE configuration
│
├── 1ton/                       # Loop exercise (1 to N)
├── Array/                      # Array operations (average, min, max, count)
├── Bank_System/                # Simple banking simulation
├── ConsoleApp1/                # Basic console template
├── Converter/                  # Unit conversion (km/miles, kg/lbs, liters/gallons)
├── Discount/                   # Discount calculation exercise
├── Fibonacci/                  # Fibonacci sequence and factorial
├── FreqChar/                   # Character frequency analysis
├── GestioneSpesa/              # Shopping list manager (Italian)
├── guessNumber/                # Number guessing game
├── IMC/                        # BMI calculator
├── ListArrayT/                 # List<T> generic collections
├── mathCalculator/             # Basic math calculator
├── MathLib/                    # Advanced math library (power, sqrt, GCD, LCM, primes)
├── Number_Descomposition/      # Number decomposition exercise
├── Palindrome/                 # Palindrome checker
├── Presentazione_Personale/    # Personal presentation app
├── Prime_Number/               # Prime number operations
├── Rectangle/                  # Rectangle geometry calculations
├── Rubrica_Telefono/           # Phone book application (Italian)
├── RubricaTelefono/            # Alternate phone book app
├── Table/                      # Multiplication table
├── Temperature/                # Temperature conversion
└── Temperature_While/          # Temperature conversion with while loop
```

## Build Configuration

All projects share the same configuration pattern:

```xml
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>
</Project>
```

### Build Commands

```bash
# Build entire solution
dotnet build Exercises.slnx

# Build specific project
dotnet build Bank_System/Bank_System.csproj

# Run specific project
dotnet run --project Bank_System

# Clean solution
dotnet clean Exercises.slnx
```

## Code Style Guidelines

### Project Conventions

1. **File Organization**: Each project contains:
   - One main `Program.cs` file with the exercise logic
   - One `.csproj` project file

2. **Namespace Pattern**: Uses folder name as namespace (e.g., `namespace Bank_System;`)

3. **Language Mix**: Code comments and UI messages use a mix of:
   - English (primary for code and documentation)
   - Italian (variable names and UI text in some projects: e.g., `GestioneSpesa`, `Rubrica_Telefono`)

### C# Features Used

- **Implicit Usings**: Enabled (no explicit `using System;` required in most files)
- **Nullable Reference Types**: Enabled (`string?` used for nullable strings)
- **Collection Expressions**: C# 12 collection syntax used (e.g., `int[] voti = [18, 1, 22, ...];`)
- **File-Scoped Namespaces**: Some projects use the newer file-scoped namespace syntax

### Common Patterns

```csharp
// Menu-driven console applications with switch statements
do {
    Console.WriteLine("1. Option one");
    Console.WriteLine("0. Exit");
    choice = int.Parse(Console.ReadLine());
    switch (choice) {
        case 1: DoSomething(); break;
        case 0: Console.WriteLine("Goodbye!"); break;
    }
} while (choice != 0);
```

## Testing

This is a learning project with **no automated tests**. Each exercise is designed to be:
1. Built and run individually
2. Tested manually via console interaction
3. Verified through expected console output

## Code Quality

### Qodana Configuration

JetBrains Qodana is configured for static code analysis:
- **Profile**: `qodana.starter` (starter inspection profile)
- **IDE**: QDNET (Qodana for .NET)

Run analysis locally (requires Qodana CLI):
```bash
qodana scan
```

## Known Issues & Notes

1. **Incomplete Projects**: Some projects appear to be works-in-progress (e.g., `ListArrayT/Program.cs` has incomplete code)

2. **Input Validation**: Most exercises use `int.Parse()` without try-catch for input parsing - this is intentional for simplicity in learning exercises

3. **Bug in Rubrica_Telefono**: The variable `choice` is used before being assigned (missing `choice = int.Parse(Console.ReadLine());` before the switch statement)

4. **Duplicate Projects**: There are two phone book projects (`RubricaTelefono/` and `Rubrica_Telefono/`)

## Development Workflow

1. Open the solution in JetBrains Rider or Visual Studio
2. Select the project you want to work on as the startup project
3. Run with `F5` or `dotnet run`
4. Follow the console prompts to interact with the exercise

## Project Categories

| Category | Projects |
|----------|----------|
| **Math/Algorithms** | Fibonacci, Prime_Number, MathLib, Number_Descomposition |
| **Collections** | Array, ListArrayT, FreqChar |
| **Conversions** | Converter, Temperature, Temperature_While, IMC |
| **Interactive Apps** | Bank_System, GestioneSpesa, Rubrica_Telefono, guessNumber |
| **Basic Exercises** | 1ton, Discount, Palindrome, Rectangle, Table |
