//走後面


// 巢狀

function showStars (count, what = "*") {
    if (count > 0) {
        if (count <= 21) {
            var result = "";
            for (let i = 1; i <= count; i++) {
                result += what;
            }
            report.innerText = result;
        }
        else {
            report.innerText = "count <= 21 please";
        }
    }
    else {
        report.innerText = "count > 0 please";
    }
}

// 單純if

function showStar(count, what = "*") {

    if (count <= 0) {
        report.innerText = 'r>0pls';
        return;
    }
    if (count > 21) {
        report.innerText = 'r<21pls';
        return -2;
    }

    var result = "";
    for (let i = 1; i <= count; i++) {
        result += what;        
    }
    report.innerText = result;
}

showStar(33);

function showStar(count, what = "*") {
    if checkdata(){
        if (count <= 0) {
            report.innerText = 'r>0pls';
            return;
        }
        if (count > 21) {
            report.innerText = 'r<21pls';
            return -2;
        }
    }
    var result = "";
    for (let i = 1; i <= count; i++) {
        result += what;        
    }
    report.innerText = result;
}
showStar(3);