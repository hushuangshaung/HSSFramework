
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg
{
	public sealed partial class LanguageTable_zh_cnData : Luban.BeanBase
	{
		public LanguageTable_zh_cnData(ByteBuf _buf) 
		{
			Key = _buf.ReadString();
			Text = _buf.ReadString();
			UUID = _buf.ReadString();
		}

		public static LanguageTable_zh_cnData DeserializeLanguageTable_zh_cnData(ByteBuf _buf)
		{
			return new LanguageTable_zh_cnData(_buf);
		}

		public readonly string Key;
		public readonly string Text;
		public readonly string UUID;
	   
		public const int __ID__ = -1198944483;
		public override int GetTypeId() => __ID__;

		public  void ResolveRef(Tables tables)
		{
		}

		public override string ToString()
		{
			return "{ "
			+ "key:" + Key + ","
			+ "text:" + Text + ","
			+ "UUID:" + UUID + ","
			+ "}";
		}
	}

}

