import kalkulator
print("For volume of cylinder please type 'I'.")
print("For Pythagorean theorem please type 'II'.")
print("For surface area of diamond please type'III'.")
print("For power of speaker please type 'IV'.")
print("For surface area of triangle please type 'V'.")
print("For volume of hexagonal prism please type 'VI'.")
print("For area of heptagonal prism please type 'VII'.")
while True:
    inp = input()
    if inp == "I":
        print("Please input 'r': ")
        r = float(input())
        print("Please input 'h': ")
        h = float(input())
        vc = kalkulator.v_cylindra(r,h)
        print("Result: ")
        print(vc)
    elif inp == "II":
        print("Please input 'a': ")
        a = float(input())
        print("Please input 'b': ")
        b = float(input())
        twp = kalkulator.tw_pitoagorasa(a,b)
        print("Result: ")
        print(twp)
    elif inp == "III":
        kalkulator.a_o_romb()
    elif inp == "IV":
        kalkulator.P_glosnika()
    elif inp == "V":
        print("Please input 'a': ")
        a = float(input())
        print("Please input 'h': ")
        h = float(input())
        P = kalkulator.P_trojkata(a,h)
        print("Result: ")
        print(P)
    elif inp == "VI":
        print("Please input 'a': ")
        a = float(input())
        print("Please input 'h': ")
        h = float(input())
        vhp = kalkulator.V_hex_prism(a,h)
        print("Result: ")
        print(vhp)
    elif inp == "VII":
        kalkulator.a_o_hepta_prism()