-- petbedge �ӿ�˵��

--	QueryData(index)
--	GetDataCount()
--	UpdateData(index,value)
--	ClearData()

--	QueryLevel()
--	SetLevel()
--	QueryExp()
--	SetExp()
--	QueryCurHP()
--	SetCurHP(value)
--	QueryCurVigor()
--	SetCurVigor(value)
--	QueryStar()
--	SetStar(value)
--	QueryMainType()
--	SetMainType(value)
--	QueryElement()
--	SetElement(value)
--	QueryIdentify()
--	SetIdentify(value)
--	QueryRace()
--	SetRace(value)
--	QueryHoroscope()
--	SetHoroscope(value)

--	MAX_HP,         //����
--	MAX_VIGOR,      //����
--	MIN_ATTACK,     //��С����
--	MAX_ATTACK,     //��󹥻�
--	DEFENCE,        //����
--	HIT,            //����
--	JOUK,           //����
--	RESISTANCE1,    //����
--	RESISTANCE2,
--	RESISTANCE3,
--	RESISTANCE4,
--	RESISTANCE5,
--	RESISTANCE6,
--	MAX_ATTR,
--	index 0-12
--	QueryCombatAttrInit(index)
--	SetCombatAttrInit(index,value)
--	QueryCombatAttrPotential(index)		float
--	SetCombatAttrPotential(index,value)	value float
--	QueryCombatAttrCur(index)
--	SetCombatAttrCur(index,value)
--	QueryExtraDamage()
--	SetExtraDamage(value)
--	QueryExtraDamageReduce()
--	SetExtraDamageReduce(value)
--	QueryCritRate()				float
--	SetCritRate(value)			float
--	QueryCritDamage()			float
--	SetCritDamage(value)			float
--	QueryMaxHungerPoint()
--	SetMaxHungerPoint(value)
--	QueryCurHungerPoint()
--	SetCurHungerPoint(value)
--	QueryMaxHonorPoint()
--	SetMaxHonorPoint(value)
--	QueryCurHonorPoint()
--	SetCurHonorPoint(value)
--	QueryAge()
--	SetAge(value)
--	QueryLife()
--	SetLife(value)
--	QuerySkillID(index)
--	SetSkillID(index,value)
--	QuerySkillLevel(index)
--	SetSkillLevel(index,value)
--	QueryTalent(index)
--	SetTalent(index,value)
--	QueryAcuity()
--	SetAcuity(value)
--	QueryStamina()
--	SetStamina(value)
--	QuerySawy()
--	SetSawy(value)
--	QueryDowry()
--	SetDowry(value)
--	QueryWisdom()
--	SetWisdom(value)
--	QueryCNR()
--	SetCNR(value)
--	QueryFace()
--	SetFace(value)
--	QueryShape()
--	SetShap(value)

