/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.Trademark.Model.V20180724
{
	public class QueryMaterialResponse : AcsResponse
	{

		private string requestId;

		private int? type;

		private int? region;

		private string contactName;

		private string contactNumber;

		private string contactEmail;

		private string contactAddress;

		private string contactZipcode;

		private int? status;

		private string loaUrl;

		private string name;

		private string cardNumber;

		private long? expirationDate;

		private string province;

		private string city;

		private string town;

		private string address;

		private string eName;

		private string eAddress;

		private int? loaStatus;

		private string idCardUrl;

		private string businessLicenceUrl;

		private string passportUrl;

		private long? id;

		private string legalNoticeUrl;

		private string note;

		private string country;

		private string reviewApplicationFile;

		private int? principalName;

		private long? validDate;

		private List<string> reviewAdditionalFiles;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
			}
		}

		public int? Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
			}
		}

		public string ContactName
		{
			get
			{
				return contactName;
			}
			set	
			{
				contactName = value;
			}
		}

		public string ContactNumber
		{
			get
			{
				return contactNumber;
			}
			set	
			{
				contactNumber = value;
			}
		}

		public string ContactEmail
		{
			get
			{
				return contactEmail;
			}
			set	
			{
				contactEmail = value;
			}
		}

		public string ContactAddress
		{
			get
			{
				return contactAddress;
			}
			set	
			{
				contactAddress = value;
			}
		}

		public string ContactZipcode
		{
			get
			{
				return contactZipcode;
			}
			set	
			{
				contactZipcode = value;
			}
		}

		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
			}
		}

		public string LoaUrl
		{
			get
			{
				return loaUrl;
			}
			set	
			{
				loaUrl = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
			}
		}

		public string CardNumber
		{
			get
			{
				return cardNumber;
			}
			set	
			{
				cardNumber = value;
			}
		}

		public long? ExpirationDate
		{
			get
			{
				return expirationDate;
			}
			set	
			{
				expirationDate = value;
			}
		}

		public string Province
		{
			get
			{
				return province;
			}
			set	
			{
				province = value;
			}
		}

		public string City
		{
			get
			{
				return city;
			}
			set	
			{
				city = value;
			}
		}

		public string Town
		{
			get
			{
				return town;
			}
			set	
			{
				town = value;
			}
		}

		public string Address
		{
			get
			{
				return address;
			}
			set	
			{
				address = value;
			}
		}

		public string EName
		{
			get
			{
				return eName;
			}
			set	
			{
				eName = value;
			}
		}

		public string EAddress
		{
			get
			{
				return eAddress;
			}
			set	
			{
				eAddress = value;
			}
		}

		public int? LoaStatus
		{
			get
			{
				return loaStatus;
			}
			set	
			{
				loaStatus = value;
			}
		}

		public string IdCardUrl
		{
			get
			{
				return idCardUrl;
			}
			set	
			{
				idCardUrl = value;
			}
		}

		public string BusinessLicenceUrl
		{
			get
			{
				return businessLicenceUrl;
			}
			set	
			{
				businessLicenceUrl = value;
			}
		}

		public string PassportUrl
		{
			get
			{
				return passportUrl;
			}
			set	
			{
				passportUrl = value;
			}
		}

		public long? Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
			}
		}

		public string LegalNoticeUrl
		{
			get
			{
				return legalNoticeUrl;
			}
			set	
			{
				legalNoticeUrl = value;
			}
		}

		public string Note
		{
			get
			{
				return note;
			}
			set	
			{
				note = value;
			}
		}

		public string Country
		{
			get
			{
				return country;
			}
			set	
			{
				country = value;
			}
		}

		public string ReviewApplicationFile
		{
			get
			{
				return reviewApplicationFile;
			}
			set	
			{
				reviewApplicationFile = value;
			}
		}

		public int? PrincipalName
		{
			get
			{
				return principalName;
			}
			set	
			{
				principalName = value;
			}
		}

		public long? ValidDate
		{
			get
			{
				return validDate;
			}
			set	
			{
				validDate = value;
			}
		}

		public List<string> ReviewAdditionalFiles
		{
			get
			{
				return reviewAdditionalFiles;
			}
			set	
			{
				reviewAdditionalFiles = value;
			}
		}
	}
}
