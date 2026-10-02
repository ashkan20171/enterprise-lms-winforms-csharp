# Stage 6 — Deterministic RTL/LTR Shell Fix

- Main window mirroring (`RightToLeftLayout`) is deliberately disabled.
- Sidebar position now uses physical coordinates, independent of WinForms RTL mirroring.
- Persian: sidebar is pinned to the physical right edge; top/content occupy the left remainder.
- English: sidebar is pinned to the physical left edge; top/content occupy the right remainder.
- Layout is recalculated on every Resize/Maximize.
- Child controls still receive recursive RTL/LTR alignment.
- This separates **window geometry** from **content direction**, avoiding the previous Dock/mirroring conflict.
