CREATE OR REPLACE TRIGGER BUY_THINGS 
AFTER
INSERT ON orders_detail
-- �� �࿡�� �߻��ϴ� �̺�Ʈ�� ���� ó��
-- cart���̺��� insert�� �� ��ǰ���� ������ ��ŭ
-- item���̺��� �������� �پ��� Ʈ����
FOR EACH ROW
BEGIN
 UPDATE item
 SET item_cnt = item_cnt - :NEW.quantity
 WHERE item_num = :NEW.item_num;
END;
