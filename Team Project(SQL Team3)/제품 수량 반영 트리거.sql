-- ��� �ݿ� Ʈ����
CREATE OR REPLACE EDITIONABLE TRIGGER BUY_THINGS 
after 
insert on orders_detail
-- �� �࿡�� �߻��ϴ� �̺�Ʈ�� ���� ó��
-- cart���̺��� insert�� �� ��ǰ���� ������ ��ŭ
-- item���̺��� �������� �پ��� Ʈ����
for each row
begin
 update item
 set item_cnt = item_cnt - :NEW.quantity
 where item_num = :NEW.quantity;
end;

