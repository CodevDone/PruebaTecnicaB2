#!/bin/bash
# List of commands
EXIT_STATUS=0
if :; then
    dotnet new sln      -o BlupperDinner
    cd BlupperDinner
    dotnet new webapi   -o BluperDinner.API -controllers    || EXIT_STATUS=1
    dotnet new classlib -o BluperDinner.Contracts           || EXIT_STATUS=2
    dotnet new classlib -o BluperDinner.Infrastructure      || EXIT_STATUS=3
    dotnet new classlib -o BluperDinner.Aplication          || EXIT_STATUS=4
    dotnet new classlib -o BluperDinner.Domain              || EXIT_STATUS=5

    dotnet sln add **/*.csproj                              || EXIT_STATUS=6
    dotnet add BluperDinner.API/ reference BluperDinner.Contracts/ BluperDinner.Aplication/ || EXIT_STATUS=7
    dotnet add BluperDinner.Infrastructure/ reference BluperDinner.Aplication/              || EXIT_STATUS=8
    dotnet add BluperDinner.Aplication/ reference BluperDinner.Domain/                      || EXIT_STATUS=9
    dotnet add BluperDinner.API/ reference BluperDinner.Infrastructure                 || EXIT_STATUS=10
    echo '--> set variables '
    echo $EXIT_STATUS

 
fi
