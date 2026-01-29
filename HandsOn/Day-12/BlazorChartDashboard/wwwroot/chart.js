window.renderPolarChart = function () {
    const ctx = document.getElementById('polarChart').getContext('2d');

    new Chart(ctx, {
        type: 'polarArea',
        data: {
            labels: ['Electronics', 'Clothing', 'Grocery'],
            datasets: [{
                data: [45, 30, 25],
                backgroundColor: [
                    '#1cc88a',
                    '#36b9cc',
                    '#f6c23e'
                ]
            }]
        },
        options: {
            responsive: true
        }
    });
};