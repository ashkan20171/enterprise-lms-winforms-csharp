# Stage 8 — Background Experience + Compile Fix

- Fixed CS0019 in Student 360: Student objects are no longer combined with boolean `||`.
- Added an internal `Assets/lms-background.png` background asset.
- Added reusable `BackgroundPanel` with center-crop rendering and dark overlay for readability.
- Applied the visual background to the main workspace and login experience.
- Preserved deterministic FA/RTL (sidebar right) and EN/LTR (sidebar left) shell behavior.
- Asset is copied to the build output by MSBuild, so the app does not depend on an external absolute path.
