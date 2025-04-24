
# ConsoleApp_OldPhonePad_v2

A C# console application that simulates typing on an old mobile phone keypad. It translates numeric input sequences into corresponding letters, mimicking the multi-press input method used in traditional mobile phones.

---

## Features

- **Numeric to Text Conversion**: Maps numeric keys (`1`–`9`) to their corresponding letters.
- **Multi-Press Handling**: Supports repeated key presses to select the desired character.
- **Special Character Handling**:
  - `*`: Acts as a backspace, removing the last character.
  - `#`: Acts as a send key, ending the input.
  - Space (` `): Separates characters, resetting the key press count.
- **Input Validation**: Ignores invalid characters and handles edge cases gracefully.

---

## Project Structure

```
ConsoleApp_OldPhonePad_v2/
├── Interfaces/
│   └── IHelperClass.cs       # Interface defining the contract for helper methods
├── Class/
│   └── Helpers.cs            # Implementation of the IHelperClass interface
├── Program.cs                # Entry point of the console application
└── ConsoleApp_OldPhonePad_v2.csproj  # Project file
```

---

## Unit Testing

Unit tests are implemented to ensure the correctness of the input processing logic.

### Test Project Structure

```
ConsoleApp_OldPhonePad_v2.Tests/
├── HelpersTests.cs           # Contains unit tests for the Helpers class
└── ConsoleApp_OldPhonePad_v2.Tests.csproj  # Test project file
```

### ✅ Sample Test Cases

- Input: `"4433555 555666#"`, Expected Output: `"HELLO"`
- Input: `"227#"`, Expected Output: `"AB"`
- Input: `"44*33#"`, Expected Output: `"E"`
- Input: `"8 88777444666*664#"`, Expected Output: `"TURING"`
- Input: `"222 2 22#"`, Expected Output: `"CAB"`
- Input: `"77777777777777 7#"`, Expected Output: `"QP"`
- Input: `"7777 33 888 33 66#"`, Expected Output: `"SEVEN"`
- Input: `"1 111#"`, Expected Output: `"&("`
---

## Requirements

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) or later
- Compatible IDE: [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or [Visual Studio Code](https://code.visualstudio.com/)

---

## Build and Run Instructions

1. **Clone the Repository**:

   ```bash
   git clone https://github.com/myjseven/ConsoleApp_OldPhonePad_v2.git
   cd ConsoleApp_OldPhonePad_v2
   ```

2. **Build the Project**:

   ```bash
   dotnet build
   ```

3. **Run the Application**:

   ```bash
   dotnet run
   ```

4. **Run Unit Tests**:

   Navigate to the test project directory and execute:

   ```bash
   dotnet test
   ```

---

