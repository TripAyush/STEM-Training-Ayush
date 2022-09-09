//Interface
interface IUser {
  name: string;
  age: number;
  sayHi: () => string;
}

const user: IUser = {
  name: "Ayush",
  age: 30,
  sayHi: (): string => {
    return "Hello world";
  },
};

console.log(user);

let username: any = "Saharsh";
username = 20;

const userInfo: any = [];
userInfo.push("Ankit");
userInfo.push(22);
userInfo.push(user);

// console.log(user);
// console.log(username);
// console.log(userInfo);

class EmployeeInfo {
  private empId: number;
  private empName: string;
  private dept: string;
  private desg: string;
  private salary: number;

  getData(): void {
    //To access the class data memeber use this keyword
    this.empId = 100;
    this.empName = "Martin";
    this.dept = "IT";
    this.desg = "Product Manager";
    this.salary = 125000;
  }
  showData(): void {
    console.log("EmpId:" + this.empId);
    console.log("EmpName:" + this.empName);
    console.log("Dept.:" + this.dept);
    console.log("Desg.:" + this.desg);
    console.log("Salary:" + this.salary);
  }

  //   constructor() {
  //     this.empId = 777;
  //     this.empName = "default";
  //     this.dept = "default";
  //     this.desg = "default";
  //     this.salary = 77777;
  //   }

  constructor(
    eid: number,
    name: string,
    dep: string,
    des: string,
    sal: number
  ) {
    this.empId = eid;
    this.empName = name;
    this.dept = dep;
    this.desg = des;
    this.salary = sal;
  }
}

// var martin = new EmployeeInfo();
// martin.getData();
// martin.showData();

// var blake = new EmployeeInfo();
// blake.showData();

var scott = new EmployeeInfo(999, "Scott", "Accounts", "Manager", 120000);
scott.showData();

//Overloading
function Add(p1: any, p2: any): any {
  return p1 + p2;
}

console.log("Addition: " + Add(12, 13));
console.log("Addition: " + Add("Ayush", "Tripathy"));

//Arrow Function
const randomFunc = (p: number, r: number, t: number): number => {
  return (p * r * t) / 100;
};
console.log("Simple Interest : " + randomFunc(1000, 2.7, 24));

// Working with Moduels(class with data and functions)
// Get data using typescript (GetData.ts)
// export class TestExample {
//   public str: string;
// }

// Show Data using typescript (ShowData.ts)
// import {TestExample} from './TestExample;
// var obj = new TestExample();
// obj.str = "Declared in getData and calling in showData";
// console.log(obj.str);