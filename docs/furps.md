# OOA: FURPS Quality Model for dev.tirsvad.dk

## Metadata
| Key               | Value                             |
|-------------------|-----------------------------------|
| Id                | FURPS                             |
| crossReference    | BC<br>RISK                        |

## Change log
| Version | Date       | Description              | Author     |
|---------|------------|--------------------------|------------|
| 0001    | 2026-04-11 | Initial                  | Tirsvad    |

---

## FURPS Categories
### Functionality (F)
| ID         | Description                                                                                  | Cross Reference |
|------------|----------------------------------------------------------------------------------------------|-----------------|
| REQ-F-001  | The system must provide real-time project status updates to stakeholders.                    | BC, RSK-TECH-001 |
| REQ-F-002  | The system must display project milestones, timelines, and goals.                            | BC             |
| REQ-F-003  | The system must restrict access to private projects using authentication and authorization.  | BC, RSK-SEC-001 |
| REQ-F-004  | The system must show README, code coverage, and code documentation if available.             | BC             |
| REQ-F-005  | The system must allow users to comment on and like blog posts about project status.          | BC, RSK-BUS-001 |

### Usability (U)
| ID         | Description                                                                                  | Cross Reference |
|------------|----------------------------------------------------------------------------------------------|-----------------|
| REQ-U-001  | The platform must have an intuitive and user-friendly interface.                             | BC, RSK-BUS-001 |
| REQ-U-002  | Documentation and help must be easily accessible to users.                                   | BC, RSK-BUS-003 |
| REQ-U-003  | Stakeholders must be able to easily find contact information and project goals.              | BC             |

### Reliability (R)
| ID         | Description                                                                                  | Cross Reference |
|------------|----------------------------------------------------------------------------------------------|-----------------|
| REQ-R-001  | The system must provide accurate and up-to-date project data.                                | BC, RSK-TECH-001 |
| REQ-R-002  | The system must be available 99.5% of the time, excluding scheduled maintenance.             | BC, RSK-TECH-003 |
| REQ-R-003  | Automated data refresh and validation routines must be implemented.                          | BC, RSK-TECH-001 |
| REQ-R-004  | The system must implement regular backups, database replication, and disaster recovery plans to prevent data loss or corruption. | BC, RSK-TECH-004 |

### Performance (P)
| ID         | Description                                                                                  | Cross Reference |
|------------|----------------------------------------------------------------------------------------------|-----------------|
| REQ-P-001  | The system must provide fast response times for all user interactions.                       | BC, RSK-TECH-003 |
| REQ-P-002  | Backend queries must be optimized for real-time updates.                                     | BC, RSK-TECH-003 |
| REQ-P-003  | The system must scale to support increased user load without significant performance loss.   | BC, RSK-TECH-003, RSK-TECH-005 |

### Supportability (S)
| ID         | Description                                                                                  | Cross Reference |
|------------|----------------------------------------------------------------------------------------------|-----------------|
| REQ-S-001  | The system must be easy to maintain and support, with clear documentation.                   | BC, RSK-BUS-002 |
| REQ-S-002  | Diagnostic and monitoring capabilities must be provided.                                     | BC             |
| REQ-S-003  | The system must support regular updates and technology migrations.                           | BC, RSK-TECH-005 |
| REQ-S-004  | The system must use trusted sources, monitor dependencies, and apply timely updates to mitigate supply chain risks. | BC, RSK-TECH-006 |

### Design Constraints
| ID               | Description                                                      | Cross Reference |
|------------------|------------------------------------------------------------------|----------------|
| REQ-DC-001       | The system must be implemented using C#, .NET 10, Blazor, and PostgreSQL. | BC, RSK-TECH-005 |
| REQ-DC-002       | The system must use WebAPI for backend logic and database access.         | BC, RSK-TECH-002 |
| REQ-DC-003       | The system must enforce automated testing, code reviews, and continuous integration pipelines to ensure sufficient test coverage and quality assurance. | BC, RSK-QUAL-001 |

### Security
| ID               | Description                                                      | Cross Reference |
|------------------|------------------------------------------------------------------|----------------|
| REQ-SEC-001      | The system must enforce strong authentication and authorization.         | BC, RSK-SEC-001 |
| REQ-SEC-002      | Sensitive project information must be protected and encrypted.           | BC, RSK-SEC-001 |
| REQ-SEC-003      | The system must comply with GDPR and other relevant regulations.         | BC, RSK-SEC-002 |

### Scalability
| ID               | Description                                                      | Cross Reference |
|------------------|------------------------------------------------------------------|----------------|
| REQ-SCA-001      | The system must handle increased loads and growth without significant degradation. | BC, RSK-TECH-003 |

### Operability
| ID               | Description                                                      | Cross Reference |
|------------------|------------------------------------------------------------------|----------------|
| REQ-OPE-001      | The system must provide clear monitoring and logging capabilities.         | BC, RSK-TECH-001 |

### Legal and Ethical Compliance
| ID               | Description                                                      | Cross Reference |
|------------------|------------------------------------------------------------------|----------------|
| REQ-LEG-001      | The system must comply with legal and ethical standards, including data privacy and accessibility. | BC, RSK-SEC-002 |

