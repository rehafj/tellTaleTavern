using UnityEngine;
using System.Collections;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;

public class MarketItem  {

//might use this later - for future versions.
	[XmlAttribute("Type")]
	public string type; //meat/brew/bread
	[XmlElement("Title")]
	public string  titile;
	[XmlElement("Discription")]
	public string discription; //
	[XmlElement("Count")]
	public int count;//stock in storeTy
	[XmlElement("Price")]
	public int price;


}
