# _Word Counter_
#### By _**Florin Mirica**_
GitHub link: https://github.com/florinmirica/WordCounter.Solution.git

## Description

_This app will count how many times a specific word appears in a string and return the count to the user. Program will count only occurences of the full word.  Both the word to search for and the string will be provided by the user._
## Setup/Installation Requirements

Download .NET Core 1.1.4 SDK and .NET Core Runtime 1.1.2 and install. Download Mono and install.

* _Clone the project from https://github.com/florinmirica/WordCounter.Solution.git
* _Navigate in the command line to WordCounter.Solution/WordCounter.Test/
* Use the command $dotnet restore to import the packages used for this project.
* _To run the tests, use the command $dotnet test
* To run the program, navigate in the command line to WordCounter.Solution/WordCounter
* To run in console, compile the project using the command $mcs Program.cs Models/RepeatCounter.cs. Run the file with the command $mono Program.exe
* To run in your browser, use the command $dotnet build, and then $dotnet run.
* _Navigate to http://localhost:5000/ in your web browser to get started.

## Specifications

* Program will ask the user to enter a sentence
* Program will ask the user to enter a word
* Program returns a number that represents how many times the word was found in the sentence
	Example User input sentence: What cars do you like? Do you like german cars or american cars more?
	Example User input word: Cars
	Example Output: "I found the word 3 time(s)"
* Program returns 0 if the chosen word is not found in the sentence or it is not a full word
	Example User Input sentence: Carts are found in the supermarket and the carts have different sizes.
	Example User Input word: Car
	Example Output: "I found the word 0 time(s)"
* Program returns a number that represents how many times the word was found in the sentence in both Uppercase and Lowercase
	Example User Input sentence: CARS can be seen in the parking lot and the cArs are all white.
	Example User Input word: cars
	Example Output: "I found the word 2 time(s)"
* Program returns a number that represents how many times the word was found in the sentence when punctuation is present
	Example User Input sentence: Cars...can be seen in the parking lot, i think that some of them are white!!!
	Example User Input word: cars
	Example Output: "I found the word 1 time(s)"
	
	
## Known bugs

No known bugs

## Support and contact details

miricaflorin@hotmail.com

## Language and technologies used:

C#
MS Visual Studio 2017

Copyright (c) 2019 Florin Mirica
