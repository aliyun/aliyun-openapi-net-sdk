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
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20160511;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Model.V20160511
{
    public class SaveContactTemplateRequest : RpcAcsRequest<SaveContactTemplateResponse>
    {
        public SaveContactTemplateRequest()
            : base("Domain", "2016-05-11", "SaveContactTemplate")
        {
        }

		private string userClientIp;

		private string lang;

		private long? contactTemplateId;

		private bool? defaultTemplate;

		private string cCity;

		private string cCompany;

		private string cCountry;

		private string cName;

		private string cProvince;

		private string cVenu;

		private string eCity;

		private string eCompany;

		private string eName;

		private string eProvince;

		private string eVenu;

		private string email;

		private string postalCode;

		private string telArea;

		private string telMain;

		private string telExt;

		private string regType;

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

		public long? ContactTemplateId
		{
			get
			{
				return contactTemplateId;
			}
			set	
			{
				contactTemplateId = value;
				DictionaryUtil.Add(QueryParameters, "ContactTemplateId", value.ToString());
			}
		}

		public bool? DefaultTemplate
		{
			get
			{
				return defaultTemplate;
			}
			set	
			{
				defaultTemplate = value;
				DictionaryUtil.Add(QueryParameters, "DefaultTemplate", value.ToString());
			}
		}

		public string CCity
		{
			get
			{
				return cCity;
			}
			set	
			{
				cCity = value;
				DictionaryUtil.Add(QueryParameters, "CCity", value);
			}
		}

		public string CCompany
		{
			get
			{
				return cCompany;
			}
			set	
			{
				cCompany = value;
				DictionaryUtil.Add(QueryParameters, "CCompany", value);
			}
		}

		public string CCountry
		{
			get
			{
				return cCountry;
			}
			set	
			{
				cCountry = value;
				DictionaryUtil.Add(QueryParameters, "CCountry", value);
			}
		}

		public string CName
		{
			get
			{
				return cName;
			}
			set	
			{
				cName = value;
				DictionaryUtil.Add(QueryParameters, "CName", value);
			}
		}

		public string CProvince
		{
			get
			{
				return cProvince;
			}
			set	
			{
				cProvince = value;
				DictionaryUtil.Add(QueryParameters, "CProvince", value);
			}
		}

		public string CVenu
		{
			get
			{
				return cVenu;
			}
			set	
			{
				cVenu = value;
				DictionaryUtil.Add(QueryParameters, "CVenu", value);
			}
		}

		public string ECity
		{
			get
			{
				return eCity;
			}
			set	
			{
				eCity = value;
				DictionaryUtil.Add(QueryParameters, "ECity", value);
			}
		}

		public string ECompany
		{
			get
			{
				return eCompany;
			}
			set	
			{
				eCompany = value;
				DictionaryUtil.Add(QueryParameters, "ECompany", value);
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
				DictionaryUtil.Add(QueryParameters, "EName", value);
			}
		}

		public string EProvince
		{
			get
			{
				return eProvince;
			}
			set	
			{
				eProvince = value;
				DictionaryUtil.Add(QueryParameters, "EProvince", value);
			}
		}

		public string EVenu
		{
			get
			{
				return eVenu;
			}
			set	
			{
				eVenu = value;
				DictionaryUtil.Add(QueryParameters, "EVenu", value);
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

		public string TelMain
		{
			get
			{
				return telMain;
			}
			set	
			{
				telMain = value;
				DictionaryUtil.Add(QueryParameters, "TelMain", value);
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

		public string RegType
		{
			get
			{
				return regType;
			}
			set	
			{
				regType = value;
				DictionaryUtil.Add(QueryParameters, "RegType", value);
			}
		}

        public override SaveContactTemplateResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SaveContactTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}