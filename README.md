# ☕️ Macchiato

**Your personal API mock server, served fresh.**

---

Macchiato is a lightweight, multi-tenant API mock server designed to help developers, testers, and teams create, manage, and serve mock APIs easily and efficiently.  

Whether you’re prototyping frontend apps, testing integrations, or simulating backend behavior, Macchiato serves your mocks smoothly — just like a perfect macchiato.

---

## Features

- Multi-tenant support: define isolated mock apps per user or team  
- Dynamic mock routing based on subdomains (e.g. `user1.mockserver.com`)  
- Simple JSON or YAML mock definitions  
- Support for RESTful APIs with HTTP method, path, headers, and body matching  
- Serve static files and custom responses  
- Lightweight and easy to deploy locally or in the cloud  
- Optional web UI (coming soon!) for managing mocks visually  
- Built for speed, simplicity, and developer happiness

---

## Getting Started

### Prerequisites

- Docker & Docker Compose installed  
- Wildcard DNS configured for your domain (e.g. `*.mockserver.com`) pointing to your server IP  

---

### Running Macchiato locally with Docker Compose

```bash
git clone https://github.com/yourusername/macchiato.git
cd macchiato
docker compose up -d