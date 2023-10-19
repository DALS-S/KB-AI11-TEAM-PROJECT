-- ��ǰ ���̺� ����
CREATE TABLE item (
    item_num NUMBER(5) PRIMARY KEY,      -- ��ǰ ��ȣ
    name     VARCHAR2(200) DEFAULT 0,    -- ��ǰ �̸�
    kind     VARCHAR2(20),               -- ��ǰ ���� (ex.�ѽ�,�߽�,...)
    price    NUMBER(10) DEFAULT 0,       -- ��ǰ ����
    regdate  VARCHAR2(10)                -- ��ǰ �����
);

-- ��ǰ ��ȣ ���� ������
CREATE SEQUENCE item_seq START WITH 1 INCREMENT BY 1; 

-- �� ���̺� ����
CREATE TABLE users (
    id      VARCHAR2(20) PRIMARY KEY,   -- ���� ���̵�
    name    VARCHAR2(20),               -- ���� �̸�
    address VARCHAR2(100),              -- ���� �ּ�
    phone   VARCHAR2(20)                -- ���� ��ȭ��ȣ
);

-- ��ٱ��� ���̺� ����
CREATE TABLE cart (
    cart_num      NUMBER(8) PRIMARY KEY,           -- ��ٱ��� ��ȣ
    id            VARCHAR2(20),                    -- ��ٱ��� �̿� �� ���̵�
    item_num      NUMBER(5),                       -- ��ǰ ��ȣ
    cart_quantity NUMBER(5) DEFAULT 1,             -- ��ٱ��Ͽ� ���� ��ǰ ����
    cart_in_date  VARCHAR2(10),                    -- ��ٱ��� ���� ��¥
    CONSTRAINT fk_user_id FOREIGN KEY ( id )
        REFERENCES users ( id ),                      -- �ܷ�Ű(����)
    CONSTRAINT fk_item_num FOREIGN KEY ( item_num )
        REFERENCES item ( item_num )                  -- �ܷ�Ű(����)
);    

-- ��ٱ��� ��ȣ ���� ������
CREATE SEQUENCE cart_seq START WITH 1 INCREMENT BY 1;

-- �ֹ� ���̺� ����
CREATE TABLE orders (
    orders_num  NUMBER(10) PRIMARY KEY,                  -- �ֹ���ȣ
    id          VARCHAR2(20),                            -- �ֹ��� ���� ���̵�/foreign key for user(id)
    orders_date VARCHAR2(10),                            -- �ֹ���¥  
    CONSTRAINT fk_orders_id FOREIGN KEY ( id )
        REFERENCES users ( id )                          -- �ܷ�Ű(����)
);

-- �ֹ� ��ȣ ���� ������
CREATE SEQUENCE orders_seq START WITH 1 INCREMENT BY 1; 

-- �� �ֹ� ���̺� ����
CREATE TABLE orders_detail (
    orders_reaction_num NUMBER(10) PRIMARY KEY,      -- �ֹ�ó�� ��ȣ
    orders_num          NUMBER(10),                  -- �ֹ���ȣ/foreign key for order(order_num)
    item_num            NUMBER(5),                   -- ��ǰ��ȣ/foreign key for item(item_num)
    quantity            NUMBER(5),                   -- ��ǰ ����
    orders_result       VARCHAR2(10) DEFAULT 1,      -- ó������(ex. �����:1, �����:2, ����:3, ...)
    CONSTRAINT fk_orders_detail FOREIGN KEY ( orders_num )
        REFERENCES orders ( orders_num ),            -- �ܷ�Ű(����)
    CONSTRAINT fk_prod_detail FOREIGN KEY ( item_num )
        REFERENCES item ( item_num )                 -- �ܷ�Ű(����)
);

-- �ֹ�ó�� ��ȣ ���� ������
CREATE SEQUENCE orders_reaction_num_seq START WITH 1 INCREMENT BY 1;

-- �� ����
-- (1) īƮ ��
CREATE OR REPLACE VIEW cart_view AS
    SELECT
        c.cart_num      "��ٱ��� ��ȣ",
        c.item_num      "��ǰ ��ȣ",
        i.name          ��ǰ��,
        i.price         ����,
        c.cart_quantity "���� ����",
        c.id            "�� ID",
        u.name          ����,
        c.cart_in_date  "��� ��¥"
    FROM
        cart  c,
        users u,
        item  i
    WHERE
            c.id = u.id
        AND c.item_num = i.item_num;

-- (2) �ֹ� ��
CREATE OR REPLACE VIEW order_view AS
    SELECT
        od.orders_reaction_num "�ֹ�ó�� ��ȣ",
        o.orders_num           "�ֹ���ȣ",
        od.item_num            ��ǰ��ȣ,
        i.name                 ��ǰ��,
        i.price                ����,
        od.quantity            �ֹ�����,
        o.id                   "�ֹ��� ID",
        u.name                 ����,
        u.address              �ּ�,
        u.phone                ��ȭ��ȣ,
        o.orders_date          "�ֹ� ��¥",
        od.orders_result       ��ۻ���
    FROM
        orders        o,
        orders_detail od,
        users         u,
        item          i
    WHERE
            o.orders_num = od.orders_num
        AND o.id = u.id
        AND od.item_num = i.item_num;
        
