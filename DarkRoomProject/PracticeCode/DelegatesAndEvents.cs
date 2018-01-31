using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCode
{


    public class DelegatesAndEvents
    {
        /// <summary>
        /// This will be the method called in program to run your test, so put the code that you want to run in here, then call it in program.cs
        /// </summary>


        
        public static void RunCode()
        {

            Attack levelAttack = new Attack();
            Person john = new Person("John", "Smith", levelAttack);
            Person jack = new Person("Jack", "Rider", levelAttack);
            Person bobby = new Person("Bobby", "Brooks", levelAttack);
            Person billy = new Person("Billy", "Bob", levelAttack);
            Person david = new Person("David", "Campbell", levelAttack);
            

            Console.WriteLine(Person.personList.Count);
            david.AttackType.HeavyPunch(bobby);
            Console.WriteLine($"{bobby.FirstName} returns fire at {david.FirstName}");
            bobby.AttackType.LightPunch(david);
            Console.WriteLine("Incoming grenade!!");
            levelAttack.Grenade();
            Console.WriteLine($"{david.FirstName} hits {bobby.FirstName} with a devastating blow.");
            david.AttackType.HeavyPunch(bobby);
            Console.WriteLine(Person.personList.Count);
        }

    }

    public class Person
    {
        public static List<Person> personList = new List<Person>();
        private static Random rndm = new Random();
        public int Id { get; private set; }
        public int Health { get; set; } = 100;
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public static int Count { get; private set; }
        public Attack AttackType { get; private set; }
        public int Position { get; private set; } = rndm.Next(0, 15);
        public Attack OutsideAttack { get; set; }

        public Person(string firstName, string lastName, Attack outsideAttack)
        {
            Count++;
            Id = Count;
            FirstName = firstName;
            LastName = lastName;
            AttackType = new Attack();
            OutsideAttack = outsideAttack;
            AttackType.OnAttack += (sender, args) => 
            {
                Person defender = personList.Find(x => x.Id == args.TargetId);
                if(defender != null)
                {
                    defender.Health -= args.HitAmount;
                    Console.WriteLine($"{this.FirstName} hits {defender.FirstName} with a {args.HitName} for {args.HitAmount} hit points.\n"
                        + $"{defender.FirstName} has {defender.Health} health points left.");

                    if(defender.Health <= 0)
                    {
                        Console.WriteLine($"{defender.FirstName} cries out his final breath.  {defender.FirstName} {defender.LastName} is dead.");
                        personList.Remove(defender);
                    }
                }
                
            };
            OutsideAttack.OnBlast += (sender, args) => 
            {
                if(Position <= args.BlastRange)
                {
                    Health -= args.HitAmount;
                    Console.WriteLine($"{FirstName} took a grenade hit for {args.HitAmount}.\n"
                        + $"{FirstName} has {Health} left.");
                    if(Health <= 0)
                    {
                        personList.Remove(this);
                    }
                }
                else
                {
                    Console.WriteLine($"{FirstName} escaped the blast!!");
                }
            };
            personList.Add(this);
        }

        public static string FullName(Person person)
        {
            return $"{person.FirstName} {person.LastName}";
        }
    }

    public class AttackEventArgs: EventArgs
    {
        public int HitAmount { get; set; }
        public string HitName { get; set; }
        public int TargetId { get; set; }
        public int AttackerId { get; set; }
        public int BlastRange { get; set; }
            
    }

    public class Attack
    {
        public event EventHandler<AttackEventArgs> OnAttack;
        public event EventHandler<AttackEventArgs> OnBlast;
        
        public int HeavyPunchHitAmount { get; set; } = 50;
        public int LightPunchHitAmount { get; set; } = 25;
        public int GrenadeHitAmount { get; set; } = 75;
        public int GrenageBlastRange { get; set; } = 10;


        public void HeavyPunch(Person target)
        {
            OnAttack(this, new AttackEventArgs
            {
                HitAmount = HeavyPunchHitAmount,
                HitName = "Heavy Punch",
                TargetId = target.Id,
               
            });
        }

        public void LightPunch(Person target)
        {
            OnAttack(this, new AttackEventArgs
            {
                HitAmount = LightPunchHitAmount,
                HitName = "Light Punch",
                TargetId = target.Id,

            });
        }

        public void Grenade()
        {
            OnBlast(this, new AttackEventArgs
            {
                BlastRange = GrenageBlastRange,
                HitAmount = GrenadeHitAmount
            });
        }

    }
    
}
