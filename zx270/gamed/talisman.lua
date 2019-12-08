-- Mcncc.com 出品
function Talisman_Entrance_Init(id, item, ess,t)
	t.__ID = id;
	t.__ITEM = item;
	t.__ESS = ess;
	t.QueryLevel 	= __ABASE_TALISMAN_QueryLevel;
	t.QueryExp 	= __ABASE_TALISMAN_QueryExp;

	t.QueryData 	= __ABASE_TALISMAN_QueryInnerData;
	t.GetDataCount = __ABASE_TALISMAN_GetInnerDataCount;
	t.UpdateData  	= __ABASE_TALISMAN_SetInnerData;
	t.ClearData  	= __ABASE_TALISMAN_ClearInnerData;

	t.SetAddon 	= __ABASE_TALISMAN_AddAddon;
	t.SetStamina 	= __ABASE_TALISMAN_SetStamina ;
	t.SetQuality 	= __ABASE_TALISMAN_SetQuality ;
	t.SetHP 	= __ABASE_TALISMAN_SetHP;
	t.SetMP 	= __ABASE_TALISMAN_SetMP;
	t.SetAttackRate = __ABASE_TALISMAN_SetAttackRate;
	t.SetDamage 	= __ABASE_TALISMAN_SetDamage;
	t.SetDodge 	= __ABASE_TALISMAN_SetDodge;
	t.SetDefense 	= __ABASE_TALISMAN_SetDefense;
	t.SetResistance = __ABASE_TALISMAN_SetResistance;
end
-- Mcncc.com 出品
function Talisman_Entrance(id, item, ess,fname,...)
	local t= {};
	Talisman_Entrance_Init(id, item, ess,t)

	local x = talisman_tab[id];
	if (x ~= nil) then
		x[fname](id, t,...);
		return 1;
	else
		return 0;
	end
end

function Talisman_Output_CreateItem(o, id)
	o.__ID = id;
end

function Talisman_Enchant_Entrance(id,ess,cid,oess)
	local t= {};
	local output= {};
	Talisman_Entrance_Init(id,nil,ess,t);
	Talisman_Entrance_Init(0,nil,oess,output);
	output.__item = t;

	output.InheritCombineLevel = function(tab,x)
		if(x) then
			__ABASE_TALISMAN_SetLevel(output, tab.__item:QueryLevel());
		end
	end
	output.InheritCombineExp = function(tab,x)
		if(x) then
			__ABASE_TALISMAN_SetLevel(output, tab.__item:QueryLevel());
			__ABASE_TALISMAN_SetExp(output, tab.__item:QueryExp());
		end
	end
	
	output.CreateItem = Talisman_Output_CreateItem;
	EnchantTalismans(id,t,cid,output );
	return output.__ID;
end

function Talisman_Combine_Entrance(id1,id2,ess1,ess2,cid,oess,combinevalue)
	local t1= {};
	local t2= {};
	local output= {};
-- Mcncc.com 出品
	Talisman_Entrance_Init(id1,nil,ess1,t1);
	Talisman_Entrance_Init(id2,nil,ess2,t2);
	Talisman_Entrance_Init(0,nil,oess,output);
	output.__item1 = t1;
	output.__item2 = t2;
	output.__talisman_value = combinevalue;
	output.SetCombineValue = function(tab,x)
		tab.__talisman_value = x;
	end

	output.GetCombineValue = function(tab,x)
		return tab.__talisman_value;
	end
		output.InheritCombineLevel = function(tab,x)
		if(x) then
			__ABASE_TALISMAN_SetLevel(output, tab.__item1:QueryLevel());
		end
	end
		output.InheritCombineExp = function(tab, x)
		if(x) then
			__ABASE_TALISMAN_SetLevel(output, tab.__item1:QueryLevel());
			__ABASE_TALISMAN_SetExp(output, tab.__item1:QueryExp());
		end
	end
	output.CreateItem = Talisman_Output_CreateItem;
	CombineTalismans(id1,id2,t1,t2,cid,output);
	return output.__ID, output.__talisman_value;
end


