-- 제품 테이블 생성
CREATE TABLE item (
    item_num NUMBER(5) PRIMARY KEY,      -- 제품 번호
    name     VARCHAR2(200) DEFAULT 0,    -- 제품 이름
    kind     VARCHAR2(20),               -- 제품 종류 (ex.한식,중식,...)
    price    NUMBER(10) DEFAULT 0,       -- 제품 가격
    regdate  VARCHAR2(10),                -- 제품 등록일
--  제품 수량 칼럼 새로 추가 
    item_cnt INT DEFAULT 0
);

-- 제품 번호 생성 시퀀스
CREATE SEQUENCE item_seq START WITH 1 INCREMENT BY 1; 


VAR o_cursor REFCURSOR
EXEC search_food_kind('한식', :o_cursor)
PRINT o_cursor



-- 고객 테이블 생성
CREATE TABLE users (
    id      VARCHAR2(20) PRIMARY KEY,   -- 유저 아이디
    name    VARCHAR2(20),               -- 유저 이름
    address VARCHAR2(100),              -- 유저 주소
    phone   VARCHAR2(20)                -- 유저 전화번호
);

-- 장바구니 테이블 생성
CREATE TABLE cart (
    cart_num      NUMBER(8) PRIMARY KEY,           -- 장바구니 번호
    id            VARCHAR2(20),                    -- 장바구니 이용 고객 아이디
    item_num      NUMBER(5),                       -- 제품 번호
    cart_quantity NUMBER(5) DEFAULT 1,             -- 장바구니에 담은 제품 수량
    cart_in_date  VARCHAR2(10),                    -- 장바구니 담은 날짜
    CONSTRAINT fk_user_id FOREIGN KEY ( id )
        REFERENCES users ( id ),                      -- 외래키(참조)
    CONSTRAINT fk_item_num FOREIGN KEY ( item_num )
        REFERENCES item ( item_num )                  -- 외래키(참조)
);    

-- 장바구니 번호 생성 시퀀스
CREATE SEQUENCE cart_seq START WITH 1 INCREMENT BY 1;

-- 주문 테이블 생성
CREATE TABLE orders (
    orders_num  NUMBER(10) PRIMARY KEY,                  -- 주문번호
    id          VARCHAR2(20),                            -- 주문한 유저 아이디/foreign key for user(id)
    orders_date VARCHAR2(10),                            -- 주문날짜  
    CONSTRAINT fk_orders_id FOREIGN KEY ( id )
        REFERENCES users ( id )                          -- 외래키(참조)
);

-- 주문 번호 생성 시퀀스
CREATE SEQUENCE orders_seq START WITH 1 INCREMENT BY 1; 

-- 상세 주문 테이블 생성
CREATE TABLE orders_detail (
    orders_reaction_num NUMBER(10) PRIMARY KEY,      -- 주문처리 번호
    orders_num          NUMBER(10),                  -- 주문번호/foreign key for order(order_num)
    item_num            NUMBER(5),                   -- 제품번호/foreign key for item(item_num)
    quantity            NUMBER(5),                   -- 제품 수량
    orders_result       VARCHAR2(10) DEFAULT 1,      -- 처리유무(ex. 배송전:1, 배송중:2, 도착:3, ...)
    CONSTRAINT fk_orders_detail FOREIGN KEY ( orders_num )
        REFERENCES orders ( orders_num ),            -- 외래키(참조)
    CONSTRAINT fk_prod_detail FOREIGN KEY ( item_num )
        REFERENCES item ( item_num )                 -- 외래키(참조)
);

-- 주문처리 번호 생성 시퀀스
CREATE SEQUENCE orders_reaction_num_seq START WITH 1 INCREMENT BY 1;

-- 뷰 생성
-- (1) 카트 뷰
CREATE OR REPLACE VIEW cart_view AS
    SELECT
        c.cart_num      "장바구니 번호",
        c.item_num      "제품 번호",
        i.name          제품명,
        i.price         가격,
        c.cart_quantity "담은 수량",
        c.id            "고객 ID",
        u.name          고객명,
        c.cart_in_date  "등록 날짜"
    FROM
        cart  c,
        users u,
        item  i
    WHERE
            c.id = u.id
        AND c.item_num = i.item_num;

-- (2) 주문 뷰
CREATE OR REPLACE VIEW order_view AS
    SELECT
        od.orders_reaction_num "주문처리 번호",
        o.orders_num           "주문번호",
        od.item_num            제품번호,
        i.name                 제품명,
        i.price                가격,
        od.quantity            주문수량,
        o.id                   "주문자 ID",
        u.name                 고객명,
        u.address              주소,
        u.phone                전화번호,
        o.orders_date          "주문 날짜",
        od.orders_result       배송상태
    FROM
        orders        o,
        orders_detail od,
        users         u,
        item          i
    WHERE
            o.orders_num = od.orders_num
        AND o.id = u.id
        AND od.item_num = i.item_num;
        
