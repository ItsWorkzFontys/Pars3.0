# Pars3.0

Group project case: PARS (Attendance/Absence Registration System)

Author(s): Pieter Klijs (Breens Network) – [pieter.klijs@breensitsolutions.nl](mailto:pieter.klijs@breensitsolutions.nl)

Date: 7-7-2023

Breens Network

Whoever learns, gets a head start. Not only during school, but also afterwards: "life-long learning". Breens Network helps with this. As an IT organization, we specialize in the technological innovation of learning processes and the organization around them. Our customers, who are often active in education, healthcare and the public domain, can thus successfully shape their desired digital transformation. The technology used must measurably support the objectives of our customers, that is our guiding vision.

2,000,000 users - Breens Network serves more than two million students, faculty and staff in secondary education, secondary vocational education and higher education. They experience on a daily basis how our digital transformation contributes to:

* the effectiveness, output quality, (cost) efficiency and flexibility of their organization;

* optimize learning, in every possible way, and thus support the learning organization;

* achieve strategic, operational and personal objectives.

Context

Secondary and vocational schools must be able to provide the inspectorate with which pupils are present in the lessons. An application has been developed for this in the past, which is no longer up-to-date.

In the current situation, photos of the students are put on the screen, working with colors. Green is present. Orange is reported absent (for example, sick call or other reason for absence) and Red for those who should be present, but are not in class.

This application must read from a source system (student tracking system or schedule application) which students must be present in the lesson. This is possible in several ways. Some examples are:

The teacher manually processes the students present in an application (whether or not present). This takes a lot of time, which is deducted from the effective class time.

The student scans his/her school pass at a card reader at the door, whereby the status is processed directly in the application and the teacher only has to give approval on the status. This is costly much less administrative work.

Perhaps there are new possibilities that make it possible to make the administration automatic and to make this transparent for the right people (department leader, teacher, student, etc.).

The stored data must be compared with the schedule, after which reports can be made.

Existing work and available information

Develop a new version PARS 3.0, in which the basis is present to do the registration of the students who need to be present in the lesson in a way that takes the least time for the teacher and is still reliable, so that this data is stored with the schedule. In addition, overviews must be provided by

means of reporting or made available via a dashboard (e.g. PowerBI) in order to give the right people the right insights. Furthermore, this data must be able to be exchanged for inspection.

The solution must be suitable for several aspects of registration, so that the school can choose a method itself. (From a previous assignment, suggestions were made in an advisory report. We are open to new insights and techniques to be able to do these registrations and are happy to be informed.

An architecture must be designed, where the application is Multi-Tenant (platform), so that multiple customers/schools can be onboarded and the application can therefore be centrally managed and maintained. The application must be offered as SaaS, whereby it will run as a platform in a public cloud environment (MS Azure). Scalability, manageability are important in development.

In addition to the architecture, a registration method must be implemented, whereby it must be possible to add new registration techniques to the application/platform later.

The project goal

Build an application (MVP) that meets the set requirements and is fully available to the end user as a cloud application. For this, a good architecture must be set up, which is well secured. Think of access based on RBAC (Role Based Access Control) and SSO (Single Sign On) capabilities.

Unlocking data from source systems and target systems through standards.

The scope of the assignment can be determined in consultation.

Solution characteristics

The expected number of users varies by school. This can range from 1,500 to 25,000 users. Scalability and/or performance are therefore important.

The different roles that use the application are:

* Administration / reception – processing sick/absence reports

* Teacher – checking the overview and/or making changes manually

* Automated exchange with DUO

The link with the student tracking system and/or timetable system must be flexible, so that it can be switched quickly between systems (onboarding) and if the systems to be linked are changed, the historical data must not change. Being able to onboard a customer quickly is a prerequisite, whereby the application must support multi-tenancy and be offered as SaaS to the customer.

It only needs to be available in Dutch. The stored data must be GDPR compliant and must comply with Dutch laws and regulations.

The delivery must contain the following components:

* Presentation

* Transfer to developers Breens Network

* Documented

* Be maintainable for the future and secure
