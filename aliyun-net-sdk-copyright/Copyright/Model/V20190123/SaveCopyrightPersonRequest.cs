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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Copyright;
using Aliyun.Acs.Copyright.Transform;
using Aliyun.Acs.Copyright.Transform.V20190123;

namespace Aliyun.Acs.Copyright.Model.V20190123
{
    public class SaveCopyrightPersonRequest : RpcAcsRequest<SaveCopyrightPersonResponse>
    {
        public SaveCopyrightPersonRequest()
            : base("Copyright", "2019-01-23", "SaveCopyrightPerson")
        {
			Method = MethodType.POST;
        }

		private string city;

		private string idBackImage;

		private string idFrontImage;

		private string county;

		private string enterpriseTime;

		private long? expiredDate;

		private string province;

		private int? roleType;

		private long? personId;

		private string cardType;

		private string legalPersonType;

		private string email;

		private string idHandedImage;

		private string address;

		private string enterprisePark;

		private string cardNum;

		private string enterpriseLicensePath;

		private string phone;

		private int? ownerType;

		private string name;

		private string enterpriseType;

		private int? useType;

		public string City
		{
			get
			{
				return city;
			}
			set	
			{
				city = value;
				DictionaryUtil.Add(QueryParameters, "City", value);
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
				DictionaryUtil.Add(QueryParameters, "IdBackImage", value);
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
				DictionaryUtil.Add(QueryParameters, "IdFrontImage", value);
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
				DictionaryUtil.Add(QueryParameters, "County", value);
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
				DictionaryUtil.Add(QueryParameters, "EnterpriseTime", value);
			}
		}

		public long? ExpiredDate
		{
			get
			{
				return expiredDate;
			}
			set	
			{
				expiredDate = value;
				DictionaryUtil.Add(QueryParameters, "ExpiredDate", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Province", value);
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
				DictionaryUtil.Add(QueryParameters, "RoleType", value.ToString());
			}
		}

		public long? PersonId
		{
			get
			{
				return personId;
			}
			set	
			{
				personId = value;
				DictionaryUtil.Add(QueryParameters, "PersonId", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "CardType", value);
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
				DictionaryUtil.Add(QueryParameters, "LegalPersonType", value);
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
				DictionaryUtil.Add(QueryParameters, "Email", value);
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
				DictionaryUtil.Add(QueryParameters, "IdHandedImage", value);
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
				DictionaryUtil.Add(QueryParameters, "Address", value);
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
				DictionaryUtil.Add(QueryParameters, "EnterprisePark", value);
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
				DictionaryUtil.Add(QueryParameters, "CardNum", value);
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
				DictionaryUtil.Add(QueryParameters, "EnterpriseLicensePath", value);
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
				DictionaryUtil.Add(QueryParameters, "Phone", value);
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
				DictionaryUtil.Add(QueryParameters, "OwnerType", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "Name", value);
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
				DictionaryUtil.Add(QueryParameters, "EnterpriseType", value);
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
				DictionaryUtil.Add(QueryParameters, "UseType", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveCopyrightPersonResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveCopyrightPersonResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
