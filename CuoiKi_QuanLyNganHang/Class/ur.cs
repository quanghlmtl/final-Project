using System;
using System.Collections.Generic;
using System.Drawing;
using CuoiKi_QuanLyNganHang.Properties;

namespace CuoiKi_QuanLyNganHang.Class
{
	public class ur
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Image ProfilePicture { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public DateTime Birthdate { get; set; }
		public ur Login(string username, string pass)
		{
			return this.GetUsers().Find((ur x) => x.Username == username && x.Password == pass);
		}
		private List<ur> GetUsers()
		{
			return new List<ur>
			{
				new ur
				{
					Id = 1,
					Username = "admin",
					Password = "admin",
					FirstName = "Rummer John",
					LastName = "Cranel",
					ProfilePicture = Resources.eye,
					Email = "rummerCranel@gmail.com",
					PhoneNumber = "16861125 9634",
					Birthdate = new DateTime(1999, 10, 18)
				},
				new ur
				{
					Id = 2,
					Username = "arely",
					Password = "arely123",
					FirstName = "Arely",
					LastName = "Smith",
					ProfilePicture = Resources.eye,
					Email = "Are@gmail.com",
					PhoneNumber = "16850718 4565",
					Birthdate = new DateTime(2002, 4, 27)
				}
			};
		}
	}
}
