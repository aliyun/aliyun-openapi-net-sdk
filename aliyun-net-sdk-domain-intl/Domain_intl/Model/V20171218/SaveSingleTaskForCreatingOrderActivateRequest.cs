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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Domain_intl.Transform;
using Aliyun.Acs.Domain_intl.Transform.V20171218;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain_intl.Model.V20171218
{
    public class SaveSingleTaskForCreatingOrderActivateRequest : RpcAcsRequest<SaveSingleTaskForCreatingOrderActivateResponse>
    {
        public SaveSingleTaskForCreatingOrderActivateRequest()
            : base("Domain_intl", "2017-12-18", "SaveSingleTaskForCreatingOrderActivate", "domain", "openAPI")
        {
        }

		private string country;

		private int? subscriptionDuration;

		private string address;

		private bool? permitPremiumActivation;

		private string telArea;

		private string city;

		private string dns2;

		private string dns1;

		private string domainName;

		private long? registrantProfileId;

		private string telephone;

		private bool? trademarkDomainActivation;

		private bool? aliyunDns;

		private string registrantOrganization;

		private string telExt;

		private string province;

		private string postalCode;

		private string userClientIp;

		private bool? enableDomainProxy;

		private string lang;

		private string email;

		private string registrantName;

		public string Country
		{
			get
			{
				return country;
			}
			set	
			{
				country = value;
				DictionaryUtil.Add(QueryParameters, "Country", value);
			}
		}

		public int? SubscriptionDuration
		{
			get
			{
				return subscriptionDuration;
			}
			set	
			{
				subscriptionDuration = value;
				DictionaryUtil.Add(QueryParameters, "SubscriptionDuration", value.ToString());
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

		public bool? PermitPremiumActivation
		{
			get
			{
				return permitPremiumActivation;
			}
			set	
			{
				permitPremiumActivation = value;
				DictionaryUtil.Add(QueryParameters, "PermitPremiumActivation", value.ToString());
			}
		}

		public string TelArea
		{
			get
			{
				return telArea;
			}
			set	
			{
				telArea = value;
				DictionaryUtil.Add(QueryParameters, "TelArea", value);
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
				DictionaryUtil.Add(QueryParameters, "City", value);
			}
		}

		public string Dns2
		{
			get
			{
				return dns2;
			}
			set	
			{
				dns2 = value;
				DictionaryUtil.Add(QueryParameters, "Dns2", value);
			}
		}

		public string Dns1
		{
			get
			{
				return dns1;
			}
			set	
			{
				dns1 = value;
				DictionaryUtil.Add(QueryParameters, "Dns1", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public long? RegistrantProfileId
		{
			get
			{
				return registrantProfileId;
			}
			set	
			{
				registrantProfileId = value;
				DictionaryUtil.Add(QueryParameters, "RegistrantProfileId", value.ToString());
			}
		}

		public string Telephone
		{
			get
			{
				return telephone;
			}
			set	
			{
				telephone = value;
				DictionaryUtil.Add(QueryParameters, "Telephone", value);
			}
		}

		public bool? TrademarkDomainActivation
		{
			get
			{
				return trademarkDomainActivation;
			}
			set	
			{
				trademarkDomainActivation = value;
				DictionaryUtil.Add(QueryParameters, "TrademarkDomainActivation", value.ToString());
			}
		}

		public bool? AliyunDns
		{
			get
			{
				return aliyunDns;
			}
			set	
			{
				aliyunDns = value;
				DictionaryUtil.Add(QueryParameters, "AliyunDns", value.ToString());
			}
		}

		public string RegistrantOrganization
		{
			get
			{
				return registrantOrganization;
			}
			set	
			{
				registrantOrganization = value;
				DictionaryUtil.Add(QueryParameters, "RegistrantOrganization", value);
			}
		}

		public string TelExt
		{
			get
			{
				return telExt;
			}
			set	
			{
				telExt = value;
				DictionaryUtil.Add(QueryParameters, "TelExt", value);
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

		public string PostalCode
		{
			get
			{
				return postalCode;
			}
			set	
			{
				postalCode = value;
				DictionaryUtil.Add(QueryParameters, "PostalCode", value);
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public bool? EnableDomainProxy
		{
			get
			{
				return enableDomainProxy;
			}
			set	
			{
				enableDomainProxy = value;
				DictionaryUtil.Add(QueryParameters, "EnableDomainProxy", value.ToString());
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
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

		public string RegistrantName
		{
			get
			{
				return registrantName;
			}
			set	
			{
				registrantName = value;
				DictionaryUtil.Add(QueryParameters, "RegistrantName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveSingleTaskForCreatingOrderActivateResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SaveSingleTaskForCreatingOrderActivateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}