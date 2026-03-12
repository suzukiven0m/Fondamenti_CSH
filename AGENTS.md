# Fondamenti_CSH - C# Fundamentals Exercises

## Project Overview

This repository contains a collection of 26 C# console application exercises designed for learning fundamental programming concepts. Each exercise is a standalone project covering specific C# topics including control flow, collections, object-oriented programming, algorithms, and interactive console applications.

**Repository Type**: Personal learning exercises for C# fundamentals  
**Primary Language**: English (code, documentation) with Italian mixed in variable names and UI text in some projects  
**Solution File**: `Exercises.slnx` (XML-based solution format)

---

## Technology Stack

| Component | Version / Configuration |
|-----------|------------------------|
| Language | C# |
| Framework | .NET 10.0 |
| Project Type | Console Applications |
| IDE | JetBrains Rider |
| Solution Format | XML-based `.slnx` |

### Project Configuration (All Projects)

All `.csproj` files share identical configuration:

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

### C# Language Features Used

- **Implicit Usings**: Enabled (no explicit `using System;` required)
- **Nullable Reference Types**: Enabled (`string?` for nullable strings)
- **Collection Expressions**: C# 12 collection syntax (e.g., `int[] voti = [18, 1, 22, ...];`)
- **File-Scoped Namespaces**: Used in newer projects (e.g., `namespace OOP_Film;`)
- **Target-Typed New**: `Student student1 = new();`
- **Object Initializers**: Used extensively in OOP projects

---

## Project Structure

```
Fondamenti_CSH/
├── Exercises.slnx              # Solution file listing all 26 projects
├── qodana.yaml                 # JetBrains Qodana code analysis configuration
├── .idea/                      # Rider IDE configuration
├── README.md                   # Brief project description
│
├── 1ton/                       # Loop exercise: print 1 to N
├── Array/                      # Array operations: average, min, max, count
├── Bank_System/                # Simple banking simulation (deposit/withdraw/balance)
├── ConsoleApp1/                # Basic console template (empty)
├── Converter/                  # Unit conversion (km/miles, kg/lbs, liters/gallons)
├── Discount/                   # Discount calculation exercise
├── Fibonacci/                  # Fibonacci sequence and factorial calculator
├── FreqChar/                   # Character frequency analysis (vowels, consonants, etc.)
├── GestioneSpesa/              # Shopping list manager (Italian language)
├── guessNumber/                # Number guessing game (0-100, 7 tries)
├── IMC/                        # BMI calculator
├── ListArrayT/                 # List<T> generic collections (incomplete)
├── mathCalculator/             # Basic math calculator
├── MathLib/                    # Advanced math library (power, sqrt, GCD, LCM, primes)
├── Number_Descomposition/      # Number decomposition exercise
├── ObjectOrientedProgramming/  # OOP basics with Student class
├── OOP_Film/                   # OOP exercise: Film, Director, Actor, Location, Nation classes
├── OOP_Rectangle/              # OOP exercise: Rectangle class with validation
├── Palindrome/                 # Palindrome checker
├── Presentazione_Personale/    # Personal presentation app
├── Prime_Number/               # Prime number operations
├── Rectangle/                  # Rectangle geometry calculations (procedural)
├── Rubrica_Telefono/           # Phone book application (Italian/English mix)
├── Table/                      # Multiplication table generator
├── Temperature/                # Temperature conversion (Celsius/Fahrenheit/Kelvin)
└── Temperature_While/          # Temperature conversion using while loop
```

---

## Build Commands

### Build Entire Solution
```bash
dotnet build Exercises.slnx
```

### Build Specific Project
```bash
dotnet build <ProjectName>/<ProjectName>.csproj
# Example: dotnet build Bank_System/Bank_System.csproj
```

### Run Specific Project
```bash
dotnet run --project <ProjectName>
# Example: dotnet run --project Bank_System
```

### Clean Solution
```bash
dotnet clean Exercises.slnx
```

---

## Code Organization Patterns

### File Structure
Each project typically contains:
- **Single `Program.cs`**: Entry point with exercise logic
- **`.csproj`**: Project configuration file
- **Additional `.cs` files** (OOP projects): Class definitions

### Namespace Patterns
- **File-scoped namespaces**: `namespace OOP_Film;` (newer projects)
- **Block-scoped namespaces**: `namespace Bank_System { ... }` (older projects)

### Common Code Patterns

#### 1. Menu-Driven Console Applications
```csharp
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

#### 2. Class Structure (OOP Projects)
```csharp
namespace ProjectName;

internal class ClassName
{
    // Auto-properties with default values
    public string Property { get; set; } = "";
    
    // Computed properties
    public string Info => $"Some info: {Property}";
    
    // Constructors
    public ClassName() { }  // Empty constructor
    public ClassName(string param) { Property = param; }  // Parameterized
}
```

#### 3. Input Handling Patterns
- **Simple parsing**: `int.Parse(Console.ReadLine())`
- **TryParse with validation**: `int.TryParse(Console.ReadLine(), out choice)`
- **Null-coalescing**: `Console.ReadLine() ?? ""`

---

## Testing Strategy

**No automated tests** are present in this repository. Each exercise is designed for:

1. **Manual Testing**: Build and run individual projects
2. **Console Interaction**: Test via user input/output
3. **Visual Verification**: Verify expected console output

### Testing Workflow
1. Build the project: `dotnet build <project>`
2. Run the project: `dotnet run --project <project>`
3. Follow console prompts to test functionality
4. Verify output matches expected behavior

---

## Code Quality Configuration

### Qodana (JetBrains Static Analysis)

Configuration file: `qodana.yaml`

```yaml
version: "1.0"
ide: QDNET
profile:
  name: qodana.starter
