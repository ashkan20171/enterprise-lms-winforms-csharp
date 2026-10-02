# 🎓 Enterprise LMS — C# / .NET Learning Management System

> A portfolio-grade, bilingual **Learning Management System (LMS)** built with **C# and .NET Framework**, focused on clean architecture, role-based workflows, learning analytics, reporting, internationalization, and a polished desktop user experience.

This project demonstrates how a traditional Windows desktop application can be designed with modern software-engineering practices and an enterprise-oriented architecture.

---

## ✨ Overview

**Enterprise LMS** is a desktop learning-management platform designed for managing students, instructors, courses, assessments, attendance, progress, reports, notifications, and administrative workflows.

The project goes beyond basic CRUD operations by focusing on:

- Clean and maintainable C# code
- Separation of concerns
- Role-based user experiences
- Learning analytics
- Student progress and risk insights
- Course and instructor workspaces
- Reporting and data export
- Full bilingual UI architecture
- True RTL/LTR layout switching
- AI-ready architecture
- Modern WinForms UI/UX

The goal is to demonstrate the engineering decisions required to build a maintainable business application rather than only a collection of forms.

---

## 🚀 Key Features

### 📊 Management Dashboard

A centralized dashboard provides an overview of important LMS information and operational indicators.

It includes:

- Student statistics
- Course statistics
- Instructor information
- Enrollment insights
- Learning progress
- Assessment overview
- Operational KPIs
- Recent activities
- Quick actions

The dashboard is designed to help users understand the current state of the learning environment at a glance.

---

## 👨‍🎓 Student Management

Manage the complete student lifecycle through structured workflows.

Features include:

- Student profiles
- Student search and filtering
- Enrollment information
- Learning progress
- Assessment history
- Attendance information
- Student activity timeline
- Performance indicators
- Risk and progress analysis

### Student 360°

The **Student 360°** workspace brings important student information into a single view.

It is designed to help instructors and administrators quickly understand:

- Academic progress
- Course participation
- Assessment performance
- Attendance
- Potential risk indicators
- Recent activities

---

## 📚 Course Management

Courses can be managed through dedicated operational and analytical views.

Features include:

- Course information
- Instructor assignment
- Student enrollment
- Course status
- Progress tracking
- Assessment overview
- Search and filtering

### Course 360°

The Course 360° workspace provides a consolidated view of a course and its related information.

This makes it easier to inspect course performance without navigating through multiple unrelated screens.

---

## 👨‍🏫 Instructor Workspace

A dedicated workspace is available for instructors.

It focuses on the information instructors need most frequently, including:

- Assigned courses
- Students
- Learning progress
- Assessments
- Attendance
- Student risk indicators
- Course performance

The navigation system can adapt according to the authenticated user's role.

---

## 📝 Assessments & Learning Progress

The system includes workflows for managing and reviewing educational performance.

Supported concepts include:

- Assessments
- Assignments
- Grades
- Student progress
- Course progress
- Performance indicators
- Learning status

The architecture is designed so additional assessment types can be introduced without tightly coupling them to the user interface.

---

## ⚠️ Student Risk & Progress Center

The Risk & Progress Center helps identify students who may require additional attention.

The system can combine available learning information to provide understandable indicators related to:

- Low progress
- Assessment performance
- Participation
- Attendance
- Learning activity

The goal is not simply to display raw records, but to transform operational LMS data into useful information.

---

## 🤖 AI-Ready Architecture

The project is designed to support intelligent LMS capabilities without making the application dependent on a specific AI provider.

The architecture can be extended with capabilities such as:

- Student progress summaries
- Course summaries
- Risk explanations
- Instructor recommendations
- Smart search
- Learning insights
- Administrative assistance
- AI-powered LMS Copilot

A provider abstraction can be used to integrate services such as cloud-hosted or OpenAI-compatible language models while keeping the core LMS independent from a specific vendor.

### Local Insight Engine

The architecture also supports deterministic local insights.

This is important because the application can continue providing useful analytics even when:

- No AI API key is configured
- Internet access is unavailable
- External AI services are disabled

This approach keeps AI an enhancement rather than a hard runtime dependency.

---

## 🔎 Global Search

A centralized search experience allows users to find relevant LMS information more efficiently.

