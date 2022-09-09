var num1 = parseInt(prompt("Enter num1"));
var num2 = parseInt(prompt("Enter num2"));
var op = prompt("Enter operator(+,-,*,/)");
var result = 0;
switch (op) {
  case "+":
    result = num1 + num2;
    break;
  case "-":
    result = num1 - num2;
    break;
  case "*":
    result = num1 * num2;
    break;
  case "/":
    result = num1 / num2;
    break;
  default:
    alert("Invalid Operation");
}
alert("Result : " + result);