-- ���� �μ�Ʈ
--�ѽ�
insert into item values(item_seq.NEXTVAL,'�Ұ�â����','�ѽ�',15000,sysdate);
insert into item values(item_seq.NEXTVAL,'�Ұ��','�ѽ�',13000,'2023.09.15');
insert into item values(item_seq.NEXTVAL,'������','�ѽ�',10000,'2023.09.15');
insert into item values(item_seq.NEXTVAL,'�ߺ�����','�ѽ�',12000,'2023.09.15');
insert into item values(item_seq.NEXTVAL,'�δ��','�ѽ�',15000,'2023.09.15');
--�߽�
insert into item values(item_seq.NEXTVAL,'¥���','�߽�',9900,'2023.09.16');
insert into item values(item_seq.NEXTVAL,'«��','�߽�',13000,'2023.09.16');
insert into item values(item_seq.NEXTVAL,'������','�߽�',10000,'2023.09.16');
insert into item values(item_seq.NEXTVAL,'���󼧱�','�߽�',15000,'2023.09.16');
insert into item values(item_seq.NEXTVAL,'��«��','�߽�',12900,'2023.09.16');
--���
insert into item values(item_seq.NEXTVAL,'���ٽ� ��ĭ��','���',9900,'2023.09.17');
insert into item values(item_seq.NEXTVAL,'Ÿ��','���',13900,'2023.09.17');
insert into item values(item_seq.NEXTVAL,'���� ũ�� ���� �Ľ�Ÿ','���',14000,'2023.09.17');
insert into item values(item_seq.NEXTVAL,'��ȣ�ڽ���','���',9900,'2023.09.17');
insert into item values(item_seq.NEXTVAL,'�� ������ũ','���',17000,'2023.09.17');
--�Ͻ�
insert into item values(item_seq.NEXTVAL,'��ǣ������','�Ͻ�',12900,'2023.09.18');
insert into item values(item_seq.NEXTVAL,'�������','�Ͻ�',10900,'2023.09.18');
insert into item values(item_seq.NEXTVAL,'�Ұ�� ���� ����','�Ͻ�',15900,'2023.09.18');
insert into item values(item_seq.NEXTVAL,'��Ű�߳�','�Ͻ�',9900,'2023.09.18');
insert into item values(item_seq.NEXTVAL,'���������','�Ͻ�',17000,'2023.09.18');

--������
insert into users values('KB01','������','�λ� ����','010-0000-0000');
insert into users values('KB02','�̰��','���� ��������','010-1111-1111');
insert into users values('KB03','�̻���','��⵵ ����','010-2222-2222');
insert into users values('KB04','������','������ ��õ','010-3333-4444');
insert into users values('KB05','������','���� ���ʱ�','010-5555-5555');
insert into users values('KB06','���ؿ�','���� ������','010-6666-6666');
insert into users values('KB07','������','�뱸 ����','010-7777-7777');

--��ٱ���
insert into cart values (cart_seq.nextval, 'KB01', 1, 5, sysdate);
insert into cart values (cart_seq.nextval, 'KB02', 8, 2, sysdate);
insert into cart values (cart_seq.nextval, 'KB03', 20, 2, sysdate);
insert into cart values (cart_seq.nextval, 'KB04', 13, 1, sysdate);
insert into cart values (cart_seq.nextval, 'KB07', 5, 10, sysdate);

--�ֹ�
insert into orders values (orders_seq.nextval, 'KB01', sysdate);
insert into orders values (orders_seq.nextval, 'KB02', sysdate);
insert into orders values (orders_seq.nextval, 'KB03', sysdate);
insert into orders values (orders_seq.nextval, 'KB04', sysdate);
insert into orders values (orders_seq.nextval, 'KB07', sysdate);

--���ֹ�
insert into orders_detail values (orders_reaction_num_seq.nextval,1,1,5,'�����');
insert into orders_detail values (orders_reaction_num_seq.nextval,2,8,2,'�����');
insert into orders_detail values (orders_reaction_num_seq.nextval,3,20,2,'�����');
insert into orders_detail values (orders_reaction_num_seq.nextval,4,13,1,'�����');
insert into orders_detail values (orders_reaction_num_seq.nextval,5,5,10,'�����');

--�������
select * from item;
select * from users;
select * from cart;
select * from orders;
select * from orders_detail;

-- ���� ����
update users set address = '�뱸 �޼���' where name = '�̰��';
update users set phone = '010-8282-0000' where name = '�̰��';
update users set name = '��ġ��' where name = '�̰��';
update item set name = '���߶�����' where item_num = '1';
update orders_detail set orders_result = '��ۿ�' where orders_result = '�����';

-- ���� ����
delete from orders_detail where quantity = 2;
delete from orders_detail where quantity = 2;
delete from cart where cart_quantity = 2;
delete from cart where item_num = 13;
delete from item where kind = '�߽�';

-- join
select orders.orders_num as �ֹ���ȣ, 
users.name as �ֹ��ڸ�, 
item.name as ��ǰ��, 
item.price as ����, 
orders_date as �ֹ��Ͻ� from orders 
join item on orders.id=item.name 
join users on orders.id=users.id 
order by �ֹ���ȣ;

-- group by
select count(item_num), id from cart group by id;

-- having ��
select  id from cart group by id having count(item_num)=1;

-- �ְ� ��ǰ
create view max_item_Price as select max(price) �ְ� from item;

-- ��ø���ǹ� �ۼ�
select * from item where price = (select * from max_item_Price);

-- ��ٱ��� �� ���        
SELECT
    *
FROM
    cart_view;
    
-- �ֹ� �� ���
SELECT
    *
FROM
    order_view;
    
    
-- ���̺� �� ������ ���    
DROP TABLE item;

DROP TABLE users;

DROP TABLE cart;

DROP TABLE orders;

DROP TABLE orders_detail;

drop sequence cart_seq;

DROP SEQUENCE item_seq;

DROP SEQUENCE orders_seq;

DROP SEQUENCE orders_reaction_num_seq;