Search can cover concepts such as:

- Students
- Courses
- Instructors
- Assessments
- Learning records

The goal is to reduce unnecessary navigation in larger datasets.

---

## 📈 Analytics & Reporting

The LMS includes reporting-oriented workflows for turning application data into useful information.

Features include:

- Dashboard KPIs
- Student progress analysis
- Course statistics
- Learning performance indicators
- Operational reports
- Search and filtering
- Report Center
- CSV export

CSV output uses **UTF-8**, allowing Persian content to be exported correctly for further analysis.

---

## 🔐 Role-Based Access Control

The application follows a role-aware approach rather than exposing every function to every user.

The architecture supports roles such as:

- Administrator
- Instructor
- Standard User

Navigation and administrative functionality can be restricted according to the current role.

Examples include limiting access to:

- User administration
- Security settings
- Audit information
- Administrative operations

This improves both usability and separation of responsibilities.

---

## 🛡️ Security & Audit

Enterprise applications need more than authentication.

The project therefore includes architecture for:

- Role-based authorization
- Security-oriented administration
- Audit information
- User activity visibility
- Controlled navigation
- Separation of privileged functionality

The security model can be extended further as the application evolves.

---

## 🌍 Complete Persian / English Experience

Internationalization is a core architectural requirement of the project rather than a cosmetic translation layer.

### 🇮🇷 Persian Mode

When Persian is selected:

- The complete application switches to **RTL**
- Sidebar moves physically to the **right**
- Forms follow RTL direction
- Data grids follow RTL direction
- Inputs and labels follow RTL conventions
- Navigation follows RTL conventions
- Persian localization is applied
- Persian-specific visual assets can be displayed

### 🇬🇧 English Mode

When English is selected:

- The complete application switches to **LTR**
- Sidebar moves physically to the **left**
- Forms follow LTR direction
- Data grids follow LTR direction
- Navigation follows LTR conventions
- English localization is applied
- English-specific visual assets can be displayed

The application uses centralized localization and layout-direction management so newly opened and dynamically generated controls follow the active language.

This was implemented specifically to address one of the more challenging aspects of building genuinely bilingual Windows Forms applications.

---

## 🎨 UI / UX

The interface was designed to move beyond the appearance of a traditional WinForms utility.

The UI focuses on:

- Clear visual hierarchy
- Dashboard-oriented navigation
- Consistent spacing
- Modern cards
- Readable typography
- Context-aware navigation
- Accessible contrast
- Purposeful use of color
- Bilingual visual consistency
- Dedicated Persian and English backgrounds

The objective is to combine the reliability of desktop software with a more contemporary product experience.

---

## 🏗️ Architecture

The solution follows separation-of-concerns principles to keep business logic independent from presentation code where practical.

```text
AshkanLMS
│
├── Application
│   ├── Services
│   ├── Workflows
│   └── Application Logic
│
├── Domain
│   ├── Entities
│   ├── Models
│   └── Business Concepts
│
├── Infrastructure
│   ├── Data Access
│   ├── Persistence
│   └── External Integrations
│
├── Localization
│   ├── Persian Resources
│   ├── English Resources
│   └── Layout Direction
│
├── UI
│   ├── Forms
│   ├── Controls
│   ├── Dashboard
│   └── Workspaces
│
└── Assets
    ├── Persian Background
    └── English Background
```

The architecture is intended to make future additions easier without turning the main forms into large collections of tightly coupled event handlers.

---

## 🧠 Engineering Highlights

Some of the more interesting engineering challenges addressed in this project include:

**True bidirectional UI**

Supporting Persian and English requires more than translating labels. Physical navigation placement, control direction, dynamically generated components and layouts must also change correctly.

**Centralized localization**

Localization responsibilities are kept centralized instead of scattering language checks throughout individual forms.

**Dynamic layout management**

Runtime-created controls also receive the correct RTL/LTR configuration.

**Role-aware navigation**

Navigation adapts according to user responsibilities instead of presenting identical functionality to every user.

**Analytics-oriented design**

Operational data is transformed into progress, risk and management insights.

**AI-ready design**

AI integration is treated as an optional architectural capability rather than tightly coupling the application to a particular API.

**Maintainability**

