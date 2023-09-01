--------Liskov Substitution Example:--------

Neka kajem che vsqko jivotno izdava nqkakuv zvuk 

interface/abstract class Animal
-void DoSound()

=>

class Dog : Animal
-void DoSound() -> "Bark..."; (Kucheto lae)

class Cat : Animal
-void DoSound() -> "Meow..."; (Kotkata mquka)

class Human : Animal
-void DoSound() -> "Talking..."; (Choveka govori)

class Rabbit : Animal
-void DoSound() -> ""; (Zaeka ne izdava zvuk)
 *Good: zaeka po princip ne izdava zvuk, zatova vrushtame "" (toest nishto <=> string.Empty)
 *Bad: da hvurlqme primerno 'throw new Exception' ili izobshto da ne slagame metoda w class-a

 ------------------------------------------------------------------------------------------------

  kato cqlo, trqbva naslednika da moje da zameni bazoviqt klas bez problemi
