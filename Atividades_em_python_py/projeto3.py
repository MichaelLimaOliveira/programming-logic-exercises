speed_user = int(input("Qual a velocidade que voce estava: "))
max_speed_route = 80

if speed_user <= max_speed_route:
  print("Não ouve multa !!")
elif speed_user > max_speed_route:
  if speed_user in range(80,90 +1 ):
    print("Levou uma multa leve!!")
  elif speed_user in range(91,100 +1):
    print("Levou multa grave !!!")
  elif speed_user > 100:
    print("LEVOU UMA MULTA GRAVISSIMA !!!!!!")

'''
posso usar if variavel < variavel2 and variavel == varial
o and e para adicionar comparaçao dupla em python
'''