function PetBedge_InnerInit(pet_tid,pet_item,pet_ess,pet)
	--�ڲ�ģ���ʼ��,�����ڳ����Ƶ�����
	pet.__ID = pet_tid;
	pet.__ITEM = pet_item;
	pet.__ESS = pet_ess;

	pet.QueryData			= __ABASE_PETBEDGE_QueryInnerData;
	pet.GetDataCount		= __ABASE_PETBEDGE_GetInnerDataCount;
	pet.UpdateData		 	= __ABASE_PETBEDGE_SetInnerData;
	pet.ClearData			= __ABASE_PETBEDGE_ClearInnerData;

	pet.QueryLevel			= __ABASE_PETBEDGE_QueryLevel;
	pet.SetLevel			= __ABASE_PETBEDGE_SetLevel;
	pet.QueryExp		 	= __ABASE_PETBEDGE_QueryExp;
	pet.SetExp		 	= __ABASE_PETBEDGE_SetExp;
	pet.QueryCurHP			= __ABASE_PETBEDGE_QueryCurHP;
	pet.SetCurHP			= __ABASE_PETBEDGE_SetCurHP;
	pet.QueryCurVigor	 	= __ABASE_PETBEDGE_QueryCurVigor;
	pet.SetCurVigor		 	= __ABASE_PETBEDGE_SetCurVigor;
	pet.QueryStar			= __ABASE_PETBEDGE_QueryStar;
	pet.SetStar			= __ABASE_PETBEDGE_SetStar;
	pet.QueryMainType		= __ABASE_PETBEDGE_QueryMainType;
	pet.SetMainType			= __ABASE_PETBEDGE_SetMainType;
	pet.QueryElement		= __ABASE_PETBEDGE_QueryElement;
	pet.SetElement			= __ABASE_PETBEDGE_SetElement;
	pet.QueryIdentify		= __ABASE_PETBEDGE_QueryIdentify;
	pet.SetIdentify			= __ABASE_PETBEDGE_SetIdentify;
	pet.QueryRace			= __ABASE_PETBEDGE_QueryRace;
	pet.SetRace			= __ABASE_PETBEDGE_SetRace;
	pet.QueryHoroscope		= __ABASE_PETBEDGE_QueryHoroscope;
	pet.SetHoroscope		= __ABASE_PETBEDGE_SetHoroscope;
	pet.QueryCombatAttrInit		= __ABASE_PETBEDGE_QueryCombatAttrInit;
	pet.SetCombatAttrInit		= __ABASE_PETBEDGE_SetCombatAttrInit;
	pet.QueryCombatAttrPotential	= __ABASE_PETBEDGE_QueryCombatAttrPotential;
	pet.SetCombatAttrPotential	= __ABASE_PETBEDGE_SetCombatAttrPotential;
	pet.QueryCombatAttrCur		= __ABASE_PETBEDGE_QueryCombatAttrCur;
	pet.SetCombatAttrCur		= __ABASE_PETBEDGE_SetCombatAttrCur;
	pet.QueryExtraDamage		= __ABASE_PETBEDGE_QueryExtraDamage;
	pet.SetExtraDamage		= __ABASE_PETBEDGE_SetExtraDamage;
	pet.QueryExtraDamageReduce	= __ABASE_PETBEDGE_QueryExtraDamageReduce;
	pet.SetExtraDamageReduce	= __ABASE_PETBEDGE_SetExtraDamageReduce;
	pet.QueryCritRate		= __ABASE_PETBEDGE_QueryCritRate;
	pet.SetCritRate			= __ABASE_PETBEDGE_SetCritRate;
	pet.QueryCirtDamage		= __ABASE_PETBEDGE_QueryCritDamage;
	pet.SetCritDamage		= __ABASE_PETBEDGE_SetCritDamage;
	pet.QueryMaxHungerPoint		= __ABASE_PETBEDGE_QueryMaxHungerPoint;
	pet.SetMaxHungerPoint		= __ABASE_PETBEDGE_SetMaxHungerPoint;
	pet.QueryCurHungerPoint		= __ABASE_PETBEDGE_QueryCurHungerPoint;
	pet.SetCurHungerPoint		= __ABASE_PETBEDGE_SetCurHungerPoint;
	pet.QueryMaxHonorPoint		= __ABASE_PETBEDGE_QueryMaxHonorPoint;
	pet.SetMaxHonorPoint		= __ABASE_PETBEDGE_SetMaxHonorPoint;
	pet.QueryCurHonorPoint		= __ABASE_PETBEDGE_QueryCurHonorPoint;
	pet.SetCurHonorPoint		= __ABASE_PETBEDGE_SetCurHonorPoint;
	pet.QueryAge			= __ABASE_PETBEDGE_QueryAge;
	pet.SetAge			= __ABASE_PETBEDGE_SetAge;
	pet.QueryLife			= __ABASE_PETBEDGE_QueryLife;
	pet.SetLife			= __ABASE_PETBEDGE_SetLife;
	pet.QuerySkillID		= __ABASE_PETBEDGE_QuerySkillID;
	pet.SetSkillID			= __ABASE_PETBEDGE_SetSkillID;
	pet.QuerySkillLevel		= __ABASE_PETBEDGE_QuerySkillLevel;
	pet.SetSkillLevel		= __ABASE_PETBEDGE_SetSkillLevel;
	pet.QueryTalent			= __ABASE_PETBEDGE_QueryQueryTalent;
	pet.SetTalent			= __ABASE_PETBEDGE_SetTalent;
	pet.QueryAcuity			= __ABASE_PETBEDGE_QueryAcuity;
	pet.SetAcuity			= __ABASE_PETBEDGE_SetAcuity;
	pet.QueryStamina		= __ABASE_PETBEDGE_QueryStamina;
	pet.SetStamina			= __ABASE_PETBEDGE_SetStamina;
	pet.QuerySawy			= __ABASE_PETBEDGE_QuerySawy;
	pet.SetSawy			= __ABASE_PETBEDGE_SetSawy;
	pet.QueryDowry			= __ABASE_PETBEDGE_QueryDowry;
	pet.SetDowry			= __ABASE_PETBEDGE_SetDowry;
	pet.QueryWisdom			= __ABASE_PETBEDGE_QueryWisdom;
	pet.SetWisdom			= __ABASE_PETBEDGE_SetWisdom;
	pet.QueryCNR			= __ABASE_PETBEDGE_QueryCNR;
	pet.SetCNR			= __ABASE_PETBEDGE_SetCNR;
	pet.QueryFace			= __ABASE_PETBEDGE_QueryFace;
	pet.SetFace			= __ABASE_PETBEDGE_SetFace;
	pet.QueryShape			= __ABASE_PETBEDGE_QueryShape;
	pet.SetShape			= __ABASE_PETBEDGE_SetShape;
