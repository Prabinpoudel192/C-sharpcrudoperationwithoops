using MySql.Data.MySqlClient;

namespace chatgpt{
    class Student:Dbcon{
        private int StudentId,Age;
        private string Name,Degree;
        public int StudentIdgetset{
            get{
                return StudentId;
            }set{
                using(MySqlConnection con=new MySqlConnection(dbcon())){
                    con.Open();
                    start:
                    string query=$"select *from s_details where StudentID={value}";
                    using(MySqlCommand com=new MySqlCommand(query,con)){
                        using(MySqlDataReader read=com.ExecuteReader()){
                            if(read.HasRows){
                                value++;
                                Console.WriteLine($"Duplicate Student Id, Assigning and Check for availibilty of {value}");
                                goto start;
                            }else{
                            if(value<0){
                                Console.WriteLine("Invalid Student ID, Cannot be negative");
                                goto start;
                            }else{
                                StudentId=value;
                            }
                        }

                    }

                }}
           

        }}
        public int Agegetset{
            get{
                return Age;
            }set{
                if(value<=0 || value>100){
                    if(value<=0){
                        Age=1;
                    }else if(value>100){
                        Age=100;
                    }
                }else{
                    Age=value;
                }
            }
        }
         public string Namegetset{
            get{
                return Name;
            }set{
                
                        Name=value;
                    
            }

        }
        public string Degreegetset{
            get{
                return Degree;
            }set{
                if(string.IsNullOrEmpty(value)){
                    Degree="Not Yet Graduated";
                }else{
                    Degree=value;
                }
            }
        }
        
    }
}