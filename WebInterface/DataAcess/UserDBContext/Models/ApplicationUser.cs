﻿using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebInterface.DataAcess.UserDBContext.Models
{
	public class ApplicationUser : IdentityUser
	{
	
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime? DateOfBirth { get; set; }

		public virtual Address Address { get; set; }

		public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
		{
			// Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
			var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
			// Add custom user claims here

			return userIdentity;
		}
	}
}