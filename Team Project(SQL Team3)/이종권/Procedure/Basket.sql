create or replace PROCEDURE basket(  
    basket_num IN cart.cart_num%TYPE, -- 장바구니 번호
    cust_id IN VARCHAR2,-- 고객ID
    in_item_num IN item.item_num%TYPE,-- 제품번호 
    in_food_ea IN item.item_cnt%TYPE, -- 담은 수량
    buy_date IN cart.cart_in_date%TYPE-- 담은 날짜
    
)
-- 변수 선언하는 곳
AS
-- item 테이블의 수량 업데이트
    old_item_cnt INT;
    new_item_cnt INT;

BEGIN
    DBMS_OUTPUT.ENABLE(buffer_size=>NULL); 
    SELECT
        item_cnt
    INTO old_item_cnt
    FROM
        item
    WHERE
            item_cnt >= in_food_ea
        AND item_num = in_item_num;
        
--    INSERT INTO cart VALUES(basket_num, cust_id, in_item_num, in_food_ea, buy_date);
--  디버깅용
    DBMS_OUTPUT.PUT_LINE(old_item_cnt);
            
    IF old_item_cnt = 0 THEN
        DBMS_OUTPUT.PUT_LINE('현재 수량이 부족합니다.');
    ELSE
        new_item_cnt := old_item_cnt - in_food_ea; 
        UPDATE item SET item_cnt = new_item_cnt WHERE item_num = in_item_num;
        
        INSERT INTO cart(cart_num, id, item_num, cart_quantity, cart_in_date) 
        VALUES(basket_num, cust_id, in_item_num, in_food_ea, buy_date);
    END IF; 
END;