var user = {
    name: "Ayush",
    age: 30,
    sayHi: function () {
        return "Hello world";
    }
};
console.log(user);
var username = "Saharsh";
username = 20;
var userInfo = [];
userInfo.push("Ankit");
userInfo.push(22);
userInfo.push(user);
// console.log(user);
// console.log(username);
// console.log(userInfo);
var EmployeeInfo = /** @class */ (function () {
    //   constructor() {
    //     this.empId = 777;
    //     this.empName = "default";
    //     this.dept = "default";
    //     this.desg = "default";
    //     this.salary = 77777;
    //   }
    function EmployeeInfo(eid, name, dep, des, sal) {
        this.empId = eid;
        this.empName = name;
        this.dept = dep;
        this.desg = des;
        this.salary = sal;
    }
    EmployeeInfo.prototype.getData = function () {
        //To access the class data memeber use this keyword
        this.empId = 100;
        this.empName = "Martin";
        this.dept = "IT";
        this.desg = "Product Manager";
        this.salary = 125000;
    };
    EmployeeInfo.prototype.showData = function () {
        console.log("EmpId:" + this.empId);
        console.log("EmpName:" + this.empName);
        console.log("Dept.:" + this.dept);
        console.log("Desg.:" + this.desg);
        console.log("Salary:" + this.salary);
    };
    return EmployeeInfo;
}());
// var martin = new EmployeeInfo();
// martin.getData();
// martin.showData();
// var blake = new EmployeeInfo();
// blake.showData();
var scott = new EmployeeInfo(999, "Scott", "Accounts", "Manager", 120000);
scott.showData();
//Overloading
function Add(p1, p2) {
    return p1 + p2;
}
console.log("Addition: " + Add(12, 13));
console.log("Addition: " + Add("Ayush", "Tripathy"));
//Arrow Function
var randomFunc = function (p, r, t) {
    return (p * r * t) / 100;
};
console.log("Simple Interest : " + randomFunc(1000, 2.7, 24));
