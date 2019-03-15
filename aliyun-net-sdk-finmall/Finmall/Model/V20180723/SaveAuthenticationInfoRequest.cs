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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.finmall.Transform;
using Aliyun.Acs.finmall.Transform.V20180723;

namespace Aliyun.Acs.finmall.Model.V20180723
{
    public class SaveAuthenticationInfoRequest : RpcAcsRequest<SaveAuthenticationInfoResponse>
    {
        public SaveAuthenticationInfoRequest()
            : base("finmall", "2018-07-23", "SaveAuthenticationInfo", "finmall", "openAPI")
        {
        }

		private string idCardNumber;

		private string address;

		private string employeeEmail;

		private string employeePhoneNumber;

		private string phoneNumber;

		private string businessLicense;

		private string legalPersonName;

		private string enterpriseName;

		private string authenticateType;

		private string userId;

		private string zhimaReturnUrl;

		private string bankCard;

		private string email;

		private string employeeName;

		private string employeeIdCardNumber;

		public string IdCardNumber
		{
			get
			{
				return idCardNumber;
			}
			set	
			{
				idCardNumber = value;
				DictionaryUtil.Add(QueryParameters, "IdCardNumber", value);
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

		public string EmployeeEmail
		{
			get
			{
				return employeeEmail;
			}
			set	
			{
				employeeEmail = value;
				DictionaryUtil.Add(QueryParameters, "EmployeeEmail", value);
			}
		}

		public string EmployeePhoneNumber
		{
			get
			{
				return employeePhoneNumber;
			}
			set	
			{
				employeePhoneNumber = value;
				DictionaryUtil.Add(QueryParameters, "EmployeePhoneNumber", value);
			}
		}

		public string PhoneNumber
		{
			get
			{
				return phoneNumber;
			}
			set	
			{
				phoneNumber = value;
				DictionaryUtil.Add(QueryParameters, "PhoneNumber", value);
			}
		}

		public string BusinessLicense
		{
			get
			{
				return businessLicense;
			}
			set	
			{
				businessLicense = value;
				DictionaryUtil.Add(QueryParameters, "BusinessLicense", value);
			}
		}

		public string LegalPersonName
		{
			get
			{
				return legalPersonName;
			}
			set	
			{
				legalPersonName = value;
				DictionaryUtil.Add(QueryParameters, "LegalPersonName", value);
			}
		}

		public string EnterpriseName
		{
			get
			{
				return enterpriseName;
			}
			set	
			{
				enterpriseName = value;
				DictionaryUtil.Add(QueryParameters, "EnterpriseName", value);
			}
		}

		public string AuthenticateType
		{
			get
			{
				return authenticateType;
			}
			set	
			{
				authenticateType = value;
				DictionaryUtil.Add(QueryParameters, "AuthenticateType", value);
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
			}
		}

		public string ZhimaReturnUrl
		{
			get
			{
				return zhimaReturnUrl;
			}
			set	
			{
				zhimaReturnUrl = value;
				DictionaryUtil.Add(QueryParameters, "ZhimaReturnUrl", value);
			}
		}

		public string BankCard
		{
			get
			{
				return bankCard;
			}
			set	
			{
				bankCard = value;
				DictionaryUtil.Add(QueryParameters, "BankCard", value);
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

		public string EmployeeName
		{
			get
			{
				return employeeName;
			}
			set	
			{
				employeeName = value;
				DictionaryUtil.Add(QueryParameters, "EmployeeName", value);
			}
		}

		public string EmployeeIdCardNumber
		{
			get
			{
				return employeeIdCardNumber;
			}
			set	
			{
				employeeIdCardNumber = value;
				DictionaryUtil.Add(QueryParameters, "EmployeeIdCardNumber", value);
			}
		}

        public override SaveAuthenticationInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveAuthenticationInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
