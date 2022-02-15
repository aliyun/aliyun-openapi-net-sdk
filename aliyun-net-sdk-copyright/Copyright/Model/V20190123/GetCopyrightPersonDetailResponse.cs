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

namespace Aliyun.Acs.Copyright.Model.V20190123
{
	public class GetCopyrightPersonDetailResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private GetCopyrightPersonDetail_Data data;

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

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public GetCopyrightPersonDetail_Data Data
		{
			get
			{
				return data;
			}
			set	
			{
				data = value;
			}
		}

		public class GetCopyrightPersonDetail_Data
		{

			private string address;

			private string cardNum;

			private string cardType;

			private string city;

			private string county;

			private string email;

			private string enterpriseLicensePath;

			private string enterprisePark;

			private string enterpriseTime;

			private string enterpriseType;

			private string idBackImage;

			private string idFrontImage;

			private string idHandedImage;

			private string legalPersonType;

			private string name;

			private int? ownerType;

			private string personId;

			private string phone;

			private string province;

			private int? roleType;

			private string userPk;

			private int? useType;

			private int? auditStatus;

			private string expiredDate;

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

			public string CardNum
			{
				get
				{
					return cardNum;
				}
				set	
				{
					cardNum = value;
				}
			}

			public string CardType
			{
				get
				{
					return cardType;
				}
				set	
				{
					cardType = value;
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

			public string County
			{
				get
				{
					return county;
				}
				set	
				{
					county = value;
				}
			}

			public string Email
			{
				get
				{
					return email;
				}
				set	
				{
					email = value;
				}
			}

			public string EnterpriseLicensePath
			{
				get
				{
					return enterpriseLicensePath;
				}
				set	
				{
					enterpriseLicensePath = value;
				}
			}

			public string EnterprisePark
			{
				get
				{
					return enterprisePark;
				}
				set	
				{
					enterprisePark = value;
				}
			}

			public string EnterpriseTime
			{
				get
				{
					return enterpriseTime;
				}
				set	
				{
					enterpriseTime = value;
				}
			}

			public string EnterpriseType
			{
				get
				{
					return enterpriseType;
				}
				set	
				{
					enterpriseType = value;
				}
			}

			public string IdBackImage
			{
				get
				{
					return idBackImage;
				}
				set	
				{
					idBackImage = value;
				}
			}

			public string IdFrontImage
			{
				get
				{
					return idFrontImage;
				}
				set	
				{
					idFrontImage = value;
				}
			}

			public string IdHandedImage
			{
				get
				{
					return idHandedImage;
				}
				set	
				{
					idHandedImage = value;
				}
			}

			public string LegalPersonType
			{
				get
				{
					return legalPersonType;
				}
				set	
				{
					legalPersonType = value;
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

			public int? OwnerType
			{
				get
				{
					return ownerType;
				}
				set	
				{
					ownerType = value;
				}
			}

			public string PersonId
			{
				get
				{
					return personId;
				}
				set	
				{
					personId = value;
				}
			}

			public string Phone
			{
				get
				{
					return phone;
				}
				set	
				{
					phone = value;
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

			public int? RoleType
			{
				get
				{
					return roleType;
				}
				set	
				{
					roleType = value;
				}
			}

			public string UserPk
			{
				get
				{
					return userPk;
				}
				set	
				{
					userPk = value;
				}
			}

			public int? UseType
			{
				get
				{
					return useType;
				}
				set	
				{
					useType = value;
				}
			}

			public int? AuditStatus
			{
				get
				{
					return auditStatus;
				}
				set	
				{
					auditStatus = value;
				}
			}

			public string ExpiredDate
			{
				get
				{
					return expiredDate;
				}
				set	
				{
					expiredDate = value;
				}
			}
		}
	}
}
