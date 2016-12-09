Notes
-----
- According to the problem description, "The symbols 'I', 'X', 'C', and 'M' can be repeated at most 3 times in a row."
  Because of this, the largest number that will convert is 3999 ("MMMCMXCIX") - 4000 would be "MMMM", which is not
  allowed.  (There ARE ways to represent larger numbers in Roman numerals, but not for the purposes of this problem!)
- When converting from Roman to Arabic, passing a blank or null string will convert to 0 (zero).
- The Roman-to-Arabic conversion is only partially complete - basic values like M, I, or XC will convert, but not more
  complex ones like MCMLXXIII.

Build Instructions
------------------
This kata was written in Visual Studio 2015.  It can be built, run, and have tests run using the standard options
in the VS2015 GUI.

If you would prefer to build, run the program, and run tests through the command line,
1.  Open a Developer Command Prompt for VS2015 (it should be at Programs / Visual Studio 2015 / Developer Command
    Prompt for VS2015).
2.  In the command prompt, change to the directory where the solution file (RomanNumeralKata.sln) is located.
3.  Run the build.bat file.
4.  To run the demo program, run the RunProgram.bat file.
5.  To run the tests, run the RunTests.bat file.