algoritmo "Exerc�cioPosto"
// Fun��o :
// Autor :Jeferson Ayres Araujo e Guilherme Gasperini
// Data : 17/03/2023
// Se��o de Declara��es 
var
 ql,pf:real

tc:caracter
inicio
// Se��o de Comandos
escreva("digite a quantidade de litros a ser adquiridos: ")
leia(ql)
escreva("escolha entre o tipo A ou G: ")
leia(tc)
 se(tc="A")E(ql<=20)entao
  pf:= ql * 4,17
  escreva(" tipo A, e dever� pagar:", pf)
 senao
  se(tc="A")E(ql>20)entao
   pf:= ql * 4,08
   escreva(" tipo A e dever� pagar:", pf)
 fimse
  fimse
   se(tc="G")E(ql<=20)entao
    pf:= ql * 5,28
    escreva(" tipo G e dever� pagar:", pf)
   senao
    se(tc="G")E(ql>20)entao
     pf:= ql * 5,17
     escreva(" tipo G e dever� pagar:", pf)
   fimse
    fimse
fimalgoritmo
