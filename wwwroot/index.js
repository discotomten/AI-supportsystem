const ticketsContainer = document.getElementById('tickets');
const statsContainer = document.getElementById('stats');

const statusText = {
    Open: 'Öppet',
    InProgress: 'Pågående',
    Closed: 'Stängt',
    0: 'Öppet',
    1: 'Pågående',
    2: 'Stängt',
};

const priorityText = {
    Low: 'Låg',
    Medium: 'Mellan',
    High: 'Hög',
    0: 'Låg',
    1: 'Mellan',
    2: 'Hög',
};

const sentimentText = {
    Positive: 'Positiv',
    Neutral: 'Neutral',
    Negative: 'Negativ',
    Mixed: 'Blandad',
};

function readable(map, value) {
    if (value === null || value === undefined) return '-';
    return map[value] ?? String(value);
}

function formatDate(value) {
    if (!value) return '-';
    const d = new Date(value);
    if (isNaN(d)) return String(value);
    return d.toLocaleString('sv-SE');
}

function keywordList(keywords) {
    if (!keywords || keywords.length === 0) return '-';
    return keywords.map(k => typeof k === 'string' ? k : (k.text ?? k.Text ?? '')).filter(Boolean).join(', ');
}

function isStatus(ticket, name, num) {
    return ticket.status === name || ticket.status === num;
}

function normStatus(v) {
    if (v === 'Open' || v === 0) return 'open';
    if (v === 'InProgress' || v === 1) return 'inprogress';
    if (v === 'Closed' || v === 2) return 'closed';
    return 'open';
}

function normPriority(v) {
    if (v === 'Low' || v === 0) return 'low';
    if (v === 'Medium' || v === 1) return 'medium';
    if (v === 'High' || v === 2) return 'high';
    return 'low';
}

function normSentiment(v) {
    if (typeof v === 'number') return String(v);
    return String(v ?? '').toLowerCase();
}

function renderStats(tickets) {
    if (!statsContainer) return;
    const status = { open: 0, inprogress: 0, closed: 0 };
    const priority = { low: 0, medium: 0, high: 0 };
    const sentiment = { positive: 0, neutral: 0, negative: 0, mixed: 0 };

    tickets.forEach(t => {
        const s = normStatus(t.status);
        if (s in status) status[s]++;

        const p = normPriority(t.priority);
        if (p in priority) priority[p]++;

        const se = normSentiment(t.sentiment);
        if (se in sentiment) sentiment[se]++;
    });

    const total = tickets.length;

    statsContainer.innerHTML = `
        <h3>Översikt – ${total} ärenden totalt</h3>
        <div class="stats-grid">
            <div class="stat-group">
                <h4>Status</h4>
                <span class="badge status-open">Öppet: ${status.open}</span>
                <span class="badge status-inprogress">Pågående: ${status.inprogress}</span>
                <span class="badge status-closed">Stängt: ${status.closed}</span>
            </div>
            <div class="stat-group">
                <h4>Prioritet</h4>
                <span class="badge priority-low">Låg: ${priority.low}</span>
                <span class="badge priority-medium">Mellan: ${priority.medium}</span>
                <span class="badge priority-high">Hög: ${priority.high}</span>
            </div>
            <div class="stat-group">
                <h4>Känsla</h4>
                <span class="badge sentiment-positive">Positiv: ${sentiment.positive}</span>
                <span class="badge sentiment-neutral">Neutral: ${sentiment.neutral}</span>
                <span class="badge sentiment-negative">Negativ: ${sentiment.negative}</span>
                <span class="badge sentiment-mixed">Blandad: ${sentiment.mixed}</span>
            </div>
        </div>
    `;
}

function loadTickets() {
    fetch('/api/tickets')
        .then(response => response.json())
        .then(tickets => {
            ticketsContainer.innerHTML = '';
            renderStats(tickets);

            tickets.forEach(ticket => {
                const div = document.createElement('div');
                div.className = 'ticket';

                const closed = isStatus(ticket, 'Closed', 2);
                const open = isStatus(ticket, 'Open', 0);

                div.innerHTML = `
                    <h3>${ticket.title}</h3>
                    <p>${ticket.description}</p>
                    <p>Status: <span class="badge status-${normStatus(ticket.status)}">${readable(statusText, ticket.status)}</span></p>
                    <p>Prioritet: <span class="badge priority-${normPriority(ticket.priority)}">${readable(priorityText, ticket.priority)}</span></p>
                    <p class="meta">Känsla: ${readable(sentimentText, ticket.sentiment)}</p>
                    <p class="meta">Nyckelord: ${keywordList(ticket.keywords)}</p>
                    <p class="meta">Skapad: ${formatDate(ticket.createdAt)}</p>
                    <p class="meta">Stängd: ${formatDate(ticket.closedAt)}</p>
                    <button data-id="${ticket.id}" class="claim-btn" ${open ? '' : 'disabled'}>
                        Ta ärende
                    </button>
                    <button data-id="${ticket.id}" class="close-btn" ${closed ? 'disabled' : ''}>
                        Stäng ärende
                    </button>
                `;

                ticketsContainer.appendChild(div);
            });

            document.querySelectorAll('.close-btn').forEach(button => {
                button.addEventListener('click', () => closeTicket(button.dataset.id));
            });

            document.querySelectorAll('.claim-btn').forEach(button => {
                button.addEventListener('click', () => claimTicket(button.dataset.id));
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

function claimTicket(id) {
    fetch(`/api/tickets/${id}/claim`, { method: 'PUT' })
        .then(response => {
            if (response.ok) {
                loadTickets();
            } else {
                alert('Kunde inte ta ärendet.');
            }
        });
}

loadTickets();
