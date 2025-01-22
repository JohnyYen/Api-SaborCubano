using System;
using System.Data.Common;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace SaborCubano.Infrastructure.Persistence.Interceptor;

public class ManyToManyIncludeInterceptor : DbCommandInterceptor
{
    public override InterceptionResult<DbDataReader> ReaderExecuting(
        DbCommand command,
        CommandEventData eventData,
        InterceptionResult<DbDataReader> result)
    {
        if(command.CommandText.Contains("FROM \"Restaurant\""))
        {
            command.CommandText = command.CommandText.Replace(
                "FROM \"Restaurant\" ",
                "FROM \"Restaurant\" as r " +
                "LEFT JOIN \"RestaurantService\" ON r.\"Id\" = \"RestaurantService\".\"RestaurantId\" " +
                "LEFT JOIN \"Service\" ON \"RestaurantService\".\"ServiceId\" = \"Service\".\"Id\" " +
                "LEFT JOIN \"RestaurantBussinesType\" ON r.\"Id\" = \"RestaurantBussinesType\".\"RestaurantId\" " +
                "LEFT JOIN \"BussinesType\" ON \"RestaurantBussinesType\".\"BussinesTypeId\" = \"BussinesType\".\"Id\" " +
                "LEFT JOIN \"RestaurantFoodType\" ON r.\"Id\" = \"RestaurantFoodType\".\"RestaurantId\" " +
                "LEFT JOIN \"FoodType\" ON \"RestaurantFoodType\".\"FoodTypeId\" = \"FoodType\".\"Id\""
            );

            command.CommandText = FixAsKeyword(command.CommandText);
        }
        return result;
    }

    private string FixAsKeyword(string sql)
    {
        string pattern = @"\bAS\b\s+\b\w+\b\s*$";
        if (Regex.IsMatch(sql, pattern))
            sql = Regex.Replace(sql, pattern, string.Empty);

        return sql;
    }
}
