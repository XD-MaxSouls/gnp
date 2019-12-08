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

-------------------------------------------------------------------------------------------------
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

function test_rebuild(talisman)
	local level = talisman:QueryLevel();
	talisman:SetHP(level*talisman:QueryData(0) + 10);
	talisman:SetMP(level*talisman:QueryData(1) + 10);
	talisman:SetAttackRate(level*talisman:QueryData(2) + 10);
	talisman:SetResistance(1, level*talisman:QueryData(3) + 10);
	talisman:SetAddon(7);
	
	local value = talisman:QueryData(4);
	if(value > 0) then
		talisman:SetAddon(8);
		talisman:SetAddon(9);
		talisman:SetAddon(10);
	end
end

function test_init(id, talisman)

--���ɳ�ֵ
	talisman:UpdateData(0, math.random() + 1.0);
	talisman:UpdateData(1, math.random() + 1.0);
	talisman:UpdateData(2, math.random() + 1.0);
	talisman:UpdateData(3, math.random() + 1.0);
	
	test_rebuild(talisman);
end

function test_levelup(id, talisman)
	test_rebuild(talisman);
end

function test_reset(id, talisman)
	test_rebuild(talisman);
end

AddTalismanItem(4662, test_init,test_levelup,test_reset);


function CombineTalismans(id1,id2, talisman1,talisman2,cid,output)
	if(cid ~= 0) then
		output:CreateItem(4662);		--����е������ߣ�����һ���µĸ߼�����
							--����Ϳ�������������Ʒ��
		output:UpdateData(4, 1);
		test_init(4662, output);
	else
		output:CreateItem(4670);		--û�е������ߣ�����һ����ͨ��Ʒ
							--���ﲻӦ�ڵ��������ӿ�
	end
end

xdofile("script/talisman.lua");
xdofile("script/talisman_addon.lua");
xdofile("script/talisman_combine.lua");

