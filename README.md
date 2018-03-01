# SOChart
This is an attempt to help on the following Question:
https://stackoverflow.com/questions/49049576/wpf-missing-assembly-reference

## Instructions
1. Reference the following nuget package: `System.Windows.Controls.DataVisualization.Toolkit`
2. Add the following namespaces to your xaml:
```
xmlns:chartingToolkit="clr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=System.Windows.Controls.DataVisualization.Toolkit"
xmlns:visualizationToolkit="clr-namespace:System.Windows.Controls.DataVisualization;assembly=System.Windows.Controls.DataVisualization.Toolkit"
```
3. Reference those namespaces in your chart creation and enjoy!
