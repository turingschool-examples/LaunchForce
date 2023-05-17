# LaunchForce

## Instructions
* Fork this repository
* Clone your forked repository
* Build and **test** the classes described below
* Commit after each class is complete
* Push your work to your forked repository
* Submit a pull request from your repository to this repository

## Iteration 1

`Person kathy = new Person("Kathy Chan", 10);`  
Create a `Person` class with the following properties and methods:
* string .Name
* int .Experience
* `List<string> .Specialties`
* void .AddSpecialty(string specialty)
  * this should add the given specialty to the person's list of .Specialties

`Spacecraft daedalus = new Spacecraft("Daedalus", 400);`  
Create a `Spacecraft` class with the following properties and methods:
* string .Name
* int .Fuel

## Iteration 2
  
Update your Spacecraft class to have the following properties and methods:
* `List<Person> .Personnel`
* void .AddPersonnel(Person person)
  * this should add the given person to the spacecraft's list of .Personnel
* `List<string> .Roster()`
  * this should return a list of all the personnel's names
* int .TotalExperience()
  * this should return the total experience of all personnel
* double .AverageExperience()
  * this should return the average experience of all personnel
  
## Iteration 3

`Flotilla flotilla = new Flotilla();`
Create a `Flotilla` class that has the following properties and methods:
* `List<Spacecraft> .Ships`
* void .AddShip(Spacecraft ship)
  * this should add the given spacecraft to the flotilla's .Ships
* `List<string> .Roster()`
  * this should return a list of all the personnel's names (for all ships)
* `Dictionary<Ship, List<Person> .ShipSummary()`
  * this should return a dictionary where the keys are Ships and the values are that ship's Personnel.

