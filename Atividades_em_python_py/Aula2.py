#Condicionais
#if, elif e else
#Encontre o maior valor entre dois numeros

primeiro_valor = input("Digite o primeiro valor: ")
segundo_valor = input("Digite o segundo valor: ")

if int(primeiro_valor) < int(segundo_valor):
  
  print(segundo_valor)
  
elif int(primeiro_valor) > int(segundo_valor):
  
  print(primeiro_valor)
  
else:
  
  print("valores são iguaís!")