--------------------------------------------------------
--  파일이 생성됨 - 월요일-10월-23-2023   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Trigger BUY_THINGS
--------------------------------------------------------

  CREATE OR REPLACE EDITIONABLE TRIGGER "C##USER"."BUY_THINGS" 
after 
insert on cart
-- 각 행에서 발생하는 이벤트에 대해 처리
-- cart테이블에서 insert할 때 제품수량 선택한 만큼
-- item테이블의 수량값이 줄어드는 트리거
for each row
begin
 update item
 set item_cnt = item_cnt - :NEW.cart_quantity
 where item_num = :NEW.item_num;
end;
/
ALTER TRIGGER "C##USER"."BUY_THINGS" ENABLE;
