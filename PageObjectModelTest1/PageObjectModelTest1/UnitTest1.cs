using PageObjectModelTest1.Page;

namespace PageObjectModelTest1
{
    public class Tests:Base
    {
        PracticeForm form;

        [Test]
        public void Test1()
        {
            form = new PracticeForm();
            form.EnterName("Nina");
            form.EnterName("Nina");
            form.EnterEmail("nina@hotmail.com");
            form.EnterMobile("0654976214");
            form.EnterSubjects("Maths");
            form.SelectGender();
            form.SelectHobbies();
            form.PressButton();
            


        }
    }

    public class Base
    {
    }
}