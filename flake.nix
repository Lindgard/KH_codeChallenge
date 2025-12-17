{
  description = "Dev shell for codeChallenge with .NET 9 SDK";

  inputs = {
    nixpkgs.url = "github:NixOS/nixpkgs/nixpkgs-unstable";
    flake-utils.url = "github:numtide/flake-utils";
  };

  outputs = { self, nixpkgs, flake-utils }:
    flake-utils.lib.eachDefaultSystem (system:
      let
        pkgs = import nixpkgs {
          inherit system;
          config = {
            allowUnfree = true;
          };
        };

        # .NET 9 SDK from nixpkgs
        dotnetSdk = pkgs.dotnet-sdk_9;
      in {
        devShells.default = pkgs.mkShell {
          buildInputs = [
            dotnetSdk
          ];

          DOTNET_ROOT = dotnetSdk;
        };
      });
}

