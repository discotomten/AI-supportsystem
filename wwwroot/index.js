const ticketsContainer = document.getElementById('tickets');
const form = document.getElementById('ticket-form');
const result = document.getElementById('result');

form.addEventListener('submit', async (e) => {
    e.preventDefault();

    const title = document.getElementById('title').value;
    const description = document.getElementById('description').value;

    const response = await fetch("/api/tickets", {
        method: "POST",
        headers: {'Content-Type' : 'application/json'},
        body: JSON.stringify({title, description}),
    });
    if(response.ok){
        const ticket = await response.json();
        result.textContent = `Ärendet har skapats med prioritet: ${ticket.priority}`;
        form.reset();
    } else{
        result.textContent = "Något gick fel.";
    }
});

        fetch("/api/tickets")
        .then(response => response.json())
        .then(tickets => {
            
            tickets.forEach(ticket => {
                const div = document.createElement("div");
                
                div.innerHTML = `
                <h3>${ticket.title}</h3>
                <p>${ticket.description}</p>
                `;
                ticketsContainer.appendChild(div);
            });
        });
    