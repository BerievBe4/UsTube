use ToDoList;

create table VideoFile(
Id int(11) NOT NULL AUTO_INCREMENT,
Name varchar(50),
ContentType nvarchar(200),
Data longblob,
Thumbnail longblob,
CategoryId int(11) not null default 1,
foreign key (CategoryId) references VideoCategory(Id),
PRIMARY KEY (Id)
) AUTO_INCREMENT=1;

Alter table VideoFile add column Owner int(11) default 1;

ALTER TABLE VideoFile
ADD FOREIGN KEY (Owner) REFERENCES UserModel(Id);

delete from userModel;
delete from userModel;
update userModel set roleId = 2 where login = 'test';

create table VideoCategory(
	Id int(11) NOT NULL AUTO_INCREMENT,
	Category text,
    PRIMARY KEY (Id)
) AUTO_INCREMENT=1;

INSERT INTO `todolist`.`videocategory`
(`Category`)
VALUES
('Education');


alter table VideoFile add column CategoryId int(11) NOT NULL default 1;
ALTER TABLE VideoFile 
ADD CONSTRAINT fk_2
FOREIGN KEY (CategoryId) 
REFERENCES VideoCategory(Id);

delete from VideoFile;

alter table VideoFile add column Thumbnail longblob;

create table UserComment(
Id int(11) NOT NULL AUTO_INCREMENT,
RootId int(11) NOT NULL,
VideoId int(11) NOT NULL,
UserId int(11) NOT NULL,
Text varchar(200),
CreationDate datetime NOT NULL DEFAULT NOW(),
foreign key (VideoId) references VideoFile(Id),
foreign key (UserId) references UserModel(Id),
PRIMARY KEY (Id)
) AUTO_INCREMENT=1;

alter table UserComment add column CreationDate datetime NOT NULL DEFAULT NOW();

create table CommentLike(
Id int(11) NOT NULL AUTO_INCREMENT,
UserId int(11) NOT NULL,
CommentId int(11) NOT NULL,
foreign key (UserId) references UserModel(Id),
foreign key (CommentId) references UserComment(Id) ON DELETE CASCADE,
PRIMARY KEY (Id)
) AUTO_INCREMENT=1;

create table VideoLike(
Id int(11) NOT NULL AUTO_INCREMENT,
UserId int(11) NOT NULL,
VideoId int(11) NOT NULL,
foreign key (UserId) references UserModel(Id),
foreign key (VideoId) references VideoFile(Id) ON DELETE CASCADE,
PRIMARY KEY (Id)
) AUTO_INCREMENT=1;

create table UserModel(
	Id int(11) NOT NULL AUTO_INCREMENT,
	Login text,
    Password text,
    RoleId int(11) NOT NULL default 1,
    foreign key (RoleId) references UserRole(Id),
	PRIMARY KEY (Id)
) AUTO_INCREMENT=1;

alter table userModel add column RoleId int(11) NOT NULL default 1;
ALTER TABLE userModel 
ADD CONSTRAINT fk_1 
FOREIGN KEY (RoleId) 
REFERENCES UserRole(Id);

create table UserRole(
	Id int(11) NOT NULL AUTO_INCREMENT,
	Role text,
    PRIMARY KEY (Id)
) AUTO_INCREMENT=1;



DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `AddOrEditTask`(
	Id int(11),
    UserId int(11),
	TaskName text,
    TaskDescription text)
BEGIN
IF Id = 0 THEN
INSERT INTO `todolist`.`task`
(`UserId`,
`TaskName`,
`TaskDescription`)
VALUES
(UserId, TaskName, TaskDescription);
ELSE
UPDATE Task
SET
Task.UserId = UserId,
Task.TaskName = TaskName,
Task.TaskDescription = TaskDescription
WHERE Task.Id = Id;
END IF;
END;

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAllTasks`(Id int)
BEGIN
	select * from Task where UserId = Id;
END;

Update TaskModel set TaskModel.UserId = 1, TaskModel.TaskName = 'Новое имя', TaskModel.TaskDescription = 'Новое описание' WHERE TaskModel.Id = 1

DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteTask`(Id int)
BEGIN
	delete from Task where Task.Id = Id;
END;

CALL `todolist`.`AddOrEditTask`(0, 1, 'Test 4', 'TestDescr');
CALL `todolist`.`GetAllTasks`(1);
CALL `todolist`.`DeleteTask`(1);

UPDATE Task
SET
Task.TaskName = "Test 1"
WHERE Task.Id = 3;
