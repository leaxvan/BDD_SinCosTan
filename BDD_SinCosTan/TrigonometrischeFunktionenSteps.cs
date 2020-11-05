using System;
using TechTalk.SpecFlow;
using Xunit;

namespace BDD_SinCosTan
{
    [Binding]
    public class TrigonometrischeFunktionenSteps
    {
        double nr_pi, erg;

        [Given(@"the first number PI")]
        public void GivenTheFirstNumberPI()
        {
            nr_pi = Math.PI;
        }
        
        [When(@"sinus is taken")]
        public void WhenSinusIsTaken()
        {
            erg = Math.Sin(nr_pi);
        }
        
        [When(@"cosnius is taken")]
        public void WhenCosniusIsTaken()
        {
            erg = Math.Cos(nr_pi);
        }
        
        [When(@"tangens is taken")]
        public void WhenTangensIsTaken()
        {
            erg = Math.Tan(nr_pi);
        }
        
        [Then(@"the rasult should be (.*)")]
        public void ThenTheRasultShouldBe(int p0)
        {
            Assert.Equal(p0, erg, 5);
        }
    }
}
