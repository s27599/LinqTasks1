﻿using LinqTasks.Models;

namespace LinqTasks.Extensions;

public static class CustomExtensionMethods
{
    //Put your extension methods here
    public static IEnumerable<Emp> GetEmpsWithSubordinates(this IEnumerable<Emp> emps)
    {
        
        return emps.Where(x => emps.Any(sub => sub.Mgr == x))
            .OrderBy(x => x.Ename)
            .ThenByDescending(x => x.Salary);
    }
}