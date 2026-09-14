
const ticketsContainer = document.getElementById('tickets');

    function loadTickets() {
    fetch('/api/tickets')
        .then(response => response.json())
        .then(tickets => {
            ticketsContainer.innerHTML = '';

            tickets.forEach(ticket => {
                const div = document.createElement('div');
                div.className = 'ticket';

                div.innerHTML = `
                    <h3>${ticket.title}</h3>
                    <p>${ticket.description}</p>
                    <p>Prioritet: ${ticket.priority}</p>
                    <p>Status: ${ticket.status}</p>
                    <button data-id="${ticket.id}" class="close-btn" ${ticket.status === 'Closed' ? 'disabled' : ''}>
                        Stäng ärende
                    </button>
                `;

                ticketsContainer.appendChild(div);
            });

            document.querySelectorAll('.close-btn').forEach(button => {
                button.addEventListener('click', () => closeTicket(button.dataset.id));
            });
        });
}

function closeTicket(id) {
    fetch(`/api/tickets/${id}/close`, { method: 'PUT' })
        .then(response => {
            if (response.ok) {
                loadTickets();
            } else {
                alert('Kunde inte stänga ärendet.');
            }
        });
}

loadTickets();