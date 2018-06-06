"
普通一招：

SkillButtonNormal.OnPointerDown() Function
	SkillButtonBase.OnPointerDown() Function
	SkillButtonBase.OnClickSkillButton() Function
	BattlePage_SkillButton.OnSkillButtonClick() Function
	SceneEvent_Battle_SceneToLogic_HerosSkillRequest Event
		LogicEventHandler.OnAttackAction() Function
		LogicEventHandler.SendAttackClickCmd() Function
		GameCommandType.UseSkill GameCommand
		GameCommandManager.DoHandleCommand() Function
		LogicPlayerBaseObject.HandleCommand() Function
		LogicEntityObject.HandleCommand() Function
		EntityStateController.HandleCommand() Function
		CharacterIdleState.HandleCommand() Function
		EntityBaseState.DoUseSkillCommand() Function
		HeroSkillManager.UseSkill(skillID) Function
		HeroSkillManager.UseSkill(EngineSkill) Function
		EngineSkill.BeginSkill() Function
		EngineSkill.OnStartSkill() Function (关键函数，所有相关功能都在这里开始)

	BattlePage_SkillButton.OnSkillButtonPress() Function
		SceneEvent_Battle_SceneToLogic_HerosSkillPressRequest Event
			LogicEventHandler.OnPressedAttackAction() Function
			LogicEventHandler.OnPressedDownAttackAction() Function

"
