// Initialize the echarts instance based on the prepared dom
var myChart = echarts.init(document.getElementById('main'));

// Specify the configuration items and data for the chart
var option = {
    title: {
        text: 'Prueba PPG-IPG'
    },
    tooltip: {},
    legend: {
        data: [5, 54, 12, 23, 5]
    },
    xAxis: {
        data: ['Ascendencia', 'Responsabilidad', 'Estabilida Emocional', 'Sociabilidad', 'Cautela'],
        //data: factorsData,
    },
    yAxis: {},
    series: [
        {
            name: 'Percentil',
            type: 'bar',
            data: percentilesData
        }
    ]
};

// Display the chart using the configuration items and data just specified.
myChart.setOption(option);
