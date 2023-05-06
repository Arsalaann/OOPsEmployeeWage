namespace OOPsEmployeeWage{
    class Program{
        private int WAGEPERHOUR=20,FULLTIME=8,PARTTIME=8;
        private int DailyWage(int d,int wph){
            return d*FULLTIME*WAGEPERHOUR;
        }
        public static void Main(string[] args){
            Program obj=new Program();
            Attendance employee=new Attendance();
            employee.CheckAttendance();
            obj.DailyWage(1,obj.WAGEPERHOUR);
        }
    }
}