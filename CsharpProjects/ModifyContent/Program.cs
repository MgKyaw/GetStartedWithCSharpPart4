﻿// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// // Console.WriteLine(openingPosition);
// // Console.WriteLine(closingPosition);

// openingPosition++;

// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += 6;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
