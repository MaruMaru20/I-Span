// 程序 procedure
// 函數 function
// 函式 / 副程式

// test 

// function showStar(count) {
//     var result = "";
//     for (let i = 1; i <= count; i++) {
//         result += "+";
//         // alert(i)
//     }
//     alert(result)
//     report.innerText = result.length;
//     // report.innerText = "OK";
//     // console.log("!!")
//     }

// function call1() {
//     call.innerText = "length is :" ;
//     // console.log("length:");
// }
    

//     call1(1);
//     showStar(4);

//  改~~~

    // function add(x, y) {
    //     var result;
    //     result = x * y;
    //     return result;
    // }
    // var answer = add(1.919e+999, 1.919e+137);
    // report.innerText = answer;


// 1  原版



// function showStar(count, what = "*") {
//     var result = "";
//     for (let i = 1; i <= count; i++) {
//         result += what;        
//     }
//     report.innerText = result;
// }
// showStar(3);
// // showStar(3, "S");



// 3 走前面(修改)

let showStar = (count, what = "*") => {
    var result = "";
    var max = 21;
    for (let i = 1; i <= count; i++) {
        result += what;        
    }
    report.innerText = result;

    if (result >= 0 ) {
        alert("錯誤誤誤誤誤(負數)!");

        report.innerText = "不可為負數!";        
    }
    else (result <= max) ;{
        alert(`請輸入0~${max}的數字`);
        report.innerText = `請輸入0~${max}的數字`;   
    }


}
showStar(-1);
// // showStar(3, "S");




