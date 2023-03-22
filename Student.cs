//class definition

class Student{
    
    //fields
    public long studentId;
    public string firstName;
    public string lastName;
    public string program;

    //properties

    private DateTime _birthDate; // use underscore for naming private fields
    public DateTime birthDate{ //same name without underscore
        //get;// do we want to make this visible
        set{//we'll add validation
            // use value keyword to access the new value being set
            if (value < DateTime.Now.AddYears(-100)){
                throw new ArgumentException("thats an incorrect value enter something within the last 100 years");
            }
            else {
                this._birthDate = value;
            }
        } 
    }
    private float _average; // this is the actual bucket of data.
    public float average{ // this is a method, not an actual bucket of data
        get{
            return this._average; //just return whatever value is stored
        }// read operation
        set{ //write operation
            //add valid averages from 0-100
            if (value >= 0 && value <=100){
                this._average = value;
            }
            else{
                this._average = 0; //no exception, hangle invalid range by setting default value.
            }
        } 
    }
    //constructors
    public Student(long studentId, string firstName, string lastName, string program, DateTime birthDate){
        // recommended to use constructors to set values
        //not recommended to add validation, use setters for that.
        this.studentId = studentId;
        this.firstName = firstName;
        this.lastName = lastName;
        this.program = program;
        this.birthDate = birthDate; // use the property method not the private field in order to keep validation
    }
    //public methods
    //private methods
    
}