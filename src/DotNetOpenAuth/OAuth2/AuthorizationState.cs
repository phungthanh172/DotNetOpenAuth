﻿//-----------------------------------------------------------------------
// <copyright file="AuthorizationState.cs" company="Andrew Arnott">
//     Copyright (c) Andrew Arnott. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.OAuth2 {
	using System;

	/// <summary>
	/// A simple memory-only copy of an authorization state.
	/// </summary>
	[Serializable]
	public class AuthorizationState : IAuthorizationState {
		/// <summary>
		/// Initializes a new instance of the <see cref="AuthorizationState"/> class.
		/// </summary>
		public AuthorizationState() {
		}

		/// <summary>
		/// Gets or sets the callback URL used to obtain authorization.
		/// </summary>
		/// <value>The callback URL.</value>
		public Uri Callback { get; set; }

		/// <summary>
		/// Gets or sets the long-lived token used to renew the short-lived <see cref="AccessToken"/>.
		/// </summary>
		/// <value>The refresh token.</value>
		public string RefreshToken { get; set; }

		/// <summary>
		/// Gets or sets the access token.
		/// </summary>
		/// <value>The access token.</value>
		public string AccessToken { get; set; }

		/// <summary>
		/// Gets or sets the access token UTC expiration date.
		/// </summary>
		/// <value></value>
		public DateTime? AccessTokenExpirationUtc { get; set; }

		/// <summary>
		/// Gets or sets the access token issue date UTC.
		/// </summary>
		/// <value>The access token issue date UTC.</value>
		public DateTime? AccessTokenIssueDateUtc { get; set; }

		/// <summary>
		/// Gets or sets the scope the token is (to be) authorized for.
		/// </summary>
		/// <value>The scope.</value>
		public string Scope { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this instance is deleted.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this instance is deleted; otherwise, <c>false</c>.
		/// </value>
		public bool IsDeleted { get; set; }

		/// <summary>
		/// Deletes this authorization, including access token and refresh token where applicable.
		/// </summary>
		/// <remarks>
		/// This method is invoked when an authorization attempt fails, is rejected, is revoked, or
		/// expires and cannot be renewed.
		/// </remarks>
		public virtual void Delete() {
			this.IsDeleted = true;
		}

		/// <summary>
		/// Saves any changes made to this authorization object's properties.
		/// </summary>
		/// <remarks>
		/// This method is invoked after DotNetOpenAuth changes any property.
		/// </remarks>
		public virtual void SaveChanges() {
		}
	}
}