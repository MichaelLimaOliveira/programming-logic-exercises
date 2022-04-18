import random
number_random  = random.randint(1,10)
is_number = False

while is_number == False:
  number = int(input("Digite um numero entre 1 e 10: "))
  if number < number_random:
    print("O numero e menor !! ")
  elif number > number_random:
    print("O numero e maior !! ")
  elif number == number_random:
    is_number = True
    print("Voce acertou !!!!!")
  
                                     
