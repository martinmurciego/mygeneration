using System;using Zeus.Data;namespace Zeus.UserInterface{	public interface IGuiGrid : IGuiControl	{		SimpleTable DataSource { get; set; }		void BindData(object dataSource);	}}