<link rel="stylesheet" type='text/css' href="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/devicon.min.css" />

FormatDax(Model.AllMeasures, true);
foreach (var m in Model.AllMeasures)
    {
        m.Expression = '\n' + m.Expression;
    }
