create or replace PROCEDURE oreder_info(
    -- 주문 번호 :: 프로시저로 받은 값
    food_order_num IN orders.orders_num%TYPE, 
--  주문 날짜
    food_order_date IN orders.orders_date%TYPE
--    order_id IN  users.id%TYPE
) 
AS
--    order_id :: 유저 테이블의 유저 id 저장
    order_id VARCHER2(20);
    
BEGIN
  NULL;
END;