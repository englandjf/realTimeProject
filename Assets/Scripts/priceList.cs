using UnityEngine;
using System.Collections;

public class priceList{

	//private string _name;
	private int _metalAmt;
	private int _powerAmt;
	//public int nameValue {get{return _name;}set{_name = value;}}
	public int metalAmt {get{return _metalAmt;}set{_metalAmt = value;}}
	public int powerAmt {get{return _powerAmt;}set{_powerAmt = value;}}

	public priceList(int metalA,int powerA)
	{
		_metalAmt = metalA;
		_powerAmt = powerA;
	}


}
