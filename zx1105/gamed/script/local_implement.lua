--- Mcncc.com
----talisman��������ʵ��
----2007.04.21


----	�ӿڷֳ������֣��ֱ����£�
---	A:��ȡ��������
---	QueryLevel()		�õ���������
---	QueryExp()		�õ�������ǰ����



---	B:��ȡ�����ò��� 
---	  ��ν���������ǽű���������ݣ� ��������float���ͣ���index/value��ʽ����Ͷ���
---        �����ĳ�ʼ��ֵ�ɳ��ʵȶ��Բ����ķ�ʽ���ڡ� ������ռ�õĿռ��GetDataCount()�ķ���ֵ
---	  �����ȡ����Բ�Ҫ������ܴ��index������������ռ�ô������ڴ�����ݿ�ռ䡣
---	QueryData(index)	��ȡ�ƶ������Ĳ��� ����������޶�Ӧ�������򷵻�0.0
---	GetDataCount()		���ص�ǰ���еĲ�����Ŀ ���ֵ����������Чindex+1
---	UpdateData(index, value)����һ�����������index�����ڣ�������һ����Ŀ value������һ����ֵ
---	ClearData()		������д��ڵĲ���



---	C:���÷�������
---	  ���������Ƿ���������Ч�����ã� ��������Ӧ�ôӲ�������õ�,�������Զ������� ,����ʹ�ø�����.
---	  ע��ÿ������ǰ ,�������е����԰����������Զ��ᱻ��� ,����ÿ�����ö�Ӧ����ȫ������
---	SetStamina(value)	���÷������ľ���ֵ
---	SetQuality(value)	���÷�����Ʒ��, ���ͻ�����ʾʹ��
---	SetHP(value)		���÷������ӵ�Ѫ��
---	SetMP(value)		���÷������ӵ�����
---	SetAttackRate(value)	���÷������ӵ�����
---	SetDamage(low ,high)	���÷������ӵĹ�����
---	SetDodge(value)		���÷������ӵ�����
---	SetDefense(value)	���÷������ӵķ���
---	SetResistance(index,value) ���÷������ӵĿ���
---	SetAddon(addon)		���÷����ĸ������� , ÿ�����ö�������һ���������� addon��ģ���еĸ�������ģ��ID

--[[
�����ǲ��Է���4662�Ľű����ӣ������ļ��ϴ�����������Ŀ¼�������������Ļ����ļ��������ء��Ժ���ʽ���뷨��ʱ,��Ҫ����ʽ�����Ľű��ļ�ͨ���ʼ��ύ����.

�����﷨������߼�����������ķ���������������ڿͻ������ֳ�����Ϊ�˷�����ԣ�����һ��Ҫ�����Լ��ĵ��ԺͲ������л�������Ӧ�����������������нű����ԡ�

����ֻ�������񷢷�/��Ʊ����/NPC����/�̳Ƿ�������������»���нű����á�

ԭ�е�2001�ȵ��������޷�������Ч�ķ�����Ϊ�ˣ�������µĵ�������10807ר���������ɣ����磺

d_c2scmd 10807 4662

���⣬Ϊ�˷�����ԣ��ṩ��ˢ�½ű��ļ��Ĺ��ܣ����£�

d_c2scmd 10808

�����ʹ��ǰ���ڵ������¶���test_talisman.lua�ļ������Բ��������������½ű����ݡ�

�����κ����ʣ��뷴����
--]]

math.randomseed(os.time())

Talisman = { 
	id,
	level = 1,
	exp = 0,
	stamina = 0,
	quality = 0,
	hp = 0,
	mp = 0,
	attackRate = 0,
	lowDamage = 0,
	highDamage = 0,
	dodge = 0,
	defense = 0,
	resisStun = 0,
	resisSleep = 0,
	resisWeakness = 0,
	resisEnlace = 0,
	resisSilence = 0,
	data = {},
	addons = {},
	MAX_DATA = 100,
	MAX_ADDON = 10,
	}

---�����ɶ�����
function Talisman:new( o )
	o = o or {}	--- create object if user does not provide one
	setmetatable(o, self)
	self.__index = self
	return o
end

---	A:��ȡ��������

---	QueryLevel()		�õ���������
function Talisman:QueryLevel()
	return self.level
