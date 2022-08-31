Algoritmo "Financas"
// Autor(a)    : Antonio Carlos
// Data atual  : 30/08/2022
Var
// Seção de Declarações das variáveis 

 m, c,t, i , a, j :real
 
 // M = Montante.
 // C = Capital.
 // i = taxa.
 // t = meses
 // a = ano
 // j = juros
inicio

// recebendo valor do capital
  escreval("Informe o capital: ")
  leia(c)
  // recebendo o periodo.
  escreval("Informe os meses: ")
  leia(t)
  // transformando.
  i := (7/100)
  
  a := (t/12)
  
  
  // calculando
  m := c*(1 + i) ^ a
  
  j := (m - c)
  
  
  // imprimindo o Montante.
  escreval("Montante: ", m)
  
  escreval ("Juros: ", j)
  
  fimalgoritmo