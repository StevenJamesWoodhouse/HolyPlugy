using System;
using System.Collections.Generic;
using System.Text;

namespace HolyPlugy
{
    public class Item
    {
		private String hexString;
		private byte[] itemArray;
		private bool _isIdentified;
		private bool _isSocketed;
		private bool _isEar;
		private bool _isSimple;
		private bool _isEthereal;
		private bool _isPersonalized;
		private bool _isRuneword;
		private String location;
		private int colNum;
		private int rowNum;
		private String itemType;
		private String binaryString;
		private ComplexData complexData;
		private String hexIndex;
		private int numOfItemsInSockets;

		public Item()
		{

		}

		public Item(String hexString, byte[] itemArray, bool isIdentified, bool isSocketed, bool isEar,
				bool isSimple, bool isEthereal, bool isPersonalized, bool isRuneword, String location,
				int colNum, int rowNum, String itemType, String binaryString, ComplexData complexData, String hexIndex,
				int numOfItemsInSockets)
		{
			//super();
			this.hexString = hexString;
			this.itemArray = itemArray;
			this._isIdentified = isIdentified;
			this._isSocketed = isSocketed;
			this._isEar = isEar;
			this._isSimple = isSimple;
			this._isEthereal = isEthereal;
			this._isPersonalized = isPersonalized;
			this._isRuneword = isRuneword;
			this.location = location;
			this.colNum = colNum;
			this.rowNum = rowNum;
			this.itemType = itemType;
			this.binaryString = binaryString;
			this.setComplexData(complexData);
			this.hexIndex = hexIndex;
			this.setNumOfItemsInSockets(numOfItemsInSockets);
		}

		public String getHexString()
		{
			return hexString;
		}

		public void setHexString(String hexString)
		{
			this.hexString = hexString;
		}

		public byte[] getItemArray()
		{
			return itemArray;
		}

		public void setItemArray(byte[] itemArray)
		{
			this.itemArray = itemArray;
		}

		public bool IsIdentified()
		{
			return _isIdentified;
		}

		public void setIdentified(bool IsIdentified)
		{
			this._isIdentified = IsIdentified;
		}

		public bool IsSocketed()
		{
			return _isSocketed;
		}

		public void setSocketed(bool IsSocketed)
		{
			this._isSocketed = IsSocketed;
		}

		public bool IsEar()
		{
			return _isEar;
		}

		public void setEar(bool IsEar)
		{
			this._isEar = IsEar;
		}

		public bool IsSimple()
		{
			return _isSimple;
		}

		public void setSimple(bool IsSimple)
		{
			this._isSimple = IsSimple;
		}

		public bool IsEthereal()
		{
			return _isEthereal;
		}

		public void setEthereal(bool IsEthereal)
		{
			this._isEthereal = IsEthereal;
		}

		public bool IsPersonalized()
		{
			return _isPersonalized;
		}

		public void setPersonalized(bool IsPersonalized)
		{
			this._isPersonalized = IsPersonalized;
		}

		public bool IsRuneword()
		{
			return _isRuneword;
		}

		public void setRuneword(bool IsRuneword)
		{
			this._isRuneword = IsRuneword;
		}

		public String getLocation()
		{
			return location;
		}

		public void setLocation(String location)
		{
			this.location = location;
		}

		public int getColNum()
		{
			return colNum;
		}

		public void setColNum(int colNum)
		{
			this.colNum = colNum;
		}

		public int getRowNum()
		{
			return rowNum;
		}

		public void setRowNum(int rowNum)
		{
			this.rowNum = rowNum;
		}

		public String getItemType()
		{
			return itemType;
		}

		public void setItemType(String itemType)
		{
			this.itemType = itemType;
		}

		public String getBinaryString()
		{
			return binaryString;
		}

		public void setBinaryString(String binaryString)
		{
			this.binaryString = binaryString;
		}

		public ComplexData getComplexData()
		{
			return complexData;
		}

		public void setComplexData(ComplexData complexData)
		{
			this.complexData = complexData;
		}

		public String getHexIndex()
		{
			return hexIndex;
		}

		public void setHexIndex(String hexIndex)
		{
			this.hexIndex = hexIndex;
		}

		public int getNumOfItemsInSockets()
		{
			return numOfItemsInSockets;
		}

		public void setNumOfItemsInSockets(int numOfItemsInSockets)
		{
			this.numOfItemsInSockets = numOfItemsInSockets;
		}
	}
}
