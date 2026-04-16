# OOA: Business Case for Showing project status at dev.tirsvad.dk

## Metadata
| Key            | Value                             |
|------------------|-----------------------------------|
| Id               | BC                                |
| crossReference   | glossary                          |
| ProductOwnerLanguage | English - Academic IT         |

## Version History
| Version | Date       | Description              | Author     |
|---------|------------|--------------------------|---------------|
| 0001    | 2026-03-29 | Initial                  | Tirsvad       |

## Executive Summary
dev.tirsvad.dk is a platform that provides real-time project status updates to stakeholders. The business case for showing project status on this platform is to enhance transparency, improve communication, and facilitate better decision-making among project teams and stakeholders.

## Problem Statement
The current lack of visibility into project status, documentation, and test results on dev.tirsvad.dk leads to reduced transparency and inefficient communication among stakeholders. Project teams and decision-makers are unable to easily access up-to-date information, which can result in delays, misunderstandings, and suboptimal decisions. There is a need for a centralized solution that provides real-time access to essential project artifacts such as the README file, code coverage reports, and code documentation.

## Objectives

**Technical Requirements (from Product Owner):**
- Use C# as the programming language
- Use .NET 10 as the framework
- Use Blazor for the frontend
- Use WebAPI for the Database access and backend logic
- Use PostgreSQL as the database

**Business Requirements:**
1. Show our goals and contact information for stakeholders to reach out with questions or feedback
2. Show our project milestones and timelines
3. Use authentication and authorization to restrict access. Only authorized users can view private projects, while public projects are accessible to everyone.
4. Show our project risks and mitigation strategies
5. Show our quality criteria
    a. Explain how we use them and why we have them
6. Show our copilot's Agents, Instructions, and Prompts
    a. Explain how to use them and why we have them
7. Show the project's README file
8. Show the project's code coverage report if it exists
9. Show the project's code documentation if it exists (doxygen)
10. Have a blog post about the project status page
    a. User can comment on the blog post and ask questions
    b. User can like the blog post to show appreciation for the work done

**Phases:**
- First phase:
    1. Set up the project structure and development environment using C# and CI/CD, .NET 10, Blazor, WebAPI, and PostgreSQL. This includes creating the necessary repositories, configuring the database, and establishing the development workflow.
    1. Implement Authentication and Authorization using Asp Identity for WebAPI.
    1. Show quality criteria, including explanations of their use and importance.
    1. Show copilot's Agents, Instructions, and Prompts, along with explanations
    1. Show our goals and contact information for stakeholders to reach out with questions or feedback.
- Second phase:
    1. Develop WebAPI endpoints to retrieve project status information, including README files, code coverage reports, and code documentation.
    1. Develop backend logic to fetch and process project data from the database and other sources.
    1. Implement the frontend using Blazor to display project status information in a user-friendly manner.
- Third phase:
    1. Implement the blog post feature, allowing users to create, comment on, and like blog posts related to project status.
    1. Integrate the blog post feature with the existing project status platform.
    1. Conduct user testing and gather feedback to refine the user experience and ensure the platform meets stakeholder needs.

## Options and Alternatives (0-scenario, 1-scenario, 2-scenario)

## Cost Benefit Analysis
| Option | Cost | Benefit |
|--------|------|---------|
| 0-scenario | $0 | No change, status quo maintained |
| 1-scenario | $X | Improved transparency and communication |
| 2-scenario | $Y | Enhanced decision-making and stakeholder engagement |


## Risks and Mitigations

| Risk                                                                 | Mitigation                                                                                 |
|----------------------------------------------------------------------|--------------------------------------------------------------------------------------------|
| Incomplete or outdated project data shown to stakeholders            | Implement automated data refresh, validation routines, and regular audits                  |
| Security vulnerabilities exposing sensitive project information      | Enforce strong authentication, authorization, encryption, and regular security reviews     |
| Low user adoption of the status platform                             | Engage stakeholders early, provide training, gather feedback, and promote platform benefits|
| Integration issues with existing tools or data sources               | Use standard APIs, modular architecture, and thorough integration and regression testing   |
| Performance bottlenecks with real-time updates                       | Optimize backend queries, use caching, monitor system performance, and scale infrastructure|
| Lack of clear ownership for maintaining project status information   | Assign responsibility, document maintenance processes, and set up escalation procedures    |
| Data loss or corruption                                              | Implement regular backups, database replication, and disaster recovery plans               |
| Compliance or privacy violations                                     | Adhere to GDPR and other regulations, conduct regular compliance reviews                   |
| Insufficient test coverage or quality assurance                      | Enforce automated testing, code reviews, and continuous integration pipelines              |
| Technology stack obsolescence                                        | Monitor technology trends, plan for regular updates and migrations                         |
| Dependency vulnerabilities or supply chain risks                     | Use trusted sources, monitor dependencies, and apply timely updates                        |
| User feedback not addressed promptly                                 | Establish feedback channels and a process for timely review and action                     |


## Timeline

Assumption: One developer, 10 hours per week.

| Phase        | Estimated Duration | Key Activities                                                                 |
|--------------|-------------------|-------------------------------------------------------------------------------|
| Phase 1      | 4 weeks           | Project setup, CI/CD, database config, authentication/authorization, quality criteria, Copilot info, goals/contact |
| Phase 2      | 5 weeks           | WebAPI endpoints, backend logic, Blazor frontend for project status            |
| Phase 3      | 4 weeks           | Blog post feature, integration, user testing, feedback, refinements            |
| **Total**    | **13 weeks**      |                                                                               |

## Success Criteria

- Stakeholders can view real-time project status, documentation, and test results on dev.tirsvad.dk
- Only authorized users can access private project information; public projects are accessible to all
- Project goals, milestones, risks, quality criteria, and Copilot agent information are clearly displayed
- README, code coverage, and code documentation are accessible if available
- Blog post feature allows users to comment and like posts about project status
- Platform is secure, up-to-date, and feedback from stakeholders is addressed
