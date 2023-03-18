function openGithub() {
    window.open("https://github.com/achaszar");
}

function openLinkedin() {
    window.open("https://www.linkedin.com/in/austin-chaszar/");
}

function myFunction() {
    navigator.clipboard.writeText(document.getElementById('myInput').innerText)
        .then(function () {
            console.log('text has been copied!')
            alert("Copied!!")
        })
}