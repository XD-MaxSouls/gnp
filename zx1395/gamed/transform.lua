
--变身脚本
--策划应该实现相应的接口

--会员增加属性实现（增加属性Scale为为千分比）
function InitVipTransformProp(player)
	local nVIPLevel
	local sVIPName = {"","一级会员","二级会员","三级会员","四级会员","五级会员","钻石会员"}
	
	nVIPLevel		= player:GetVIPLevel()
	if nVIPLevel == 1 then
		player:AddScaleHP(100) --增加1/10HP
		player:AddScaleMP(100) --增加1/10MP
		player:AddScaleDefense(100) --增加1/10防御
		player:AddScaleAttack(100) --增加1/10攻击力
	elseif nVIPLevel == 2 then
		player:AddScaleHP(200) --增加2/10HP
		player:AddScaleMP(200) --增加2/10MP
		player:AddScaleDefense(200) --增加2/10防御
		player:AddScaleAttack(200) --增加2/10攻击力
	elseif nVIPLevel == 3 then
		player:AddScaleHP(300) --增加3/10HP
		player:AddScaleMP(300) --增加3/10MP
		player:AddScaleDefense(300) --增加3/10防御
		player:AddScaleAttack(300) --增加3/10攻击力
	elseif nVIPLevel == 4 then
		player:AddScaleHP(400) --增加4/10HP
		player:AddScaleMP(400) --增加4/10MP
		player:AddScaleDefense(400) --增加4/10防御
		player:AddScaleAttack(400) --增加4/10攻击力
	elseif nVIPLevel == 5 then
		player:AddScaleHP(500) --增加5/10HP
		player:AddScaleMP(500) --增加5/10MP
		player:AddScaleDefense(500) --增加5/10防御
		player:AddScaleAttack(500) --增加5/10攻击力
	elseif nVIPLevel == 6 then
		player:AddScaleHP(600) --增加6/10HP
		player:AddScaleMP(600) --增加6/10MP
		player:AddScaleDefense(600) --增加6/10防御
		player:AddScaleAttack(600) --增加6/10攻击力
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
