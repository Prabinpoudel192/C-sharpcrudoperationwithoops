using MySql.Data.MySqlClient;

namespace chatgpt{
    class SpecificDetail:Student{
        public void specificDetail(){
            start:
            Console.WriteLine("Please enter the valid StudentID:");
            int.TryParse(Console.ReadLine(),out int a);
          using(MySqlConnection con=new MySqlConnection(dbcon())){
            con.Open();
            string query=$"select *from s_details inner join s_degree on s_details.StudentID=s_degree.StudentID where s_details.StudentID={a} && s_degree.StudentID={a}";
            using(MySqlCommand com=new MySqlCommand(query,con)){
                using(MySqlDataReader read=com.ExecuteReader()){
                    if(read.HasRows){
                        while(read.Read()){
                        Console.WriteLine($"StudentID:{read["StudentID"]}\tName:{read["Name"]}\tAge:{read["Age"]}\tDegree:{read["Degree"]}");
                        }
                        }else{
                            Console.WriteLine("No record found");
                            goto start;
                        }
                }

            }
          }
        }
        public virtual void graduateStudent(){
            astart:
            Console.WriteLine("Please enter the valid StudentID:");
            int.TryParse(Console.ReadLine(),out int a);
          using(MySqlConnection con=new MySqlConnection(dbcon())){
            con.Open();
            string query=$"select *from s_details inner join s_degree on s_details.StudentID=s_degree.StudentID where s_details.StudentID={a} && s_degree.StudentID={a}";
            using(MySqlCommand com=new MySqlCommand(query,con)){
                using(MySqlDataReader read=com.ExecuteReader()){
                    if(read.HasRows){
                     read.Read();
                        string s=$"{read["Degree"]}";
                        if(s!="Not Yet Graduated"){
                        
                        Console.WriteLine($"StudentID:{read["StudentID"]}\tName:{read["Name"]}\tAge:{read["Age"]}\tDegree:{read["Degree"]}");
                        }else{
                            Console.WriteLine("The Student with the provided detail is not graduated yet.");
                        }
                        }else{
                            Console.WriteLine("No record found");
                            goto astart;
                        }
                }

            }
          }

        }
    }
}