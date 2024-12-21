using MySql.Data.MySqlClient;

namespace chatgpt{
    class Display:Dbcon{
        public void display(){
            using(MySqlConnection con=new MySqlConnection(dbcon())){
                con.Open();
                string query="select *from s_details inner join s_degree on s_details.StudentID=s_degree.StudentID";
                using(MySqlCommand com=new MySqlCommand(query,con)){
                    using(MySqlDataReader read=com.ExecuteReader()){
                        while(read.Read()){
                            Console.WriteLine($"StudentId:{read["StudentId"]}\tName:{read["Name"]}\tAge:{read["Age"]}\tDegree:{read["Degree"]}");

                        }
                    }

                }

            } 
        }
    }
}