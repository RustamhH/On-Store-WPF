using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace OnStore
{
    public class Product:INotifyPropertyChanged
    {
		private string ?name;

		public string Name
		{
			get { return name!; }
			set { name = value; OnChangeProperty(); }
		}


		private string ?content;

		public string Content
		{
			get { return content!; }
			set { content = value; OnChangeProperty(); }
		}

		private double price;

		public double Price
		{
			get { return price; }
			set { price = value; OnChangeProperty(); }
		}


		private string ?imageurl;


		public string ImageUrl
		{
			get { return imageurl!; }
			set { imageurl = value;OnChangeProperty(); }
		}

		public event PropertyChangedEventHandler? PropertyChanged;


		private void OnChangeProperty([CallerMemberName] string ?name=null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
		}


		public Product()
		{

		}

		public Product(string name,  string content,  double price,  string imageurl)
		{
			Name = name;
			Content = content;
			Price = price;
			ImageUrl = imageurl;
		}

		public override string? ToString()
		{
			return $"{Name} {Content} {Price} {ImageUrl}";
		}
	}
}
