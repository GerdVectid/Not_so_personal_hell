from random import randint, random;
# ///////////
mana = 100
life = 100
# ///////////
# [name,hp,att,ac]
monster1 = ["Goblin child",5,randint(0,1),0]
monster2 = ["Goblin adult",10,randint(1,5),1]
beast1 = ["Feral Dog",5,randint(0,10),2]
beast2 = ["Bear",40,randint(10,20),5]
human1 = ["Bandit",20,randint(5,10),3]
undead1 = ["Animated decayed corpse",60,randint(0,1),4]
list_opponents = [monster1,monster1,monster2,monster2,monster2,monster2,monster2,undead1,undead1,beast1,
beast1,beast1,beast1,beast1,beast2,beast2,human1,human1,human1,human1]

def random_opponent():
    opponent = list_opponents[randint(0,19)].copy()
    return opponent
# ///////////
def normal_att():
    return randint(0,10)

def fireball():
    global mana
    mana -= 10
    return randint(10,25)

def strong_att():
    return randint(5,15)

def smite():
    global mana
    mana -= 5
    return randint(5,20)

def vampiric_succ():
    global life
    x = randint(5,10)
    life += x
    return x

# ///////////
def pick_att():
    print("a/A - Normal attack")
    print("b/B - Fireball")
    print("c/C - Strong punch")
    print("d/D - Smite")
    print("e/E - Vampiric drain")
    what = input()
    if what.upper() == "A":
        print("-"*40)
        return normal_att()
    elif what.upper() == "B":
        if mana >= 10:
            print("-"*40)
            return fireball()
        else:
            print("-"*40)
            print("No Mana")
            return 0
    elif what.upper() == "C":
        if life >= 50:
            print("-"*40)
            return strong_att()
        else:
            print("-"*40)
            print("You are exhausted")
            return 0
    elif what.upper() == "D":
        if mana >= 5:
            print("-"*40)
            return smite()
        else:
            print("-"*40)
            print("No Mana")
            return 0
    elif what.upper() == "E":
        if life > random_opponent()[1]:
            print("-"*40)
            return vampiric_succ()
        else:
            print("-"*40)
            print("You cant drain life from stronger opponent")
            return 0
    else:
        print("No option picked.")
        return 0