end

---	QueryExp()		�õ�������ǰ����
function Talisman:QueryExp()
	return self.exp
end

---	B:��ȡ�����ò��� 
---	  ��ν���������ǽű���������ݣ� ��������float���ͣ���index/value��ʽ����Ͷ���
---   �����ĳ�ʼ��ֵ�ɳ��ʵȶ��Բ����ķ�ʽ���ڡ� ������ռ�õĿռ��GetDataCount()�ķ���ֵ
---	  �����ȡ����Բ�Ҫ������ܴ��index������������ռ�ô������ڴ�����ݿ�ռ䡣

---	QueryData(index)	��ȡ�ƶ������Ĳ��� ����������޶�Ӧ�������򷵻�0.0
function Talisman:QueryData(index)
	if type(index) ~= "number" or index < 0 or index >= self.MAX_DATA then return 0 end
	if self.data[index] then
		return self.data[index]
	else
		return 0
	end
end

---	GetDataCount()		���ص�ǰ���еĲ�����Ŀ ���ֵ����������Чindex+1
function Talisman:GetDataCount()
	return table.getn(self.data)
end

---	UpdateData(index , value)����һ�����������index�����ڣ�������һ����Ŀ value������һ����ֵ
function Talisman:UpdateData(index , value)
	if type(index) ~= "number" or index < 0 or index >= self.MAX_DATA then return end
	if type(value) ~= "number" then return end
	self.data[index] = value
end

---	ClearData()		������д��ڵĲ���
function Talisman:ClearData()
	local i
	for i = 0, self.MAX_DATA-1 do
		self.data[i] = 0
	end
end




---	C:���÷�������
---	  ���������Ƿ���������Ч�����ã� ��������Ӧ�ôӲ�������õ� ,�������Զ������� ,����ʹ�ø�����.
---	  ע��ÿ������ǰ ,�������е����԰����������Զ��ᱻ��� ,����ÿ�����ö�Ӧ����ȫ������

---	SetStamina(value)	���÷������ľ���ֵ
function Talisman:SetStamina(value)
	if type(value) ~= "number" then return end
	self.stamina = value
end

---	SetQuality(value)	���÷�����Ʒ�� , ���ͻ�����ʾʹ�ã�����Ų��������·��ID
function Talisman:SetQuality(value)
	if type(value) ~= "number" then return end
	self.quality = value
end

---	SetHP(value)		���÷������ӵ�Ѫ��
function Talisman:SetHP(value)
	if type(value) ~= "number" then return end
	self.hp = value
end

---	SetMP(value)		���÷������ӵ�����
function Talisman:SetMP(value)
	if type(value) ~= "number" then return end
	self.mp = value
end	
	
---	SetAttackRate(value)	���÷������ӵ�����
function Talisman:SetAttackRate(value)
	if type(value) ~= "number" then return end
	self.attackRate = value
end

---	SetDamage(low,high)	���÷������ӵĹ�����
function Talisman:SetDamage(low ,high)
	if type(low) ~= "number" or type(high) ~= "number" then return end
	self.lowDamage = low
	self.highDamage = high
end

---	SetDodge(value)		���÷������ӵ�����
function Talisman:SetDodge(value)
	if type(value) ~= "number" then return end
	self.dodge = value
end

---	SetDefense(value)	���÷������ӵķ���
function Talisman:SetDefense(value)
	if type(value) ~= "number" then return end
	self.defense = value
end

---	SetResistance(index ,value) ���÷������ӵĿ���
function Talisman:SetResistance(index,value)
	if type(index) ~= "number" or type(value) ~= "number" then return end
	if index == 0 then self.resisStun = value end
	if index == 1 then self.resisWeakness = value end
	if index == 2 then self.resisEnlace = value end
	if index == 3 then self.resisSilence = value end
	if index == 4 then self.resisSleep = value end
end
		
---	SetAddon(addon)		���÷����ĸ������� , ÿ�����ö�������һ���������� addon��ģ���еĸ�������ģ��ID
function Talisman:SetAddon(addon)
	if type(addon) ~= "number" then return end
	local n 
	n = table.getn(self.addons)
	---debug
	---print(n)
	---debug
	if n >= self.MAX_ADDON then return end
	self.addons[n+1] = addon
end

