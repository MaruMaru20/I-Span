document.getElementById('submitButton').addEventListener('click', function (event) {
    event.preventDefault(); // 防止默認的a標籤跳轉行為

    // 顯示圖片並觸發動畫
    var par = document.querySelector('.par');
    par.style.display = 'block'; // 顯示元素
    par.classList.add('show'); // 添加show類來觸發動畫

    // 在2秒後跳轉
    setTimeout(function() {
        window.location.href = "nav/nav.html"; // 轉跳頁面
    }, 2580); // 設置延遲2秒
});
