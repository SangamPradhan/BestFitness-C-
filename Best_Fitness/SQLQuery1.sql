create table new_member
(MID int not null IDENTITY (1,1) primary key,
Name varchar(100) not null,
Address varchar(100) not null,
Phone bigint not null,
Gender varchar(50),
JoinDate varchar(100) not null,
Membership int not null,
Current_Weight int not null,
Target_Weight int not null,
Sauna varchar(20),
Private_Coaching int
);
select * from new_member;