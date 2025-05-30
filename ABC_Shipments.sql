create database ABC_Shipments;

use ABC_Shipments;

create table ShippedItem(
	item_number int,
	weight float,
	dimension float,
	insurance varchar(20),
	amount float,
	destination varchar(20),
	deliverydate  datetime,
	RC_id int
);

select * from ShippedItem;

create table RetailCenter(
	RC_id int,
	RC_type varchar(20),
	RC_address varchar(20)
);

select * from RetailCenter;