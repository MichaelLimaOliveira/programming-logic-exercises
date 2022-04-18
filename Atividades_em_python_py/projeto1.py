numero_digitado = input("Digite um numero real positivo para ser fatorizado: ");

while numero_digitado.isnumeric() == False:
  
  numero_digitado = input("Digite um numero real positivo para ser fatorizado: ");

numero = int(numero_digitado)

fatorial = 1

while numero >=1:
  
  fatorial = fatorial * numero
  numero = numero - 1
  
print(fatorial)