-- 정보 인서트
--한식
insert into item values(item_seq.NEXTVAL,'소곱창볶음','한식',15000,sysdate, 10);
insert into item values(item_seq.NEXTVAL,'불고기','한식',13000,'2023.09.15', 10);
insert into item values(item_seq.NEXTVAL,'떡볶이','한식',10000,'2023.09.15', 10);
insert into item values(item_seq.NEXTVAL,'닭볶음탕','한식',12000,'2023.09.15', 10);
insert into item values(item_seq.NEXTVAL,'부대찌개','한식',15000,'2023.09.15', 10);
--중식
insert into item values(item_seq.NEXTVAL,'짜장면','중식',9900,'2023.09.16', 10);
insert into item values(item_seq.NEXTVAL,'짬뽕','중식',13000,'2023.09.16', 10);
insert into item values(item_seq.NEXTVAL,'마라탕','중식',10000,'2023.09.16', 10);
insert into item values(item_seq.NEXTVAL,'마라샹궈','중식',15000,'2023.09.16', 10);
insert into item values(item_seq.NEXTVAL,'백짬뽕','중식',12900,'2023.09.16', 10);
--양식
insert into item values(item_seq.NEXTVAL,'간바스 피칸테','양식',9900,'2023.09.17', 10);
insert into item values(item_seq.NEXTVAL,'타코','양식',13900,'2023.09.17', 10);
insert into item values(item_seq.NEXTVAL,'봉골레 크림 빠네 파스타','양식',14000,'2023.09.17', 10);
insert into item values(item_seq.NEXTVAL,'단호박스프','양식',9900,'2023.09.17', 10);
insert into item values(item_seq.NEXTVAL,'찹 스테이크','양식',17000,'2023.09.17', 10);
--일식
insert into item values(item_seq.NEXTVAL,'밀푀유나베','일식',12900,'2023.09.18', 10);
insert into item values(item_seq.NEXTVAL,'샤브샤브','일식',10900,'2023.09.18', 10);
insert into item values(item_seq.NEXTVAL,'소고기 버섯 전골','일식',15900,'2023.09.18', 10);
insert into item values(item_seq.NEXTVAL,'스키야끼','일식',9900,'2023.09.18', 10);
insert into item values(item_seq.NEXTVAL,'돈코츠라멘','일식',17000,'2023.09.18', 10);

--고객정보
insert into users values('KB01','유지웅','부산 동구','010-0000-0000');
insert into users values('KB02','이경민','제주 서귀포시','010-1111-1111');
insert into users values('KB03','이상하','경기도 수원','010-2222-2222');
insert into users values('KB04','이종권','강원도 춘천','010-3333-4444');
insert into users values('KB05','이지금','서울 서초구','010-5555-5555');
insert into users values('KB06','오해원','서울 강남구','010-6666-6666');
insert into users values('KB07','이찬원','대구 동구','010-7777-7777');

--장바구니
insert into cart values (cart_seq.nextval, 'KB01', 1, 5, sysdate);
insert into cart values (cart_seq.nextval, 'KB02', 8, 2, sysdate);
insert into cart values (cart_seq.nextval, 'KB03', 20, 2, sysdate);
insert into cart values (cart_seq.nextval, 'KB04', 13, 1, sysdate);
insert into cart values (cart_seq.nextval, 'KB07', 5, 10, sysdate);

--주문
insert into orders values (orders_seq.nextval, 'KB01', sysdate);
insert into orders values (orders_seq.nextval, 'KB02', sysdate);
insert into orders values (orders_seq.nextval, 'KB03', sysdate);
insert into orders values (orders_seq.nextval, 'KB04', sysdate);
insert into orders values (orders_seq.nextval, 'KB07', sysdate);

--상세주문
insert into orders_detail values (orders_reaction_num_seq.nextval,1,1,5,'배송중');
insert into orders_detail values (orders_reaction_num_seq.nextval,2,8,2,'배송중');
insert into orders_detail values (orders_reaction_num_seq.nextval,3,20,2,'배송중');
insert into orders_detail values (orders_reaction_num_seq.nextval,4,13,1,'배송중');
insert into orders_detail values (orders_reaction_num_seq.nextval,5,5,10,'배송중');

--예시출력
select * from item;
select * from users;
select * from cart;
select * from orders;
select * from orders_detail;

-- 정보 갱신
update users set address = '대구 달서구' where name = '이경민';
update users set phone = '010-8282-0000' where name = '이경민';
update users set name = '최치수' where name = '이경민';
update item set name = '궁중떡볶이' where item_num = '1';
update orders_detail set orders_result = '배송완' where orders_result = '배송중';

-- 정보 삭제
delete from orders_detail where quantity = 2;
delete from orders_detail where quantity = 2;
delete from cart where cart_quantity = 2;
delete from cart where item_num = 13;
delete from item where kind = '중식';

-- join
select orders.orders_num as 주문번호, 
users.name as 주문자명, 
item.name as 제품명, 
item.price as 가격, 
orders_date as 주문일시 from orders 
join item on orders.id=item.name 
join users on orders.id=users.id 
order by 주문번호;

-- group by
select count(item_num), id from cart group by id;

-- having 절
select  id from cart group by id having count(item_num)=1;

-- 최고가 제품
create view max_item_Price as select max(price) 최고가 from item;

-- 중첩질의문 작성
select * from item where price = (select * from max_item_Price);

-- 장바구니 뷰 출력        
SELECT
    *
FROM
    cart_view;
    
-- 주문 뷰 출력
SELECT
    *
FROM
    order_view;
    
    
-- 테이블 및 시퀀스 드랍    
DROP TABLE item;

DROP TABLE users;

DROP TABLE cart;

DROP TABLE orders;

DROP TABLE orders_detail;

DROP SEQUENCE cart_seq;

DROP SEQUENCE item_seq;

DROP SEQUENCE orders_seq;

DROP SEQUENCE orders_reaction_num_seq;


