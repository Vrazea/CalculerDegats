namespace Calculer_degats;

/*
    CONSIGNES
    Dans votre jeu, chaque arme possède une puissance d'attaque.
    Vous devez créer une méthode CalculateWeaponDamage() qui reçoit deux paramètres :
    - weaponPower : la puissance de l'arme.
    - bonus : le bonus de dégâts du personnage.
    La méthode doit calculer les dégâts totaux et retourner le résultat.

    Dans Main() :
    1. Appelez la méthode avec une arme de puissance 40 et un bonus de 15.
    2. Récupérez le résultat dans une variable appelée degats.
    3. Affichez le nombre de dégâts infligés.
 */
class Program
{
    public static int weaponPower;
    public static int bonusDmg;
    public static int Damage;
    public static void CalculateWeaponDamage()
    { 
        weaponPower = 40; 
        bonusDmg = 15;
        Damage = weaponPower + bonusDmg;
        
    }
    
    
    
    
    
    static void Main(string[] args)
    {
        CalculateWeaponDamage();
        Console.WriteLine(Damage + " Dégats infligés");
    }
}