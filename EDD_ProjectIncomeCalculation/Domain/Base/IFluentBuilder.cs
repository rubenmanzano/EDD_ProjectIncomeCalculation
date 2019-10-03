namespace EDD_ProjectIncomeCalculation.Domain.Base
{
    public interface IFluentBuilder<out T>
        where T : class
    {
        /// <summary>
        /// Build an instance <typeparamref name="T"/>
        /// </summary>
        /// <returns>New instance of <typeparamref name="T"/></returns>
        T Build();
    }
}
