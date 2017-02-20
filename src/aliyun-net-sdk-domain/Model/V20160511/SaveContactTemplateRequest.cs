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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Domain.Transform.V20160511;

namespace Aliyun.Acs.Domain.Model.V20160511
{
    public class SaveContactTemplateRequest : RpcAcsRequest<SaveContactTemplateResponse>
    {
        public SaveContactTemplateRequest()
            : base("Domain", "2016-05-11", "SaveContactTemplate")
        {
        }

		private string _userClientIp;

		private string _lang;

		private long? _contactTemplateId;

		private bool? _defaultTemplate;

		private string _cCity;

		private string _cCompany;

		private string _cCountry;

		private string _cName;

		private string _cProvince;

		private string _cVenu;

		private string _eCity;

		private string _eCompany;

		private string _eName;

		private string _eProvince;

		private string _eVenu;

		private string _email;

		private string _postalCode;

		private string _telArea;

		private string _telMain;

		private string _telExt;

		private string _regType;

		public string UserClientIp
		{
			get
			{
				return _userClientIp;
			}
			set	
			{
				_userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string Lang
		{
			get
			{
				return _lang;
			}
			set	
			{
				_lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public long? ContactTemplateId
		{
			get
			{
				return _contactTemplateId;
			}
			set	
			{
				_contactTemplateId = value;
				DictionaryUtil.Add(QueryParameters, "ContactTemplateId", value.ToString());
			}
		}

		public bool? DefaultTemplate
		{
			get
			{
				return _defaultTemplate;
			}
			set	
			{
				_defaultTemplate = value;
				DictionaryUtil.Add(QueryParameters, "DefaultTemplate", value.ToString());
			}
		}

		public string CCity
		{
			get
			{
				return _cCity;
			}
			set	
			{
				_cCity = value;
				DictionaryUtil.Add(QueryParameters, "CCity", value);
			}
		}

		public string CCompany
		{
			get
			{
				return _cCompany;
			}
			set	
			{
				_cCompany = value;
				DictionaryUtil.Add(QueryParameters, "CCompany", value);
			}
		}

		public string CCountry
		{
			get
			{
				return _cCountry;
			}
			set	
			{
				_cCountry = value;
				DictionaryUtil.Add(QueryParameters, "CCountry", value);
			}
		}

		public string CName
		{
			get
			{
				return _cName;
			}
			set	
			{
				_cName = value;
				DictionaryUtil.Add(QueryParameters, "CName", value);
			}
		}

		public string CProvince
		{
			get
			{
				return _cProvince;
			}
			set	
			{
				_cProvince = value;
				DictionaryUtil.Add(QueryParameters, "CProvince", value);
			}
		}

		public string CVenu
		{
			get
			{
				return _cVenu;
			}
			set	
			{
				_cVenu = value;
				DictionaryUtil.Add(QueryParameters, "CVenu", value);
			}
		}

		public string ECity
		{
			get
			{
				return _eCity;
			}
			set	
			{
				_eCity = value;
				DictionaryUtil.Add(QueryParameters, "ECity", value);
			}
		}

		public string ECompany
		{
			get
			{
				return _eCompany;
			}
			set	
			{
				_eCompany = value;
				DictionaryUtil.Add(QueryParameters, "ECompany", value);
			}
		}

		public string EName
		{
			get
			{
				return _eName;
			}
			set	
			{
				_eName = value;
				DictionaryUtil.Add(QueryParameters, "EName", value);
			}
		}

		public string EProvince
		{
			get
			{
				return _eProvince;
			}
			set	
			{
				_eProvince = value;
				DictionaryUtil.Add(QueryParameters, "EProvince", value);
			}
		}

		public string EVenu
		{
			get
			{
				return _eVenu;
			}
			set	
			{
				_eVenu = value;
				DictionaryUtil.Add(QueryParameters, "EVenu", value);
			}
		}

		public string Email
		{
			get
			{
				return _email;
			}
			set	
			{
				_email = value;
				DictionaryUtil.Add(QueryParameters, "Email", value);
			}
		}

		public string PostalCode
		{
			get
			{
				return _postalCode;
			}
			set	
			{
				_postalCode = value;
				DictionaryUtil.Add(QueryParameters, "PostalCode", value);
			}
		}

		public string TelArea
		{
			get
			{
				return _telArea;
			}
			set	
			{
				_telArea = value;
				DictionaryUtil.Add(QueryParameters, "TelArea", value);
			}
		}

		public string TelMain
		{
			get
			{
				return _telMain;
			}
			set	
			{
				_telMain = value;
				DictionaryUtil.Add(QueryParameters, "TelMain", value);
			}
		}

		public string TelExt
		{
			get
			{
				return _telExt;
			}
			set	
			{
				_telExt = value;
				DictionaryUtil.Add(QueryParameters, "TelExt", value);
			}
		}

		public string RegType
		{
			get
			{
				return _regType;
			}
			set	
			{
				_regType = value;
				DictionaryUtil.Add(QueryParameters, "RegType", value);
			}
		}

        public override SaveContactTemplateResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SaveContactTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}