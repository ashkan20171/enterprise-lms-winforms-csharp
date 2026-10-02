# AshkanLMS Stage 4

## Global direction fix
- Added `LayoutDirectionManager` as the single RTL/LTR authority.
- Recursively applies direction to every nested WinForms control.
- Persian: navigation docked right, forms/dialogs RTL, labels/buttons/text inputs/grids right aligned.
- English: navigation docked left, forms/dialogs LTR, controls and grids left aligned.
- `RightToLeftLayout` is applied at Form level.
- DataGridView headers and cells switch alignment.
- FlowLayoutPanel flow switches direction.
- Login language switch keeps typed username/password while rebuilding localized UI.

This stage intentionally fixes direction at the layout layer rather than treating RTL as text translation only.
