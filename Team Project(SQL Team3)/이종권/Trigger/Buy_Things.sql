--------------------------------------------------------
--  ������ ������ - ������-10��-23-2023   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Trigger BUY_THINGS
--------------------------------------------------------

  CREATE OR REPLACE EDITIONABLE TRIGGER "C##USER"."BUY_THINGS" 
after 
insert on cart
-- �� �࿡�� �߻��ϴ� �̺�Ʈ�� ���� ó��
-- cart���̺��� insert�� �� ��ǰ���� ������ ��ŭ
-- item���̺��� �������� �پ��� Ʈ����
for each row
begin
 update item
 set item_cnt = item_cnt - :NEW.cart_quantity
 where item_num = :NEW.item_num;
end;
/
ALTER TRIGGER "C##USER"."BUY_THINGS" ENABLE;
