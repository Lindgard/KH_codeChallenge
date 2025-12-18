# CodeChallenges

## Description

a short series of challenges focusing on variable types, collections and
building a simple calculator to incorporate some of the variables and methods.

## Get Started

### Fork and clone the repository

```sh
# 1. Fork the repository on GitHub:
#    - Go to the repository page in your browser
#    - Click the "Fork" button to create your own copy

# 2. Clone your fork locally (replace YOUR_USERNAME with your GitHub username)
git clone https://github.com/YOUR_USERNAME/KH_codeChallenge.git

# 3. Change into the project directory
cd KH_codeChallenge
```

### Run with Nix

```sh
# 1. Ensure you have Nix installed:
#    https://nixos.org/download.html

# 2. Enter the Nix development shell (if you have a flake / shell.nix set up)
nix develop

# or, with legacy Nix:
# nix-shell

# 3. Build and run the project inside the Nix shell
dotnet run
```

### Run without Nix

```sh
# 1. Install the .NET SDK (if you haven't already)
#    https://dotnet.microsoft.com/download

# 2. Change into the project directory (if not already there)
cd KH_codeChallenge

# 3. Restore dependencies (if needed)
dotnet restore

# 4. Build and run the console application
dotnet run
```
