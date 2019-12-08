--对象脚本

function Object_InnerInit(imp, obj, init_type)
	obj.__IMP = imp

	--查找属性
	if(init_type == 0 or init_type == 1) then
		obj.GetLevel = __ABASE_OBJECT_GetLevel
		obj.GetHP = __ABASE_OBJECT_GetHP
		obj.GetMP = __ABASE_OBJECT_GetMP
		obj.GetCurHP = __ABASE_OBJECT_GetCurHP
		obj.GetCurMP = __ABASE_OBJECT_GetCurMP
		obj.GetSpeed = __ABASE_OBJECT_GetSpeed
		obj.GetCrit = __ABASE_OBJECT_GetCrit
		obj.GetDamage = __ABASE_OBJECT_GetDamage
		obj.GetAttack = __ABASE_OBJECT_GetAttack
		obj.GetDefense = __ABASE_OBJECT_GetDefense
		obj.GetArmor = __ABASE_OBJECT_GetArmor
		obj.GetResistance = __ABASE_OBJECT_GetResistance
		obj.GetAntiCrit = __ABASE_OBJECT_GetAntiCrit
		obj.GetAttackRange = __ABASE_OBJECT_GetAttackRange
		obj.GetSkillRate = __ABASE_OBJECT_GetSkillRate
		obj.GetCircleMemberCnt = __ABASE_OBJECT_GetCircleMemberCnt
	end

	-- 设置属性	
	if(init_type == 0 or init_type == 2) then
		obj.SetLevel = __ABASE_OBJECT_SetLevel
		obj.SetHP = __ABASE_OBJECT_SetHP
		obj.SetMP = __ABASE_OBJECT_SetMP
		obj.SetCurHP = __ABASE_OBJECT_SetCurHP
		obj.SetCurMP = __ABASE_OBJECT_SetCurMP
		obj.SetSpeed = __ABASE_OBJECT_SetSpeed
		obj.SetCrit = __ABASE_OBJECT_SetCrit
		obj.SetDamage = __ABASE_OBJECT_SetDamage
		obj.SetAttack = __ABASE_OBJECT_SetAttack
		obj.SetDefense = __ABASE_OBJECT_SetDefense
		obj.SetArmor = __ABASE_OBJECT_SetArmor
		obj.SetResistance = __ABASE_OBJECT_SetResistance
		obj.SetAttackRange = __ABASE_OBJECT_SetAttackRange 
		obj.SetAntiCrit = __ABASE_OBJECT_SetAntiCrit
		obj.SetSkillRate = __ABASE_OBJECT_SetSkillRate
		obj.SetAntiInvisibleRate = __ABASE_OBJECT_SetAntiInvisibleRate
	end

	-- 改变属性	
	if(init_type == 0 or init_type == 3) then
		obj.AddHP = __ABASE_OBJECT_AddHP 
		obj.AddMP = __ABASE_OBJECT_AddMP
		obj.AddDefense = __ABASE_OBJECT_AddDefense
		obj.AddAttack = __ABASE_OBJECT_AddAttack
		obj.AddArmor = __ABASE_OBJECT_AddArmor
		obj.AddDamage = __ABASE_OBJECT_AddDamage
		obj.AddResistance = __ABASE_OBJECT_AddResistance
		obj.AddCrit = __ABASE_OBJECT_AddCrit
		obj.AddSpeed = __ABASE_OBJECT_AddSpeed
		obj.AddAntiCrit = __ABASE_OBJECT_AddAntiCrit
		obj.AddSkillRate = __ABASE_OBJECT_AddSkillRate
		obj.AddAttackRange = __ABASE_OBJECT_AddAttackRange
		obj.AddScaleHP = __ABASE_OBJECT_AddScaleHP
		obj.AddScaleMP = __ABASE_OBJECT_AddScaleMP
		obj.AddScaleDefense = __ABASE_OBJECT_AddScaleDefense
		obj.AddScaleAttack = __ABASE_OBJECT_AddScaleAttack
		obj.AddScaleArmor = __ABASE_OBJECT_AddScaleArmor
		obj.AddScaleDamage = __ABASE_OBJECT_AddScaleDamage
		obj.AddScaleSpeed = __ABASE_OBJECT_AddScaleSpeed
		obj.AddScaleResistance = __ABASE_OBJECT_AddScaleResistance
	end
	
	obj.PlayerQueryPosition = __ABASE_OBJECT_GetPosition
	obj.PlayerQuerySkilllvl = __ABASE_OBJECT_GetSkillLevel
	obj.PlayerQueryCultivation = __ABASE_OBJECT_GetCultivation
	obj.AddSkillProficiency = __ABASE_OBJECT_AddSkillProficiency
	obj.AddReputation = __ABASE_OBJECT_AddReputation
	obj.AddTransformSkill = __ABASE_OBJECT_AddTransformSkill
	
