
--����ű�
--�߻�Ӧ��ʵ����Ӧ�Ľӿ�

--��Ա��������ʵ�֣���������ScaleΪΪǧ�ֱȣ�
function InitVipTransformProp(player)
	local nVIPLevel
	local sVIPName = {"","һ����Ա","������Ա","������Ա","�ļ���Ա","�弶��Ա","��ʯ��Ա"}
	
	nVIPLevel		= player:GetVIPLevel()
	if nVIPLevel == 1 then
		player:AddScaleHP(100) --����1/10HP
		player:AddScaleMP(100) --����1/10MP
		player:AddScaleDefense(100) --����1/10����
		player:AddScaleAttack(100) --����1/10������
	elseif nVIPLevel == 2 then
		player:AddScaleHP(200) --����2/10HP
		player:AddScaleMP(200) --����2/10MP
		player:AddScaleDefense(200) --����2/10����
		player:AddScaleAttack(200) --����2/10������
	elseif nVIPLevel == 3 then
		player:AddScaleHP(300) --����3/10HP
		player:AddScaleMP(300) --����3/10MP
		player:AddScaleDefense(300) --����3/10����
		player:AddScaleAttack(300) --����3/10������
	elseif nVIPLevel == 4 then
		player:AddScaleHP(400) --����4/10HP
		player:AddScaleMP(400) --����4/10MP
		player:AddScaleDefense(400) --����4/10����
		player:AddScaleAttack(400) --����4/10������
	elseif nVIPLevel == 5 then
		player:AddScaleHP(500) --����5/10HP
		player:AddScaleMP(500) --����5/10MP
		player:AddScaleDefense(500) --����5/10����
		player:AddScaleAttack(500) --����5/10������
	elseif nVIPLevel == 6 then
		player:AddScaleHP(600) --����6/10HP
		player:AddScaleMP(600) --����6/10MP
		player:AddScaleDefense(600) --����6/10����
		player:AddScaleAttack(600) --����6/10������
	end
	return 0
end
function Init_Transform_Skill(template_id, transform_type, level, exp_level, player_imp)
	local player = {}
	Object_InnerInit(player_imp, player, -1)

	--return InitTransformSkill(template_id, transform_type, level, exp_level, player)
	InitTransformSkill(template_id, transform_type, level, exp_level, player)
	return InitVipTransformProp(player)
end


function Init_Normal_Transform_Prop(template_id, transform_type, level, exp_level, player_imp)
	local player = {}
	Object_InnerInit(player_imp, player, 0)

	--return InitNormalTransformProp(template_id, transform_type, level, exp_level, player)
	InitNormalTransformProp(template_id, transform_type, level, exp_level, player)
	return InitVipTransformProp(player)
end
		
function Init_Replace_Transform_Prop(template_id, transform_type, level, exp_level, player_imp)
	local player = {}
	Object_InnerInit(player_imp, player, 0)

	--return InitReplaceTransformProp(template_id, transform_type, level, exp_level, player)
	InitReplaceTransformProp(template_id, transform_type, level, exp_level, player)
	return InitVipTransformProp(player)
end

xdofile("object_script.lua")
xdofile("script/transform_interface.lua")
