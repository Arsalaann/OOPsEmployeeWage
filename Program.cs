namespace OOPsEmployeeWage{
    class Program{
        private int WAGEPERHOUR=20,FULLTIME=8,PARTTIME=8,MONTH=20;
        private int DailyWage(int d,int wph){
            return d*FULLTIME*WAGEPERHOUR;
        }
        private int DailyWage(int m,int d,int wph){
            return m*MONTH*d*FULLTIME*WAGEPERHOUR;
        }
        public static void Main(string[] args){
            Program obj=new Program();
            Attendance employee=new Attendance();
            employee.CheckAttendance();
            obj.DailyWage(1,obj.WAGEPERHOUR);
            obj.DailyWage(1,1,obj.WAGEPERHOUR);
        }
    }
}