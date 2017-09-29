using ConsoleDesignPattern.Contracts;
using System;

namespace ConsoleDesignPattern.Abilities
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            throw new NotImplementedException();
        }
    }
}
