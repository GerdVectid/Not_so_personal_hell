from random import randint, random;
import auxiliary
# //////////PC
name = input("Hero name: ")

amount_of_defeated_opponents = 0
while auxiliary.life > 0:
    opponent = auxiliary.random_opponent()
    print("-"*40)
    while opponent[1] > 0:
        print(f"{name} is faced with {opponent[0]}")
        print(f"Enemy has {opponent[1]} HP and deals {opponent[2]} damage to you")
        auxiliary.life = auxiliary.life - opponent[2]
        if auxiliary.life < 0:
            break
        print(f"You have {auxiliary.life} HP left and {auxiliary.mana} MP left")
        att = auxiliary.pick_att()
        opponent[1] = opponent[1] - att
        print(f"You dealt {att} damage")
    print("-"*40)
    print("Opponent defeated!!!")
    amount_of_defeated_opponents += 1

print("-"*40)
print("Game Over!")
print("git gut")
print(f"You killed {amount_of_defeated_opponents} foes")