New functionality is organized into focused services and components rather than continuously expanding a single form.

---

## 🛠️ Technology Stack

| Area | Technology |
|---|---|
| Language | C# |
| Platform | .NET Framework 4.8 |
| UI | Windows Forms |
| IDE | Visual Studio |
| Architecture | Layered / Separation of Concerns |
| Localization | Custom FA/EN localization |
| Layout | Dynamic RTL / LTR |
| Authorization | Role-Based Access Control |
| Reporting | Reporting + UTF-8 CSV Export |
| Analytics | LMS Progress & Risk Insights |
| AI | Provider-ready architecture |
| Source Control | Git / GitHub |

---

## 💡 Design Principles

The project follows several engineering principles:

- Separation of Concerns
- Single Responsibility
- DRY where appropriate
- Explicit domain models
- Reusable UI components
- Centralized localization
- Centralized layout management
- Role-aware workflows
- Maintainable service boundaries
- Defensive error handling
- Extensibility over unnecessary coupling

---

## 🖥️ Getting Started

### Requirements

- Windows 10/11
- Visual Studio 2022
- .NET Framework 4.8 Developer Pack

### Run the application

Clone the repository:

```bash
git clone https://github.com/YOUR-USERNAME/enterprise-lms-winforms-csharp.git
```

Open:

```text
AshkanLMS.sln
```

Then:

1. Restore/build the solution.
2. Select `AshkanLMS` as the startup project.
3. Press `F5` or choose **Start**.

No external AI service is required for the core application.

---

## 📸 Screenshots

> Screenshots and product walkthrough images can be added here.

Recommended repository screenshots:

```text
docs/screenshots/
├── login-en.png
├── login-fa.png
├── dashboard-en.png
├── dashboard-fa.png
├── student-360.png
├── course-360.png
├── analytics.png
├── reports.png
└── security.png
```

Showing both Persian RTL and English LTR modes is particularly useful because bidirectional UI engineering is one of the project's key technical features.

---

## 🗺️ Roadmap

Planned and extensible areas include:

- SQL Server persistence
- Repository / Unit of Work implementation
- Advanced authentication
- Fine-grained permissions
- Certificate management
- Advanced assessment engine
- Additional analytics
- Notification workflows
- Backup and restore
- PDF/Excel reporting
- REST API integration
- Cloud synchronization
- AI-assisted instructor workflows
- Semantic LMS search
- Automated tests
- CI/CD pipeline
- Installer and deployment pipeline

---

## 🎯 Why I Built This Project

I built this project to demonstrate more than familiarity with C# syntax or Windows Forms.

My goal was to explore the engineering challenges behind a realistic business application:

- How should features be separated as an application grows?
- How can role-specific workflows remain manageable?
- How can a desktop application provide a modern user experience?
- How can Persian RTL and English LTR coexist reliably?
- How can analytics turn raw records into useful information?
- How can AI capabilities be introduced without coupling the entire application to an external provider?
- How can an application remain understandable and maintainable as functionality increases?

The project continues to evolve as I improve its architecture, reliability, testing strategy and product experience.

---

## 👨‍💻 Author

**Ashkan Motaei**

Software Developer focused on:

- C# / .NET
- Software Engineering
- Business Applications
- SQL & Data-driven Systems
- Front-end Development
- Enterprise Software
- Clean and Maintainable Code

GitHub: `@ashkan20171`

---

## 🤝 Feedback

Technical feedback, architecture discussions and improvement suggestions are welcome.

If you are reviewing this project as an engineer, recruiter or hiring manager, I would particularly appreciate feedback regarding:

- Architecture
- Maintainability
- Desktop UX
- Internationalization
- Application workflows
- Testing strategy
- Enterprise-readiness

---

## ⭐ Repository

If you find the architecture or implementation interesting, feel free to explore the source code and project structure.

**Suggested repository name**

`enterprise-lms-winforms-csharp`

**Suggested GitHub description**

> Enterprise-grade bilingual LMS built with C#/.NET Framework, featuring RBAC, learning analytics, student risk insights, reporting, AI-ready architecture, and full Persian RTL / English LTR support.

---

### Built with C#, thoughtful architecture, and a focus on maintainable enterprise software.
