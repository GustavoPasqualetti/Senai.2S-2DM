function Calcular() {
    event.preventDefault();

    let n1 = parseFloat(document.getElementById('n1').value);
    let n2 = parseFloat(document.getElementById('n2').value);
    let op = document.getElementById('operacao').value;
    let resultado;

    if (isNaN(n1) || isNaN(n2)) {
        alert("E necessario digitar apenas numeros");
        return;
    }

    if (op == '+') {
        resultado = somar(n1, n2)
    } else if (op == "-") {
        resultado = subtrair(n1, n2)
    } else if (op == '/') {
        resultado = dividir(n1, n2)
    } else if (op == '*') {
        resultado = multiplicar(n1, n2)
    }

    document.getElementById('result').innerText = resultado;

    document.getElementsByTagName('form')
    console.log(form);
    
}

function somar(x, y) {
    return x + y
}

function subtrair(x, y) {
    return x - y
}

function dividir(x, y) {
    if (y == 0) {
        return 'Nao é um número';
    }
    return x / y
}

function multiplicar(x, y) {
    return x * y
}
