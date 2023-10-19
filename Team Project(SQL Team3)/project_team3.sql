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