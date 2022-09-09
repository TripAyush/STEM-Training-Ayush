interface GovtRules{
    double EmployeePF(double basicSalary);
    string LeaveDetails();
    double gratuityAmount(float serviceCompleted,double basicSalary);
}

class EmployeeInfo{
    long empid;
    string name;
    string dept;
    string desg;
    double basicSalary;

    public EmployeeInfo(long empid, string name, string dept, string desg, double basicSalary){
        this.empid = empid;
        this.name = name;
        this.dept = dept;
        this.desg = desg;
        this.basicSalary = basicSalary;
    }
}

class TCS : GovtRules,EmployeeInfo{

    public TCS(long empid, string name, string dept, string desg, double basicSalary) :base(empid, name, dept, desg, basicSalary) {

    }

    double EmployeePF(double basicSalary){
        double pf = basicSalary * 0.12;
        double epf = basicSalary * 0.833;
        double pension = basicSalary * 0.367;
        double finalPF = pf+epf+pension;
        return finalPF;
    }

    string LeaveDetails(){
        return "1 day of Casual Leave per month \n 12 days of Sick Leave per year \n 10 days of Privilege Leave per year";
    }

    double gratuityAmount(float serviceCompleted,double basicSalary){
        long gratuity = 0;
        if(serviceCompleted > 5) gratuity = basicSalary;
        if(serviceCompleted > 10) gratuity = 2*basicSalary;
        if(serviceCompleted > 20) gratuity = 3*basicSalary;
        if(serviceCompleted < 5) gratuity = 0;
        return gratuity;
    }
}

class Accenture : GovtRules,EmployeeInfo{
    double EmployeePF(double basicSalary){
        double pf = basicSalary * 0.12;
        double epf = basicSalary * 0.12;
        double finalPF = pf+epf;
        return finalPF;
    }

    string LeaveDetails(){
        return "2 day of Casual Leave per month \n 5 days of Sick Leave per year \n 5 days of Privilege Leave per year";
    }

    double gratuityAmount(float serviceCompleted,double basicSalary){
        return 0;
    }
}