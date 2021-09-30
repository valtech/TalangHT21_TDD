# TalangHT21_TDD

## Prerequisites
* .Net SDK 5.0
* Any IDE (Rider, VSCode, VisualStudio are recommended)
* MiniCover
  * `dotnet tool install --global minicover`

## Usage
* To run test
  * `dotnet test` or "watch it" with: `dotnet watch test --project FizzBuzzTest`
* To generate coverage report
  * `./run_minicover.sh`

## The assignment
You are to implement FizzBuzz using TDD methodology.

The rules are:
* You have to write the test first using the Red-Green-Refactor process
  * You are not allowed to write ANY production code until you have a failing test (Red state)
  * You are only allowed to write the absolute minimum amount of production code to repair the test (Green state)
  * If applicable you are allowed to rearrange the production code, but not allowed to change the logic. (Refactor state)
  * Repeat the Red state
* A test is only allowed to test ONE functionality
  * Use the least amount of asserts needed to verify the functionality
* If different test cases only differ on data, consider using a parameterized test
* Unit tests don't contain any infrastructure, they only test logic/flow
* Integration tests don't contain exhaustive logic tests. They only test happy flow or relevant alternative flows.
  * Integration tests don't use mocks (unless totally unavoidable)