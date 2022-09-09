function validateForm() {
var name = document.getElementById("txtname").value;
if(name==""){
    alert("Name cannot be empty");
    return;
}
var pwd = document.getElementById("txtpass").value;
if(pwd==""){
    alert("Password must not be empty");
    return;
}
if(pwd.length < 4){
    alert("Password too short");
    return;
}
var add = document.getElementById("txtadd").value;
if(add ==""){
    alert("Address cannot be empty");
    return;
}
var gen = document.getElementsByName("gender");
alert("Gender:"+gen.length);
var g = "";
for(var i=0;i<gen.length;i++){
    if(gen[i].checked) g = gen[i].value;
}
if(g==""){
    alert("No gender selected");
    return;
}

var quali = document.getElementsByName("gender");
alert("Gender:"+quali.length);
var q = "";
for(var i=0;i<quali.length;i++){
    if(quali[i].checked) q += quali[i].value+",";
}
if(q==""){
    alert("No qualification selected");
    return;
}
var nation = document.getElementById("ddl").value;
if(nation==""){
    alert("Select a country");
    return;
}
var skills = document.getElementById("skills");
alert("Skills: "+skills.length);
var sk = "";
for(var i=0;i<skills.length;i++){
    if(skills[i].selected) sk += skills[i].value + ",";
}
if(sk == ""){
    alert("Select any one skill");
    return;
}

}
