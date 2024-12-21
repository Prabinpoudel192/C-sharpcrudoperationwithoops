namespace chatgpt{
    class Student:Dbcon{
        private int StudentId,Age;
        private string Name,Degree;
        public int StudentIdgetset{
            get{
                return StudentId;
            }set{
                if(value>9999 || value<0){
                    if(value<0){
                        StudentId=0;
                    }else if(value>9999){
                        StudentId=9999;
                    }
                }else{
                        StudentId=value;
                    }
            }

        }
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