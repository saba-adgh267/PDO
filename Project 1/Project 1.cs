// Project # 1

int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

// Exercise 1 : Calculate the total score for each student

int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

Console.WriteLine("\nExercise 1 : Calculate total score for each student:\n");
Console.WriteLine("Sophia: " + sophiaSum);
Console.WriteLine("Nicolas: " + nicolasSum);
Console.WriteLine("Zahirah: " + zahirahSum);
Console.WriteLine("Jeong: " + jeongSum);

// Exercise 2 : Calculate the average score for each student and grade them

decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

Console.WriteLine("\nExercise 2 : Calculate average score and grade for each student:\n");
Console.WriteLine("Sophia: " + sophiaScore + " A");
Console.WriteLine("Nicolas: " + nicolasScore + " B");
Console.WriteLine("Zahirah: " + zahirahScore + " B");
Console.WriteLine("Jeong: " + jeongScore + " A");

// Exercise 3 : Format the output using escaped character sequences

Console.WriteLine("\nExercise 3 : Display score sheet for each student:\n");
Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");