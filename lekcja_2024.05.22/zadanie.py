# def f(n):
#     wynik = 0
#     for i in range(n):
#         for j in range(n):
#             if (i+j) % 2 == 0:
#                 wynik+=1
#     return wynik

# print(f(8)) # wynik = 32



# zadanie 14
# def f(n):
#     if n < 0: return 0
#     return n + f(n-2)


# def g(n):
#     wynik = 0
#     for i in range(n,0,-2):
#         wynik += i
#     return wynik

# print(f(21))
# print(g(21))


# # zadanie 16
# def f(n,k):
#     wynik = 1
#     for i in range(1, n+1):
#         if i != k:
#             wynik *= i
#     return wynik

# print(f(6,5))

