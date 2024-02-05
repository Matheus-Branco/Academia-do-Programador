var a, b, c = 0;
console.writeline("Digite em cm o tamanho de cada um dos lados de um triângulo:");
console.read(a);
console.read(b);
console.read(c);

switch (Triangulo) {
    case Triangulo-Escaleno:
        a != b && b != c && c != a
        console.writeline("Isso é um Triângulo Escaleno")
        break;
    case Triangulo-Isosceles:
        a == b || b == c || c == a
        console.writeline("Isso é um Triângulo Isósceles")
        break;
    case Triangulo-Equilatero:
        a == b && b == c && c == a
        console.writeline("Isso é um Triângulo Equilátero")
        break;
    case Triangulo-Equilatero:
        a,b > c || b,c > a || c,a > b
        console.writeline("Triângulo Inválido")
        break;

    default:
        console.writeline("Triângulo Inválido")
        break;
}