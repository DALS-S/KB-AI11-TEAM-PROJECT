create or replace PROCEDURE search_food_kind (
-- 파라미터
    food_kind IN item.name%TYPE,
--    out_msg OUT VARCHAR2,
    o_cursor OUT SYS_REFCURSOR
)
AS
BEGIN

    OPEN o_cursor FOR
        SELECT *
        
--               name 
--             , price 
--             , TO_CHAR(regdate, 'YYYY-MM-DD') 
          FROM item
         WHERE kind = food_kind;

               
END;