--- CreateItem(id)���ɷ���
function Talisman:CreateItem(id)
end





---����ʹ�ó�Ա����

---���÷���ģ��ID
function Talisman:LocalSetID(value)
	if type(value) ~= "number" then return end
	self.id = value
end

---��������
function Talisman:LocalAddLevel(value)
	if type(value) ~= "number" then return end
	self.level = self.level + math.floor(value)
end

---ȡ�÷���ģ��ID
function Talisman:LocalGetID()
	return self.id
end

--- LocalClearAddon()  �������и������� ������ʹ��)
function Talisman:LocalClearAddon()
	local i
	for i = 0, self.MAX_ADDON-1 do
		self.addons[i] = nil
	end
end

--- LocalClearAttribute() �������з����������� ������ʹ�ã�
function Talisman:LocalClearAttribute()
	self.stamina = 0
	self.quality = 0
	self.hp = 0
	self.mp = 0
	self.attackRate = 0
	self.lowDamage = 0
	self.highDamage = 0
	self.dodge = 0
	self.defense = 0
	self.resisStun = 0
	self.resisSleep = 0
	self.resisWeakness = 0
	self.resisEnlace = 0
	self.resisSilence = 0
end

--- LocalConfirmData() ���data���ݣ������0��ʼ��ֵ�������κ�2��ֵ֮����nil���򷵻�true
function Talisman:LocalConfirmData()
	local i,n
	n=0
	if self.data[0] == nil then return false end
	for i=1,self.MAX_DATA do
		if self.data[i] ~= nil then n=n+1 end
	end
	if n == table.getn(self.data) then
		return true
	else
		return false
	end
end

--- LocalPrint(maxData,maxAddon) ��ʾ������ǰ���ԣ�����ʹ�ã�
function Talisman:LocalPrint(maxData,maxAddon)
	print("-------------------------------")
	print("      tmpl id :",self.id)
	print("        level :",self.level)
	print("          exp :",self.exp)
	print("      stamina :",self.stamina)
	print("      quality :",self.quality)
	print("           hp :",self.hp)
	print("           mp :",self.mp)
	print("   attackRate :",self.attackRate)
	print("       damage :",self.lowDamage,self.highDamage)
	print("        dodge :",self.dodge)
	print("      defense :",self.defense)
	print("    resisStun :",self.resisStun)
	print("   resisSleep :",self.resisSleep)
	print("resisWeakness :",self.resisWeakness)
	print("  resisEnlace :",self.resisEnlace)
	print(" resisSilence :",self.resisSilence)
	maxData = maxData or 100
	maxAddon = maxAddon or 10
	local i, nPrinted
	nPrinted = 0
	for i=1,self.MAX_ADDON do
		if self.addons[i] then
			if nPrinted < maxAddon then
				print("       addon :",i,self.addons[i])
				nPrinted = nPrinted + 1
			end
		end
	end
	nPrinted = 0
	for i=0,self.MAX_DATA-1 do
		if self.data[i] then
			if nPrinted < maxData then
				print("         data :",i,self.data[i])
				nPrinted = nPrinted + 1
			end
		end
	end
end


---�洢���к���������ʹ�ã�
---�ṹ�� { { tmpl_id=number, init=function, levelup=function, reset=function },{tmpl_id=number, init=function, levelup=function, reset=function } ...}
funcs = {}

---AddTalismanItem
function AddTalismanItem(id, talisman_init,talisman_levelup,talisman_reset)
	if type(id) ~= "number" or type(talisman_init) ~= "function" or type(talisman_levelup) ~= "function" or type(talisman_reset) ~= "function" then 
		return
	end
	funcs[id] = {}
	funcs[id]["tmpl_id"] = id
	funcs[id]["init"] = talisman_init
	funcs[id]["levelup"] = talisman_levelup
	funcs[id]["reset"] = talisman_reset
end


---���ڵ��ú�����talisman�Ƿ�������operate�ǲ�������string��Ŀǰ��"init","levelup","reset"����
function TalismanFunction(talisman,operate)
	if talisman == nil then return end
	local id,func
	id = talisman:LocalGetID()
	if funcs[id] and funcs[id][operate] and type(funcs[id][operate]) == "function" then
		func = funcs[id][operate]
		return func(id,talisman)
	end
end




