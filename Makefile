run: ConsoleApp/*
	dotnet run --project ConsoleApp

test: ConsoleApp.Tests/* ConsoleApp/*
	dotnet test


build: ConsoleApp/*
	dotnet build 
