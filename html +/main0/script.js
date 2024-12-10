document.addEventListener('DOMContentLoaded', function() {
    document.getElementById('submitButton').addEventListener('click', function(event) {
        
        event.preventDefault();
        
        var username = document.getElementById('username').value;
        var password = document.getElementById('password').value;
        
        if (username === '' || password === '') {
            alert('雖然這個是做好玩的,但是還是要填東西ㄟ～～～ ლ(˙ ｖ ˙)უ');
        } else {
            window.location.href = '/page/indexH.html';
        }
    });
});


const passwordField = document.getElementById('password');
const togglePasswordButton = document.getElementById('Pwhide');

togglePasswordButton.addEventListener('click', function() {
    const type = passwordField.getAttribute('type') === 'password' ? 'text' : 'password';
    passwordField.setAttribute('type', type);
    // Toggle icon
    togglePasswordButton.name = togglePasswordButton.name === 'lock-closed' ? 'lock-open-outline' : 'lock-closed';
});


