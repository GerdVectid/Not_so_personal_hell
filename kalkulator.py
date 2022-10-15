from math import pi, sqrt

def v_cylindra(r:float,h:float):
    return pi*r**2*h

def tw_pitoagorasa(a:float,b:float):
    return sqrt(a**2 + b**2)

def a_o_romb():
    print("Please input 'e': ")
    e = float(input())
    print("Please input 'f': ")
    f = float(input())
    aor = e*f/2
    print("Result: ")
    print(aor)

def P_glosnika():
    print("Please input 'I': ")
    I = float(input())
    print("Please input 'S': ")
    S = float(input())
    P = I*S
    print("Result: ")
    print(P)

def P_trojkata(a:float,h:float):
    return a*h/2

def V_hex_prism(a:float,h:float):
    return (3*sqrt(3)/2)*a**2*h

def a_o_hepta_prism():
    print("Please input 'a': ")
    a = float(input())
    print("Please input 'h': ")
    h = float(input())
    B = 3.364*a**2
    p = 7*a
    aohp = 2*B+p*h
    print("Result: ")
    print(aohp)