//class definition

class Student{
    
    //fields
    public long studentId;
    public string firstName;
    public string lastName;
    public string Program;

    //properties

    private DateTime _birthDate; // use underscore for naming private fields
    public DateTime birthDate{ //same name without underscore
        //get;// do we want to make this visible
        set{//we'll add validation
            if (value < DateTime.Now.AddYears(-100)){
                throw new ArgumentException("thats an incorrect value enter something within the last 100 years");
            }
            else {
                this._birthDate = value;
            }
        } 
    }
    private float _average;
    public float average{
        get;// read operation
        set; //write operation
    }
    //constructors
    //public methods
    //private methods
    
}