namespace AcademicMVC.Models
{
    public class Grades
    {
        private int GradesId { get; set; }
        private int StudentId { get; set; }
        private float FirstExam{ get; set; }
        private float SecondExam{ get; set; }
        private float ThirdExam { get; set; }

        private double AvarageGrade { get; set; }
        
        private float RecuperationExam { get; set; }
        
        private float CompetitionExam { get; set; }

       
        //Constructor
        
        public Grades(int gradesId, int studentId, float firstProof, float secondProof, float thirdProof)
        {
            GradesId = gradesId;
            StudentId = studentId;
            FirstExam = firstProof;
            SecondExam = secondProof;
            ThirdExam = thirdProof;
            AvarageGrade = calculateAvarage();  
        }
        
        //Methods
        
        public double  calculateAvarage() 
        {
            double pesoSecondProof =  1.20;
            double pesoThirdProof = 1.40;
            
            double avarage = ( FirstExam + (SecondExam * pesoSecondProof) + (ThirdExam * pesoThirdProof)) / 3.60;

            return avarage;
        }
//
//        public string isAproved()
//        {
//            if (AvarageGrade > 4)
//            {
//                return "reprovado";
//            }
//        }
//        
    }
}