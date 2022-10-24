``` powershell 

# Project Structure
BlazorZero> mkdir BlazorZero
BlazorZero> cd BlazorZero
BlazorZero\BlazorZero> dotnet new web
BlazorZero\BlazorZero> cd ..
BlazorZero> dotnet new sln
BlazorZero> dotnet sln add .\BlazorZero\.

```

# Termian Window (Ctrl+")

# VSCode Commands (Ctrl+Shift+P )

> .NET: Generate Assetst for Build and Debug 
 !!! IF Error: Unable to generate assets to build and debug. OmniSharp server is not running.
 !!! > OmniSharp: Restart OmniSharp

# Git

```bash
# First Commit
git init
git add .
git commit -m "First Commit"
git remote add origin https://github.com/emremumcu/blazorzero.git
git remote -v
git push -f origin master

# Next Commits
git add .
git status
git commit -m "Bug fixes and updates"
git status
git push -f origin master
```


``` text
[Feature name]                          [AddMVC] [AddControllersWithViews] [AddControllers] [Add RazorPages]
Core Services (AddMvcCore())            | Yes | Yes | Yes | Yes |
Controllers                             | Yes | Yes | Yes | Yes |
Model Binding                           | Yes | Yes | Yes | Yes |
API Explorer                            | Yes | Yes | Yes | No  |
Authorization                           | Yes | Yes | Yes | Yes |
CORS                                    | Yes | Yes | Yes | No  |
Validations                             | Yes | Yes | Yes | Yes |
Formatter Mapping                       | Yes | Yes | Yes | No  |
Antiforgery                             | Yes | Yes | No  | Yes |
Temp Data                               | Yes | Yes | No  | Yes |
Views                                   | Yes | Yes | No  | Yes |
Razor Pages                             | Yes | No  | No  | Yes |
Razor View Engine(Tag helpers etc.      | Yes | Yes | No  | Yes |
Memory  cache                           | Yes | Yes | No  | Yes |
```

