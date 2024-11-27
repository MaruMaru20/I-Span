

function doChange() {
    // document.getElementById("test").innerHTML += this.name + ":" + this.value + "<br>";
    localStorage.setItem(this.name, this.value);
}
// onkeyup & onkeydown & onkeypress
document.getElementById("txtName").onkeyup = doChange;
document.getElementById("txtEmail").onkeyup = doChange;
document.getElementById("txtPhone").onkeyup = doChange;

// txtName.value = localStorage.getItem("txtName");
// txtEmail.value = localStorage.getItem("txtEmail");
// txtPhone.value = localStorage.getItem("txtPhone");


function readAndShow() {
    if (localStorage["txtName"])
        document.getElementById("txtName").value = localStorage["txtName"];
    if (localStorage["txtEmail"])
        document.getElementById("txtEmail").value = localStorage["txtEmail"];
    if (localStorage["txtPhone"])
        document.getElementById("txtPhone").value = localStorage["txtPhone"];
}

window.onload = readAndShow;

document.forms[0].onsubmit = function () { localStorage.clear(); };
// localStorage.removeItem("");
