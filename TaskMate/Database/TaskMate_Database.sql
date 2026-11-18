-- TaskMate Database Script
-- Database: Oracle
-- Creates the task tables and inserts sample data.
-- Run this script in Oracle SQL Developer or SQL*Plus.

-- =========================================================
-- 1. CREATE TABLES
-- =========================================================

CREATE TABLE myday (
    taskname        VARCHAR2(20) PRIMARY KEY,
    taskdescription VARCHAR2(50),
    taskdate        DATE,
    taskstatus      VARCHAR2(20)
        CONSTRAINT chk_myday_status CHECK (taskstatus IN ('completed', 'pending'))
);

CREATE TABLE important (
    taskname        VARCHAR2(20) PRIMARY KEY,
    taskdescription VARCHAR2(50),
    taskdate        DATE,
    taskstatus      VARCHAR2(20)
        CONSTRAINT chk_important_status CHECK (taskstatus IN ('completed', 'pending'))
);

CREATE TABLE planned (
    taskname        VARCHAR2(20) PRIMARY KEY,
    taskdescription VARCHAR2(50),
    taskdate        DATE,
    taskstatus      VARCHAR2(20)
        CONSTRAINT chk_planned_status CHECK (taskstatus IN ('completed', 'pending'))
);

CREATE TABLE task (
    taskname        VARCHAR2(20) PRIMARY KEY,
    taskdescription VARCHAR2(50),
    taskdate        DATE,
    taskstatus      VARCHAR2(20)
        CONSTRAINT chk_task_status CHECK (taskstatus IN ('completed', 'pending'))
);

-- =========================================================
-- 2. INSERT SAMPLE DATA
-- =========================================================

INSERT ALL
    INTO myday (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Morning Workout', '30-minute cardio and stretching', DATE '2026-03-12', 'completed')
    INTO myday (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Team Sync', 'Daily stand-up meeting with the dev team', DATE '2026-03-12', 'completed')
    INTO myday (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Project Coding', 'Implement the new API authentication logic', DATE '2026-03-12', 'pending')
    INTO myday (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Grocery Run', 'Buy eggs, milk, and coffee beans', DATE '2026-03-12', 'completed')
    INTO myday (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Review PRs', 'Review pull requests on the GitHub repo', DATE '2026-03-12', 'pending')
    INTO myday (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Gym Session', 'Weight training - upper body focus', DATE '2026-03-12', 'pending')
    INTO myday (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Read Book', 'Read 20 pages of "Clean Code"', DATE '2026-03-12', 'completed')
SELECT * FROM dual;

INSERT ALL
    INTO important (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Tax Filing', 'Submit annual tax returns to revenue service', DATE '2026-04-15', 'pending')
    INTO important (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Server Migration', 'Move production DB to the new cloud cluster', DATE '2026-03-20', 'pending')
    INTO important (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Client Pitch', 'Present the final proposal to the Acme Corp', DATE '2026-03-14', 'completed')
    INTO important (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Lease Renewal', 'Sign and send the office lease agreement', DATE '2026-03-25', 'pending')
    INTO important (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Security Audit', 'Run vulnerability scan on the main gateway', DATE '2026-03-10', 'completed')
    INTO important (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Passport Update', 'Renew passport before the summer trip', DATE '2026-05-01', 'pending')
    INTO important (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Doctor Appt', 'Annual health checkup and blood work', DATE '2026-03-15', 'completed')
SELECT * FROM dual;

INSERT ALL
    INTO planned (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Quarterly Review', 'Analyze Q1 performance metrics', DATE '2026-03-31', 'pending')
    INTO planned (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Garden Mulching', 'Apply organic mulch to front flower beds', DATE '2026-04-05', 'pending')
    INTO planned (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('AWS Certification', 'Final exam for Solutions Architect', DATE '2026-05-12', 'pending')
    INTO planned (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Car Service', 'Oil change and tire rotation', DATE '2026-03-15', 'completed')
    INTO planned (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Backup Audit', 'Verify off-site data integrity', DATE '2026-04-01', 'pending')
    INTO planned (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Family Reunion', 'Book venue and send digital invites', DATE '2026-06-20', 'pending')
    INTO planned (taskname, taskdescription, taskdate, taskstatus)
        VALUES ('Yoga Retreat', 'Weekend wellness camp in the mountains', DATE '2026-03-08', 'completed')
SELECT * FROM dual;

COMMIT;

-- =========================================================
-- 3. VIEW TABLE DATA
-- =========================================================

SELECT * FROM myday;
SELECT * FROM important;
SELECT * FROM planned;
SELECT * FROM task;