end


function Player_InnerInit(imp, obj)
	obj.__IMP = imp

	--查找属性
	obj.GetName = __ABASE_OBJECT_GetName
	obj.GetLevel = __ABASE_OBJECT_GetLevel
	obj.GetWorldTag = __ABASE_OBJECT_GetWorldTag
	obj.GetWorldPos = __ABASE_OBJECT_GetWorldPos
	obj.GetFactionId = __ABASE_OBJECT_GetFactionId
	obj.GetEnemyFactionId = __ABASE_OBJECT_GetEnemyFactionId
	obj.GetFamilyId = __ABASE_OBJECT_GetFamilyId
	obj.GetMasterId = __ABASE_OBJECT_GetMasterId
	obj.GetSectId = __ABASE_OBJECT_GetSectId
	obj.GetZoneId = __ABASE_OBJECT_GetZoneId
	obj.GetMafiaId = __ABASE_OBJECT_GetMafiaId
	obj.GetCircleId = __ABASE_OBJECT_GetCircleId
	obj.GetMafiaRank = __ABASE_OBJECT_GetMafiaRank
	obj.GetRank = __ABASE_OBJECT_GetRank
	obj.GetCurTitle = __ABASE_OBJECT_GetCurTitle
	obj.GetPkLevel = __ABASE_OBJECT_GetPkLevel
	obj.GetTrashBoxCapacity = __ABASE_OBJECT_GetTrashBoxCapacity
	obj.GetMafiaTrashBoxCapacity = __ABASE_OBJECT_GetMafiaTrashBoxCapacity
	obj.GetTrashBoxMoney = __ABASE_OBJECT_GetTrashBoxMoney
	obj.GetMoney = __ABASE_OBJECT_GetMoney
	obj.GetBonus = __ABASE_OBJECT_GetBonus
	obj.GetRebornCount = __ABASE_OBJECT_GetRebornCount
	obj.GetPlayTime = __ABASE_OBJECT_GetPlayTime
	obj.GetLoginTimeStamp = __ABASE_OBJECT_GetLoginTimeStamp
	
	obj.GetVIPLevel = __ABASE_OBJECT_GetVIPLevel
	obj.GetEquipment= __ABASE_OBJECT_GetEquipment
	obj.GetHP = __ABASE_OBJECT_GetHP
	obj.GetMP = __ABASE_OBJECT_GetMP
	obj.GetCurHP = __ABASE_OBJECT_GetCurHP
	obj.GetCurMP = __ABASE_OBJECT_GetCurMP
	obj.GetSpeed = __ABASE_OBJECT_GetSpeed
	obj.GetCrit = __ABASE_OBJECT_GetCrit
	obj.GetDamage = __ABASE_OBJECT_GetDamage
	obj.GetAttack = __ABASE_OBJECT_GetAttack
	obj.GetDefense = __ABASE_OBJECT_GetDefense
	obj.GetArmor = __ABASE_OBJECT_GetArmor
	obj.GetResistance = __ABASE_OBJECT_GetResistance
	obj.GetAntiCrit = __ABASE_OBJECT_GetAntiCrit
	obj.GetAttackRange = __ABASE_OBJECT_GetAttackRange
	obj.GetSkillRate = __ABASE_OBJECT_GetSkillRate
	obj.GetCircleMemberCnt = __ABASE_OBJECT_GetCircleMemberCnt

	-- 设置属性	
	obj.SetLevel = __ABASE_OBJECT_SetLevel
	obj.SetHP = __ABASE_OBJECT_SetHP
	obj.SetMP = __ABASE_OBJECT_SetMP
	obj.SetCurHP = __ABASE_OBJECT_SetCurHP
	obj.SetCurMP = __ABASE_OBJECT_SetCurMP
	obj.SetSpeed = __ABASE_OBJECT_SetSpeed
	obj.SetCrit = __ABASE_OBJECT_SetCrit
	obj.SetDamage = __ABASE_OBJECT_SetDamage
	obj.SetAttack = __ABASE_OBJECT_SetAttack
	obj.SetDefense = __ABASE_OBJECT_SetDefense
	obj.SetArmor = __ABASE_OBJECT_SetArmor
	obj.SetResistance = __ABASE_OBJECT_SetResistance
	obj.SetAttackRange = __ABASE_OBJECT_SetAttackRange 
	obj.SetAntiCrit = __ABASE_OBJECT_SetAntiCrit
	obj.SetSkillRate = __ABASE_OBJECT_SetSkillRate
	obj.SetAntiInvisibleRate = __ABASE_OBJECT_SetAntiInvisibleRate
	obj.SetInventorySize = __ABASE_OBJECT_SetInventorySize
	obj.SetPocketSize = __ABASE_OBJECT_SetPocketSize
	obj.SetStorehouseSize = __ABASE_OBJECT_SetStorehouseSize
	obj.SetMountInventorySize = __ABASE_OBJECT_SetMountInventorySize
	obj.SetPetInventorySize = __ABASE_OBJECT_SetPetInventorySize

	-- 改变属性	
	obj.AddHP = __ABASE_OBJECT_AddHP 
	obj.AddMP = __ABASE_OBJECT_AddMP
	obj.AddDefense = __ABASE_OBJECT_AddDefense
	obj.AddAttack = __ABASE_OBJECT_AddAttack
	obj.AddArmor = __ABASE_OBJECT_AddArmor
	obj.AddDamage = __ABASE_OBJECT_AddDamage
	obj.AddResistance = __ABASE_OBJECT_AddResistance
	obj.AddCrit = __ABASE_OBJECT_AddCrit
	obj.AddSpeed = __ABASE_OBJECT_AddSpeed
	obj.AddAntiCrit = __ABASE_OBJECT_AddAntiCrit
	obj.AddSkillRate = __ABASE_OBJECT_AddSkillRate
	obj.AddAttackRange = __ABASE_OBJECT_AddAttackRange
	obj.AddScaleHP = __ABASE_OBJECT_AddScaleHP
	obj.AddScaleMP = __ABASE_OBJECT_AddScaleMP
	obj.AddScaleDefense = __ABASE_OBJECT_AddScaleDefense
	obj.AddScaleAttack = __ABASE_OBJECT_AddScaleAttack
	obj.AddScaleArmor = __ABASE_OBJECT_AddScaleArmor
	obj.AddScaleDamage = __ABASE_OBJECT_AddScaleDamage
	obj.AddScaleSpeed = __ABASE_OBJECT_AddScaleSpeed
	obj.AddScaleResistance = __ABASE_OBJECT_AddScaleResistance
	obj.AddSkillProficiency = __ABASE_OBJECT_AddSkillProficiency
	obj.AddReputation = __ABASE_OBJECT_AddReputation
	obj.AddTransformSkill = __ABASE_OBJECT_AddTransformSkill
	obj.AddMallCash = __ABASE_OBJECT_AddMallCash
	
	obj.PlayerQueryPosition = __ABASE_OBJECT_GetPosition
	obj.PlayerQuerySkilllvl = __ABASE_OBJECT_GetSkillLevel
	obj.PlayerQueryCultivation = __ABASE_OBJECT_GetCultivation
	
	obj.GiveItem = __ABASE_OBJECT_GiveItem
	obj.FindItem = __ABASE_OBJECT_FindItem
	obj.SayText = __ABASE_OBJECT_SayText
	obj.BroadcastText = __ABASE_OBJECT_BroadcastText
	
end

function Matrix_InnerInit(obj)
	obj.__MATRIX = __ABASE_MATRIX_GetInstance()
	obj.GetServerIndex = __ABASE_MATRIX_GetServerIndex
	obj.GetServerName = __ABASE_MATRIX_GetServerName
	obj.GetSystemTime = __ABASE_MATRIX_GetSystemTime
	obj.FindPlayer = __ABASE_MATRIX_FindPlayer
	obj.BroadCastItemAdd = __ABASE_MATRIX_BroadCastItemAdd
	obj.BroadCastItemDel = __ABASE_MATRIX_BroadCastItemDel
	obj.BroadCastItemClr = __ABASE_MATRIX_BroadCastItemClr
	obj.BroadCastItemFnd = __ABASE_MATRIX_BroadCastItemFnd
end

function DataMan_InnerInit(obj)
	obj.__DATAMAN = __ABASE_DATAMAN_GetInstance()
	obj.GetDataName = __ABASE_DATAMAN_GetDataName
	obj.SetDataMonster = __ABASE_DATAMAN_SetDataMonster
	obj.SetDataTranscription = __ABASE_DATAMAN_SetDataTranscription
	obj.SetDataBattleField = __ABASE_DATAMAN_SetDataBattleField
end