// 物件導向

var seaanimal = "Big-fish";


    // property // method 

// 定義
class Animal {

    // 建構式 = 1: 設初值(若缺資料才會給)
    constructor(weightValue = 1) {
        this.weight = weightValue;
    }

    makeSound() {
        alert(`${seaanimal}:bo...boboo..boooo ... (oAO)!!!`)
    }

// -------------------------2--------------------------------
    get weight() {
        return this._weight;
        
    }
    set weight(weightValue) {
        alert(`Error: 404 : ${weightValue}`);
        if (weightValue > 0) {
            this._weight = weightValue;
        };

    }
}
    // show msg: must new

// 實體化物件
// var obj;
// obj = new Animal();
// obj.makeSound();
// -------------------------2--------------------------------
var obj = new Animal(3);
obj.weight = 6;
// report.innerText = obj.weight;
// obj.constructor(); X.X

// -------------------------3--------------------------------

// 父階: 上一代
// class SeaDog extends Animal {
//     constructor(locationValue, weightValue) {
//         super(weightValue);
//         this.location = locationValue;
//     }

//     makeSound() {
//         // super.makeSound();
//         alert(`SeaDog:bao~bao~bao`);
//     }

// }

// var obj = new SeaDog(`under the sea`, undefined);
// // obj.makeSound();
// report.innerText = obj.weight + " , " + obj.location;
// -------------------------3--------------------------------

class CDog {
    constructor(imageUrl) {
        this.imageUrl = imageUrl; // 儲存圖片的URL
    }

    // 增加顯示圖片的方法
    showImage() {
        // 創建圖片元素並設定其 src 屬性
        const img = document.createElement('img');
        img.src = this.imageUrl;
        img.alt = "Dog Image";
        img.style.width = "300px"; // 設定圖片大小
        img.style.height = "auto";

        img.style.transform = "translateX(200px)"; 
        img.style.animation = "moveDownLeftRight 4s ease-in-out forwards";  
        // 將圖片添加到頁面中
        document.body.appendChild(img);
    }
}

// 使用範例
const dog = new CDog('sead.png');

dog.showImage(); // 顯示圖片
