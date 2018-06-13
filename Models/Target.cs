namespace csharp_intro.Models
{

  public class Target
  {
    public decimal Health { get; private set; }
    public string Name { get; }
    public bool Alive { get; private set; } = true;

    public Target(string name, decimal health)
    {
      Name = name;
      Health = health;
    }

    public void Attack()
    {
      Health -= 1;
      if (Health <= 0)
      {
        Alive = false;
        Health = 0;
      }
    }

    public string GetOuchWord()
    {
      if(Health <= 50){
        return "stop it";
      }
      return "THAT WAS WEAK";
    }


  }


}