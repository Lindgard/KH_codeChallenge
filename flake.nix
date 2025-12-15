{
  description = "Dev shell for codeChallenge with .NET 10 SDK";

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

        # .NET 10 SDK from nixpkgs
        dotnetSdk = pkgs.dotnet-sdk_10;
      in {
        devShells.default = pkgs.mkShell {
          buildInputs = [
            dotnetSdk
          ];

          DOTNET_ROOT = dotnetSdk;
        };
      });
}

