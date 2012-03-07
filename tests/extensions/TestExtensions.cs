using System.Web.Mvc;
using Machine.Specifications;

namespace tests
{
    public static class TestExtensions
    {
        public static ActionResult ShouldBeAView(this ActionResult actionResult)
        {
            ((ViewResult)actionResult).ViewName.ShouldBeEmpty();
            return actionResult;
        }

        public static ViewResult And(this ActionResult actionResult)
        {
            return ((ViewResult) actionResult);
        }

        public static T ShouldHaveAModelOfType<T>(this ViewResult viewResult)
        {
            viewResult.Model.ShouldBeOfType(typeof(T));
            return (T) viewResult.Model;
        }
    }
}