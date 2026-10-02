# Stage 9 – Localized Visual Experience

- Added separate Persian and English premium background assets.
- FA uses `Assets/background-fa.jpg`; EN uses `Assets/background-en.jpg`.
- Language switch rebuilds the shell/login and resolves the matching visual immediately.
- Deterministic sidebar placement remains: FA right, EN left.
- Recursive RTL/LTR control direction remains enabled.
- BackgroundPanel now invalidates its cached image when ImagePath changes.
- Assets are copied to build output by the .NET Framework 4.8 project.