end

function PetBedge_Init_Entrance(pet_tid,pet_item,origin,pet_ess,master_level)
	--����������
	local pet = {};
	PetBedge_InnerInit(pet_tid,pet_item,pet_ess,pet);
	return PetBedgeInit(pet_tid,pet,origin,master_level);
	-- ���ظ�ʽ return pet_tid
end

function PetBedge_LevelUp_Entrance(pet_tid,pet_item,origin,pet_ess)
	--��������
	local pet = {};
	PetBedge_InnerInit(pet_tid,pet_item,pet_ess,pet);
	return PetBedgeLevelUp(pet_tid,pet,origin);
	-- ���ظ�ʽ return pet_tid
end

function PetBedge_Rebuild_Entrance(pet_tid,pet_item,origin,pet_ess,master_level)
	--��������
	local pet = {};
	PetBedge_InnerInit(pet_tid,pet_item,pet_ess,pet);
	return PetBedgeRebuild(pet_tid,pet,origin,master_level);
	-- ���ظ�ʽ return pet_tid
end

function PetBedge_Adopt_Entrance(pet_tid,pet_item,origin,pet_ess)
	--��������
	local pet = {};
	PetBedge_InnerInit(pet_tid,pet_item,pet_ess,pet);
	return PetBedgeAdopt(pet_tid,pet,origin);
	-- ���ظ�ʽ return pet_tid
end

function PetBedge_Free_Entrance(pet_tid,pet_item,pet_ess,origin)
	--�������
	local pet = {};
	PetBedge_InnerInit(pet_tid,pet_item,pet_ess,pet);
	return PetBedgeFree(pet_tid,pet,origin);
	--���ظ�ʽ return pet_tid,channel_id,msg_id,item_tid,item_count;
end

function PetBedge_Combine_Entrance(pet_tid,cid,aid,pet_ess,oess)
	--����������
	local pet_in = {};
	local pet_out = {};
	PetBedge_InnerInit(pet_tid,nil,pet_ess,pet_in);
	PetBedge_InnerInit(0,nil,oess,pet_out);
	return PetBedgeCombine(pet_tid,pet_in,pet_out,cid,aid);
	--���ظ�ʽ return new_pet_tid,channel_id,msg_id;
end

function PetBedge_AskCollectRequirement_Entrance(pet_tid,pet_item,pet_ess,collecttype)
	--�����ѯ�ɼ�����
	local pet = {};
	PetBedge_InnerInit(pet_tid,pet_item,pet_ess,pet);
	return PetBedgeAskCollectRequirement(pet_tid,pet,collecttype);
	--return item_tid,item_count;
