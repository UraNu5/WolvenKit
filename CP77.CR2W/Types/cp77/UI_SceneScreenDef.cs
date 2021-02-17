using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_SceneScreenDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("AnimName")] public gamebbScriptID_CName AnimName { get; set; }

		public UI_SceneScreenDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}