from multiprocessing import Pool

def calcular_pi(a, b):
    s = 0
    for i in range(a, b):
        s += (1 if i % 2 == 0 else -1) / (2 * i + 1)
    return s

def principal(n, p):
    a = n // p
    b = [(i * a, (i + 1) * a) for i in range(p)]

    with Pool(processes = p) as pool:
        r = pool.starmap(calcular_pi, b)

    resul = 4 * sum(r)
    return resul

if __name__ == '__main__':
    n = 1000000
    p = 3

    pi = principal(n, p)
    print("Pi con un millon de terminos es: ", pi)
