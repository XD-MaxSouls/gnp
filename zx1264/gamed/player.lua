
-- ����װ��ǿ��
function PetEquip_Refine_Entrance(item_type, stone_type)
   	return PetEquipRefine(item_type, stone_type);	
	--���ظ�ʽ return item_tid 
end	


-- ץ����
function Player_CatchPet_Entrance(monster_id, monster_level, monster_raceinfo, monster_catchdifficulty, monster_hp, player_level, player_imp)
	local player = {}
	Object_InnerInit(player_imp, player, -1)
	return PetBedgeCatch(monster_id, monster_level, monster_raceinfo, monster_catchdifficulty, monster_hp, player_level, player);
	--���ظ�ʽ return pet_tid, msg_channel, msg_id	
end



-- ���ɶ�����
function ExtGain_Produce_Entrance(recipe_id, player_level, player_gender, player_prof, player_imp)
	local player = {}
	Object_InnerInit(player_imp, player, -1)
	return ExtGainOfCreate(recipe_id, player_level, player_gender, player_prof, player);
	--���ظ�ʽ return item_id, item_count, msg_id	
	
end
	

--̽�����
function Discover_Gain_Entrance(player_level, player_gender, player_prof, discover_type, player_imp)
	local player = {}
	Object_InnerInit(player_imp, player, -1)
	return DiscoveryGain(player_level, player_gender, player_prof, discover_type, player);
	--���ظ�ʽ return gain_id, item_count, msg_id	
end
	


xdofile("object_script.lua")
xdofile("script/player_interface.lua");
xdofile("script/player_refineequip.lua");

