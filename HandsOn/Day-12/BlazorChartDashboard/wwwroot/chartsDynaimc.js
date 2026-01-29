let currentChart = null;

window.renderDynamicChart = function (chartType) {

    const ctx = document.getElementById("dynamicChart").getContext("2d");

    // Destroy previous chart (CRITICAL)
    if (currentChart) {
        currentChart.destroy();
    }

    let dataset = {
        label: 'Sample Data',
        data: [12, 19, 3, 5, 2, 3]
    };

    // Special data formats
    if (chartType === 'scatter') {
        dataset.data = [
            { x: -10, y: 0 },
            { x: 0, y: 10 },
            { x: 10, y: 5 }
        ];
    }

    if (chartType === 'bubble') {
        dataset.data = [
            { x: 20, y: 30, r: 15 },
            { x: 40, y: 10, r: 10 }
        ];
    }

    currentChart = new Chart(ctx, {
        type: chartType,
        data: {
            labels: ['Red', 'Blue', 'Yellow', 'Green', 'Purple', 'Orange'],
            datasets: [dataset]
        },
        options: {
            responsive: true
        }
    });
};