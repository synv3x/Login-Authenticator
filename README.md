# C# login Authentication System

A Login authentication system built in C# .NET Framework 4.8.

## Projects
- **LibLoginAuthencator** - Class library containing the core authentication logic
- **ConLoginAuthenticator** - Console application interface
- **WinLoginAuthenticator** - Windows Forms GUI interace

## Features
- Object-oriented design with class library architecture
- private property setters for data encapsulation
- Nullable return types (bool?) for authentication states
- Null validation for empty inputs
- Five hardcoded credential pairs for authentication
- WinForms GUI with keyboard shortcuts (ALT+U, ALT+P)

## Authentication States
| Result | Meaning|
|--------|--------|
|`null`| Username or password not provided |
|`false`| Invalid credentials |
|`true`| Authentication successful |

## Technologies 

- C# .NET Framework 4.8
- Windows Forms
- Visual Studio 2022

## Usage
Clone the repo, open `LoginAuth.sln` in Visual Studio 2022, set WinLoginAuthenticator as the startup app, provide References of the projects, and run. 
`Right Click WinLoginAuthenticator -> Add -> References -> Projects -> Check✅ LibLoginAuthenticator`
`Right click ConLoginAuthenticator -> Add -> References -> Projects -> Check✅ LibLoginAuthenticator`

Test credentials:
- john/doe
- jane/smith
- admin/admin
- synvex/perfect
- user/password
