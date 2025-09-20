// Format all measurs in your model

FormatDax(Model.AllMeasures, true);
foreach (var m in Model.AllMeasures)
    {
        m.Expression = '\n' + m.Expression;
    }
