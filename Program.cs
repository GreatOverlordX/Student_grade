
int exam_assignments = 5;

string[] student_names = new string[] { "Harry", "Ron", "Hermi", "Volde"};

int[] harryScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] ronScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] hermioneScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] voldemortScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string current_student_letterGrade = "";


// Header row for scores & grades
string display_header = "Student\t\tExam Score\tOverall Grade\tExtra Credit\n";
var header = display_header;
Console.Clear();
Console.WriteLine(header);

/* The outer foreach loop --> used for:
	- iteration through student names
 	- assigning student's grades to the studentScores array
 	- sum assignment scores (inner foreach loop)
 	- calculation numeric & letter grade
 	- writing score report information
*/
foreach (string name in student_names)
{
	string currentStudent = name;

	if (currentStudent == "Harry")
		studentScores = harryScores;

	else if (currentStudent == "Ron")
		studentScores = ronScores;
	
	else if (currentStudent == "Hermione")
		studentScores = hermioneScores;
	
	else if (currentStudent == "Voldemort")
		studentScores = voldemortScores;

	int graded_assignments = 0;
	int graded_extraCredit_assignments = 0;

	int sum_examScores = 0;
	int sumExtra_creditScores = 0;

	decimal currentStudent_grade = 0;
	decimal currentStudentExam_score = 0;
	decimal currentStudent_extraCredit_score = 0;

	/* 
	~ inner foreach loop: 
		--> sums the exam & extra credit scores
		--> counts the extra credit assignments
			 	===----  foreach Innerloop ----===
	*/
	foreach (int score in studentScores)
	{
		graded_assignments += 1;

		if (graded_assignments <= exam_assignments)
		{
			sum_examScores = sum_examScores + score;
		}

		else
		{
			graded_extraCredit_assignments += 1;
			sumExtra_creditScores += score;
		}

	}

	currentStudentExam_score = (decimal)(sum_examScores) / exam_assignments;
	currentStudent_extraCredit_score = (decimal)(sumExtra_creditScores) / graded_extraCredit_assignments;

	currentStudent_grade = (decimal)((decimal)sum_examScores + ((decimal) sumExtra_creditScores / 10)) / exam_assignments;

	if (currentStudent_grade >= 97)
		current_student_letterGrade = "A+";
	
	else if (currentStudent_grade >= 93)
		current_student_letterGrade = "A";
	
	else if (currentStudent_grade >= 90)
		current_student_letterGrade = "A-";
	
	else if (currentStudent_grade >= 87)
		current_student_letterGrade = "B+";
	
	else if (currentStudent_grade >= 83)
		current_student_letterGrade = "B";
	
	else if (currentStudent_grade >= 80)
		current_student_letterGrade = "B-";
	
	else if (currentStudent_grade >= 77)
		current_student_letterGrade = "C+";

	else if (currentStudent_grade >= 73)
		current_student_letterGrade = "C";

	else if (currentStudent_grade >= 70)
		current_student_letterGrade = "C-";

	else if (currentStudent_grade >= 67)
		current_student_letterGrade = "D+";

	else if (currentStudent_grade >= 63)
		current_student_letterGrade = "D";

	else if (currentStudent_grade >= 60)
		current_student_letterGrade = "D-";
	
	else
		current_student_letterGrade = "F";
	/*
		Student			Exam Score		Overall Grade		Extra Credit
		Harry:			92.2 A-			95.88	A			92 (3.68 pts)
	*/
	Console.WriteLine($"{currentStudent}\t\t{currentStudentExam_score}\t\t{currentStudent_grade}\t{current_student_letterGrade}\t{currentStudent_extraCredit_score} ({(((decimal)sumExtra_creditScores / 10) / exam_assignments)} pts)");
}
/*
		---- ---- 	~ Required for running in VsCode (Keeps the Output windows open to view results) ~	---- ----
*/
string output_display_message = "\n\rPress the Enter Key to continue...";
var output_display = output_display_message;
Console.WriteLine(output_display);
Console.ReadLine();
