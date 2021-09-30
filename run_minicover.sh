dotnet restore
dotnet build

# Instrument
minicover instrument --sources "FizzBuzz/**/*.cs" --tests "FizzBuzzTest/**/*.cs"

# Reset hits
minicover reset

dotnet test --no-build

# Uninstrument
minicover uninstrument

# Create html reports inside folder coverage-html
minicover htmlreport --threshold 90

# Console report
minicover report --threshold 90

