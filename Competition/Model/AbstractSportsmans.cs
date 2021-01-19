using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Sportsmans
{

    abstract class AbstractSportsman
    {
        public abstract AbstractSportsmanA CreateSportsmanA();
        public abstract AbstractSportsmanB CreateSportsmanB();
    }
    class ConcreteSportsman1 : AbstractSportsman
    {
        public override AbstractSportsmanA CreateSportsmanA()
        {
            return new SportsmanA1();
        }

        public override AbstractSportsmanB CreateSportsmanB()
        {
            return new SportsmanB1();
        }
    }
    class ConcreteSportsman2 : AbstractSportsman
    {
        public override AbstractSportsmanA CreateSportsmanA()
        {
            return new SportsmanA2();
        }

        public override AbstractSportsmanB CreateSportsmanB()
        {
            return new SportsmanB2();
        }
    }

    abstract class AbstractSportsmanA
    { }

    abstract class AbstractSportsmanB
    { }

    class SportsmanA1 : AbstractSportsmanA
    { }

    class SportsmanB1 : AbstractSportsmanB
    { }

    class SportsmanA2 : AbstractSportsmanA
    { }

    class SportsmanB2 : AbstractSportsmanB
    { }

    class Client
    {
        private AbstractSportsmanA abstractSportsmanA;
        private AbstractSportsmanB abstractSportsmanB;

        public Client(AbstractSportsman factory)
        {
            abstractSportsmanB = factory.CreateSportsmanB();
            abstractSportsmanA = factory.CreateSportsmanA();
        }
        public void Run()
        { }
    }

}
