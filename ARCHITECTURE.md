# AshkanLMS Architecture

## Layers
- **UI**: WinForms views and navigation shell.
- **Services**: use-case/data boundary; Stage 1 uses deterministic demo data.
- **Models**: domain-facing DTO/entities.
- **Core**: session, visual theme and cross-cutting application state.

## Clean-code decisions
- UI palette and typography are centralized in `Theme`.
- Authentication/data logic is not embedded in dashboard rendering.
- Navigation is module-oriented and extensible.
- No third-party package is required to open the solution.

## Product modules planned
Learning catalog, cohorts/classes, instructors, learners, enrollment, attendance, assignments, exams/question bank, grading/transcripts, certificates, notifications, analytics, RBAC, audit, settings, backup/import/export and localization.
