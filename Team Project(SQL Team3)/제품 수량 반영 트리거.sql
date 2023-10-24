-- 재고 반영 트리거
CREATE OR REPLACE EDITIONABLE TRIGGER BUY_THINGS 
after 
insert on orders_detail
-- 각 행에서 발생하는 이벤트에 대해 처리
-- cart테이블에서 insert할 때 제품수량 선택한 만큼
-- item테이블의 수량값이 줄어드는 트리거
for each row
begin
 update item
 set item_cnt = item_cnt - :NEW.quantity
 where item_num = :NEW.quantity;
end;