```

**Run Analysis Locally** (requires Qodana CLI):
```bash
qodana scan
```

- **Profile**: `qodana.starter` (starter inspection profile)
- **IDE**: QDNET (Qodana for .NET)

---

## Language Usage Notes

### Code Language
- **Primary**: English for all code, keywords, and documentation
- **Comments**: Mostly English, occasional Italian in some projects

### UI/Language Mix
Some projects use Italian for user-facing text:

| Project | Language Used |
|---------|--------------|
| `GestioneSpesa` | Italian ("Aggiungi", "Rimuovi", "Lista") |
| `Rubrica_Telefono` | Mixed Italian/English |
| `FreqChar` | Italian ("Inserisci", "Vocali", "Consonanti") |
| Most others | English |

### Variable Naming
- Generally follows C# conventions (PascalCase for methods/properties, camelCase for locals)
- Some Italian variable names in Italian-language projects (e.g., `nomi`, `numeri`, `voti`)

---

## Known Issues and Code Quality Notes

### Compilation Errors

1. **ListArrayT/Program.cs** (Lines 22-24)
   - Incomplete code: `foreach (string s in student)` missing collection and body
   - **Status**: Unfinished exercise

2. **Rubrica_Telefono/Program.cs** (Line 27)
   - Variable `choice` used before assignment
   - Missing: `choice = int.Parse(Console.ReadLine());` before switch statement
   - **Impact**: Will not compile

3. **OOP_Rectangle/Rectangle.cs** (Line 46)
   - Missing semicolon after `return true`
   - Method `IsRectangle` has wrong signature in call vs definition
   - **Impact**: Will not compile

4. **ObjectOrientedProgramming/Student.cs** (Line 19)
   - Constructor named `Student` but it's a method (missing return type would make it a constructor)
   - Should be `public Student(string name, ...)` not `public void Student(...)`
   - **Impact**: Logic error - won't initialize object properly

### Design Issues

1. **IMC/Program.cs** (Line 17)
   - Integer division bug: `int imc = weight / (height * height);`
   - Height is in meters but read as integer, causing incorrect BMI calculation
   - **Fix**: Use `double` for height and weight

2. **Bank_System/Program.cs** (Lines 1-2)
   - Unnecessary `using static` directives for unused namespaces
   - No functional impact but code smell

3. **OOP_Rectangle/Rectangle.cs** (Line 32)
   - Constructor named `Rectangle` with `double` return type
   - Should not have a return type for constructors
   - **Impact**: This is a method, not a constructor

### Input Validation
Most exercises use direct `Parse()` without try-catch for simplicity:
```csharp
int value = int.Parse(Console.ReadLine());  // Will throw on invalid input
```

Exceptions (with proper validation):
- `MathLib/Program.cs`: Uses `int.TryParse()` with retry loop
- `Fibonacci/Program.cs`: Uses `int.TryParse()` with validation

---

## Development Workflow

1. **Open Solution**: Open `Exercises.slnx` in JetBrains Rider or Visual Studio
2. **Select Startup Project**: Set the exercise you want to run as startup project
3. **Run**: Press `F5` or use `dotnet run --project <name>`
4. **Test Manually**: Follow console prompts and verify behavior

### Recommended IDE Setup
- **Primary**: JetBrains Rider (`.idea/` directory configured)
- **Alternative**: Visual Studio 2022+ (supports `.slnx` format)
- **CLI**: Any terminal with .NET 10.0 SDK

---

## Project Categories

| Category | Projects | Concepts Covered |
|----------|----------|------------------|
| **Math/Algorithms** | Fibonacci, Prime_Number, MathLib, Number_Descomposition | Loops, algorithms, prime numbers, factorization |
| **Collections** | Array, ListArrayT, FreqChar | Arrays, List<T>, LINQ, iteration |
| **Conversions** | Converter, Temperature, Temperature_While, IMC | Unit conversion, formulas |
| **Interactive Apps** | Bank_System, GestioneSpesa, Rubrica_Telefono, guessNumber | User input, state management |
| **OOP Fundamentals** | OOP_Film, OOP_Rectangle, ObjectOrientedProgramming | Classes, properties, constructors, encapsulation |
| **Basic Exercises** | 1ton, Discount, Palindrome, Rectangle, Table, mathCalculator | Control flow, basic logic |
| **Personal Apps** | Presentazione_Personale | String manipulation, output formatting |

---

## Security Considerations

- **No sensitive data**: These are learning exercises with no authentication or sensitive operations
- **Input vulnerabilities**: Most projects lack input validation (intentional for simplicity)
- **No network operations**: All exercises are offline console applications
- **No external dependencies**: No NuGet packages or third-party libraries

---

## Additional Notes

- **Learning Progression**: Projects range from basic (ConsoleApp1, 1ton) to intermediate (OOP_Film, MathLib)
- **Incomplete Work**: Some projects are works-in-progress (noted in Known Issues)
- **ASCII Art**: Some projects use ASCII art for visual appeal (Converter, Fibonacci, guessNumber)
- **Console Encoding**: Some projects set `Console.OutputEncoding = System.Text.Encoding.UTF8;` for special characters
