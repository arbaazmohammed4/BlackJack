use Assignment

/*CREATE TABLE EMPLOYEE
(EMPNO INT PRIMARY KEY,
ENAME VARCHAR(40) NOT NULL,
JOB VARCHAR(20) NOT NULL,
MGR FLOAT(10) ,
HIREDATE VARCHAR(10) NOT NULL,
SAL FLOAT(10) NOT NULL,
COMM FLOAT(10),
DEPTNO INT FOREIGN KEY REFERENCES DEPT(DEPTNO))*/

/*INSERT INTO EMPLOYEE VALUES
(7521 ,'WARD','SALESMAN' , 7698   , '22-FEB-81', 1250     ,500 ,   30),
(7566 ,'JONES' ,'MANAGER' ,7839 ,'02-APR-81',2975,NULL,20),
(7654, 'MARTIN','SALESMAN',7698 ,'28-SEP-81', 1250, 1400,30),
(7698, 'BLAKE ','MANAGER',7839,'01-MAY-81',2850,NULL,30),
(7782, 'CLARK ','MANAGER',7839,'09-JUN-81',2450,NULL,10),
(7788, 'SCOTT' ,'ANALYST',7566,'19-APR-87',3000,NULL,20),
(7839, 'KING'  ,'PRESIDENT ',NULL,'17-NOV-81',5000 ,NULL,10),
(7844, 'TURNER','SALESMAN',7698,'08-SEP-81',1500 ,0,30),
(7876, 'ADAMS' ,'CLERK ',7788,'23-MAY-87',1100 ,NULL,20),
(7900, 'JAMES' ,'CLERK ',7698,'03-DEC-81',950 ,NULL,30),
(7902, 'FORD'  ,'ANALYST',7566,'03-DEC-81',3000,NULL,20),
(7934, 'MILLER','CLERK',7782,'23-JAN-82',1300,NULL,10)*/


--SELECT * FROM EMPLOYEE


--SELECT * FROM DEPT

-------------------------------------------------------------------------------
--1. List all employees whose name begins with 'A'.


SELECT ENAME
FROM EMPLOYEE
WHERE ENAME LIKE 'A%'

----------------------------------------------------------------------

--2. Select all those employees who don't have a manager. 

SELECT *
FROM EMPLOYEE
WHERE MGR IS NULL


----------------------------------------------------------------------------------------------------------------
--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 

SELECT ENAME, EMPNO, SAL
FROM EMPLOYEE
WHERE SAL BETWEEN 1200 AND 1400


-----------------------------------------------------------------------------------------------------------------
--4. Give all the employees in the RESEARCH department a 10% pay rise.
--Verify that this has been done by listing all their details before and after the rise.


SELECT *, SAL AS 'OLD SAL',SAL+SAL*10/100 AS 'NEW SAL' 
FROM EMPLOYEE E, DEPT D
WHERE E.DEPTNO = D.DEPTNO AND DNAME = 'RESEARCH'

------------------------------------------------------------------------------------------------------------------

--5. Find the number of CLERKS employed. Give it a descriptive heading. 

SELECT COUNT(*) AS 'NUMBER OF CLERK EMP'
FROM EMPLOYEE
WHERE JOB = 'CLERK'

-----------------------------------------------------------------------------------------------------------------

--6. Find the average salary for each job type and the number of people employed in each job. 

SELECT AVG(SAL) AS 'AVG SAL', JOB, COUNT(JOB) AS 'NO OF EMP IN EACH JOB'
FROM EMPLOYEE
GROUP BY JOB

-------------------------------------------------------------------------------------------------------------------

--7. List the employees with the lowest and highest salary.

SELECT *
FROM EMPLOYEE
WHERE SAL = (SELECT MAX(SAL) FROM EMPLOYEE ) OR SAL = (SELECT MIN(SAL) FROM EMPLOYEE)


-------------------------------------------------------------------------------------------------------------------

--8. List full details of departments that don't have any employees. 

SELECT *
FROM DEPT 
WHERE DEPTNO NOT IN (SELECT DEPTNO FROM EMPLOYEE) 

-------------------------------------------------------------------------------------------------------------------

--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20.
--   Sort the answer by ascending order of name. 

SELECT ENAME, SAL, JOB, DEPTNO
FROM EMPLOYEE
WHERE JOB = 'ANALYST' AND SAL> 1200 AND DEPTNO = 20
ORDER BY ENAME ASC

-------------------------------------------------------------------------------------------------------------------

--10. For each department, list its name and number together 
--    with the total salary paid to employees in that department. 

SELECT D.Dname, D.DEPTNO, sum(SAL) as 'Total sal'
FROM DEPT D, EMPLOYEE E
WHERE D.DEPTNO=E.DEPTNO
GROUP BY D.DEPTNO, Dname

--------------------------------------------------------------------------------------------------------------------
--11. Find out salary of both MILLER and SMITH.

select ENAME, SAL
FROM EMPLOYEE
WHERE ENAME IN ('MILLER','SMITH')

-------------------------------------------------------------------------------------------------------------------

--12. Find out the names of the employees whose name begin with ‘A’ or ‘M’. 

SELECT ENAME 
FROM EMPLOYEE
WHERE ENAME LIKE 'A%' OR ENAME LIKE 'M%' 

------------------------------------------------------------------------------------------------------------------

--13. Compute yearly salary of SMITH. 

SELECT ENAME, SAL, SAL*12 AS 'ANNUAL SAL'
FROM EMPLOYEE
WHERE ENAME = 'SMITH'

------------------------------------------------------------------------------------------------------------------

--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850. 

SELECT ENAME , SAL 
FROM EMPLOYEE
WHERE SAL NOT BETWEEN 1500 AND 2850

----------------------------------END OF SQL ASSIGNMENT 1-----------------------------------------------------------