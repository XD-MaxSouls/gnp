-- Mcncc.com ��Ʒ
talisman_tab = {};

function AddTalismanItem(id, init, levelup, reset)
	talisman_tab[id] = {};
	talisman_tab[id].Init = init;
	talisman_tab[id].LevelUp = levelup;
	talisman_tab[id].Reset = reset;
end

--	talisman����ӿڷֳ������֣��ֱ����£�
--	A:��ȡ��������
--	QueryLevel()		�õ���������
--	QueryExp()		�õ�������ǰ����

--	B:��ȡ�����ò��� 
--	  ��ν���������ǽű���������ݣ� ��������float���ͣ���index/value��ʽ����Ͷ���
--        �����ĳ�ʼ��ֵ�ɳ��ʵȶ��Բ����ķ�ʽ���ڡ� ������ռ�õĿռ��GetDataCount()�ķ���ֵ
--	  �����ȡ����Բ�Ҫ������ܴ��index������������ռ�ô������ڴ�����ݿ�ռ䡣
--	QueryData(index)	��ȡ�ƶ������Ĳ��� ����������޶�Ӧ�������򷵻�0.0
--	GetDataCount()		���ص�ǰ���еĲ�����Ŀ ���ֵ����������Чindex+1
--	UpdateData(index, value)����һ�����������index�����ڣ�������һ����Ŀ value������һ����ֵ
--	ClearData()		������д��ڵĲ���

-- Mcncc.com ��Ʒ

--	C:���÷�������
--	  ���������Ƿ���������Ч�����ã� ��������Ӧ�ôӲ�������õ�,�������Զ�������,����ʹ�ø�����.
--	  ע��ÿ������ǰ,�������е����԰����������Զ��ᱻ���,����ÿ�����ö�Ӧ����ȫ������
--	SetStamina(value)	���÷������ľ���ֵ
--	SetQuality(value)	���÷�����Ʒ��, ���ͻ�����ʾʹ��
--	SetHP(value)		���÷������ӵ�Ѫ��
--	SetMP(value)		���÷������ӵ�����
--	SetAttackRate(value)	���÷������ӵ�����
--	SetDamage(low,high)	���÷������ӵĹ�����
--	SetDodge(value)		���÷������ӵ�����
--	SetDefense(value)	���÷������ӵķ���
--	SetResistance(index,value) ���÷������ӵĿ���
--	SetAddon(addon)		���÷����ĸ�������, ÿ�����ö�������һ���������� addon��ģ���еĸ�������ģ��ID

----------------------------------------------�װ�����2010��2��10���޸�---------------------------------------------------
--	�����ںϺ���˵��
--	CombineTalismans(id1,id2, talisman1,talisman2,cid,output)
--	id1 id2 Ϊ��Ҫ�ںϵ����������� id
--	talisman1 talisman2 Ϊ��Ҫ�ںϵ����������Ķ��� ����������ͬinit reset levelup�������ô����talisman
--	cid Ϊ�ںϵ������ߵ�id
--	output Ϊ�������ƶ��� �˶�����Ե���CreateItem�ӿ�

--	output�������ƶ���ӿ�����
--	CreateItem(id)		����Ҫ����һ������Ʒ����������ô˽ӿڣ� ���޲�����Ʒ;
--				����ʹ�ô˽ӿڴ���һ��������Ʒ֮������Կ�ʼʹ��
--				talisman��������������ӿڣ� ��QueryData UpdateData Set...ϵ�нӿ
--				���û�д�����Ʒ���ߴ����˷Ƿ�����Ʒ����Ҳ��Ӧ����output����������ӿڡ�

xdofile("script/talisman.lua");
xdofile("script/talisman_addon.lua");
xdofile("script/talisman_combine.lua");

