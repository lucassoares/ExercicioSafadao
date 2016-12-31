dia = int(input("Digite seu dia: "))
mes = int(input("Digite seu mes: "))
ano = int(input("Digite seu ano: "))

safadeza = (mes) + (ano/100) * (50-dia)
anjo = 100 - safadeza

print("Safadeza: " + str(safadeza))
print("Anjo: " + str(anjo))
