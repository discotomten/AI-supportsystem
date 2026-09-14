
const form = document.getElementById('ticket-form');
const result = document.getElementById('result');
const ticketsContainer = document.getElementById('tickets');

form.addEventListener('submit',  (e) => {
    e.preventDefault();

    const title = document.getElementById('title').value;
    const description = document.getElementById('description').value;

     const title = document.getElementById('title').value;
    const description = document.getElementById('description').value;

    fetch("/api/tickets", {
        method: "POST",
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({ title, description }),
    })
    .then(response => response.json())
    .then(ticket => {
        result.textContent = `Ärendet har skapats med prioritet: ${ticket.priority}`;
        form.reset();
    })
    .catch(() => {
        result.textContent = "Något gick fel.";
    });
});


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

loadTickets();