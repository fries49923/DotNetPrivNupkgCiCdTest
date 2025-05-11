# DotNetPrivNupkgCiCdTest

This repository is used to test a complete CI/CD workflow for a .NET class library targeting **.NET 6 / 7 / 8**, including:

- Build and test on pull requests to `main` (via `dev` branch)
- Run **xUnit tests** — merging is blocked if tests fail
- On successful merge to `main`, automatically:
  - Builds the library
  - Packs it into a `.nupkg`
  - Publishes the package to **GitHub Packages (private)**

This is a demo repository for experimenting with **GitHub Actions** automation.
