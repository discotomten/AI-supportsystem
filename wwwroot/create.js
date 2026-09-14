const form = document.getElementById('ticket-form');
const result = document.getElementById('result');

form.addEventListener('submit', (e) => {
    e.preventDefault();

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