end

function PetBedge_Collect_Entrance(pet_tid,pet_item,pet_ess,collecttype,mode)
	--����ɼ�
	local pet = {};
	PetBedge_InnerInit(pet_tid,pet_item,pet_ess,pet);
	return PetBedgeCollect(pet_tid,pet,collecttype,mode);
	--return pet_tid,channel_id,msg_id,item_tid,item_count;
end

function PetBedge_Dead_Entrance(pet_tid,pet_item,pet_ess,dead_type)
	--��������
	local pet = {};
	PetBedge_InnerInit(pet_tid,pet_item,pet_ess,pet);
	return PetBedgeDead(pet_tid,pet,dead_type);
	--return pet_tid;
end

function PetBedge_Talk_Entrance(pet_tid,pet_item,pet_ess)
	--��������
	local pet = {};
	PetBedge_InnerInit(pet_tid,pet_item,pet_ess,pet);
	return PetBedgeTalk(pet_tid,pet);
	--return pet_tid,channel_id,msg_id;
end

------------------------------------------------------------------------
function PetBedgeInit(pet_tid,pet,origin,master_level)
	--�߻���Ҫʵ�ֵĽӿ�
	print("�߻�����ʵ�ֵĽӿ� PetBedgeInit(pet_tid,p,origin,master_level)!!!");
	return pet_tid;
end

function PetBedgeLevelUp(pet_tid,pet,origin)
	print("�߻�����ʵ�ֵĽӿ� PetBedgeLevelUp(pet_tid,pet,origin)!!!");
	return pet_tid;
end

function PetBedgeRebuild(pet_tid,pet,origin,master_level)
	print("�߻�����ʵ�ֵĽӿ� PetBedgeRebuild(pet_tid,pet,origin,master_level)!!!");
	return pet_tid;
end

function PetBedgeAdopt(pet_tid,pet,origin)
	print("�߻�����ʵ�ֵĽӿ� PetBedgeAdopt(pet_tid,pet,origin)!!!");
	return pet_tid;
end
	
function PetBedgeFree(pet_tid,pet,origin)
	--�߻���Ҫʵ�ֵĽӿ�
	print("�߻�����ʵ�ֵĽӿ� PetBedgeFree(pet_tid,pet,origin)!!!");
	return pet_tid,1,2,3,4;
end

function PetBedgeCombine(pet_tid,pet_in,pet_out,cid,aid)
	--�߻���Ҫʵ�ֵĽӿ�
	print("�߻�����ʵ�ֵĽӿ� PetBedgeCombine(pet_tid,pet_in,pet_out,cid,aid)!!!");
	return pet_tid,2,3
end

function PetBedgeAskCollectRequirement(pet_tid,pet,collecttype)
	--�߻���Ҫʵ�ֵĽӿ�
	print("�߻�����ʵ�ֵĽӿ� PetBedgeAskCollectRequirement(pet_tid,pet,collecttype)!!!");
	return 0,0;
end

function PetBedgeCollect(pet_tid,pet,collecttype,mode)
	--�߻���Ҫʵ�ֵĽӿ�
	print("�߻�����ʵ�ֵĽӿ� PetBedgeCollect(pet_tid,pet,collecttype,mode)!!!");
	return pet_tid,3,4,5,6
end

function PetBedgeDead(pet_tid,pet)
	--�߻���Ҫʵ�ֵĽӿ�
	print("�߻�����ʵ�ֵĽӿ� PetBedgeDead(pet_tid,pet)!!!");
	return pet_tid
end

function PetBedgeTalk(pet_tid,pet)
	--�߻���Ҫʵ�ֵĽӿ�
	print("�߻�����ʵ�ֵĽӿ� PetBedgeTalk(pet_tid,pet)!!!");
	return pet_tid,2,3
end

xdofile("script/petbedge_interface.lua");
xdofile("script/petbedge_grades.lua")
xdofile("script/petbedge_skills.lua")
xdofile("script/petbedge_combine.lua")
xdofile("script/petbedge_free.lua")
xdofile("script/petbedge_collect.lua")

