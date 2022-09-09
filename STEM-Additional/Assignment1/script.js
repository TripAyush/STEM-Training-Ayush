const calculate = () => {
  // Getting input from user into height variable.
  let chemistry = document.querySelector("#chemistry").value;
  let maths = document.querySelector("#maths").value;
  let phy = document.querySelector("#phy").value;
  let biology = document.querySelector("#biology").value;

  if (!chemistry || !maths || !phy || !biology)
    alert("Please enter all the marks");

  // Input is string so typecasting is necessary. */
  let totalgrades =
    parseFloat(chemistry) +
    parseFloat(maths) +
    parseFloat(biology) +
    parseFloat(phy);

  let grades;
  let percentage = (totalgrades / 400) * 100;
  if (percentage <= 100 && percentage >= 80) {
    grades = "A";
  } else if (percentage <= 79 && percentage >= 60) {
    grades = "B";
  } else if (percentage <= 59 && percentage >= 40) {
    grades = "C";
  } else {
    grades = "F";
  }

  if(totalgrades) document.getElementById("showTotal").setAttribute("value", totalgrades);

  // let avgScore = totalgrades / 5;
  if(totalgrades) document.getElementById("showAvg").setAttribute("value", totalgrades / 4);

  if(totalgrades) document.getElementById("showGrade").setAttribute("value", grades);
};

const setEmpty = () => {
  document.querySelector("#name").value = "";
  document.querySelector("#chemistry").value = "";
  document.querySelector("#maths").value = "";
  document.querySelector("#phy").value = "";
  document.querySelector("#biology").value = "";
  document.querySelector("#showGrade").value = "";
  document.querySelector("#showAvg").value = "";
  document.querySelector("#showTotal").value = "";
};
