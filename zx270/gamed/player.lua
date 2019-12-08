-- 接口说明

-- PlayerQuerySkilllvl(skill_id)
-- PlayerQueryPosition()


	
function Player_InnerInit(player_obj)
	PLAYER_OBJ = player_obj; 
end

-- 宠物装备强化
function PetEquip_Refine_Entrance(item_type, stone_type)
   	return PetEquipRefine(item_type, stone_type);	
	--返回格式 return item_tid 
end	


-- 抓宠物
function Player_CatchPet_Entrance(monster_id, monster_level, monster_raceinfo, monster_catchdifficulty, monster_hp, player_level, player_obj)
	Player_InnerInit(player_obj);
	return PetBedgeCatch(monster_id, monster_level, monster_raceinfo, monster_catchdifficulty, monster_hp, player_level);
	--返回格式 return pet_tid, msg_channel, msg_id	
end



-- 生成额外获得
function ExtGain_Produce_Entrance(recipe_id, player_level, player_gender, player_prof, player_obj)
	Player_InnerInit(player_obj);
	return ExtGainOfCreate(recipe_id, player_level, player_gender, player_prof);
	--返回格式 return item_id, item_count, msg_id	
	
end
	

--探索获得
function Discover_Gain_Entrance(player_level, player_gender, player_prof, discover_type, player_obj)
	Player_InnerInit(player_obj);
	return DiscoveryGain(player_level, player_gender, player_prof, discover_type);
	--返回格式 return gain_id, item_count, msg_id	
end
	
function PlayerQuerySkilllvl(skill_id)
	return	__PlayerQuerySkillLevel(PLAYER_OBJ, skill_id);
end

function PlayerQueryPosition()
	return __PlayerQueryPosition(PLAYER_OBJ);
end


xdofile("script/player_interface.lua");
