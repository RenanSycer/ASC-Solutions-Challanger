namespace AcademicMVC.Models
{
    public class Class
    {
        private int  ClassId { get; set; }
        private string  ClassName { get; set; }
        private int []StudentsId { get; set; } // Não tem como salvar uma coleção no banco..... ou tem?

        public Class()
        {
            
        }
        
        public Class(int classId, string className, int[] studentsId)
        {
            ClassId = classId;
            ClassName = className;
            StudentsId = studentsId;
        }
    }
}