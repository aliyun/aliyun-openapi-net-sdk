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
    public class UpdateEnterpriseCustomInfoRequest : RpcAcsRequest<UpdateEnterpriseCustomInfoResponse>
    {
        public UpdateEnterpriseCustomInfoRequest()
            : base("finmall", "2018-07-23", "UpdateEnterpriseCustomInfo", "finmall", "openAPI")
        {
        }

		private string idCardNumber;

		private string address;

		private string idCardFrontPage;

		private string phoneNumber;

		private string businessLicense;

		private string idCardBackPage;

		private string legalPersonName;

		private string enterpriseName;

		private string userId;

		private string loanSubject;

		private string zhimaReturnUrl;

		private string smsIvToken;

		private string bankCard;

		private string email;

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

		public string IdCardFrontPage
		{
			get
			{
				return idCardFrontPage;
			}
			set	
			{
				idCardFrontPage = value;
				DictionaryUtil.Add(QueryParameters, "IdCardFrontPage", value);
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

		public string IdCardBackPage
		{
			get
			{
				return idCardBackPage;
			}
			set	
			{
				idCardBackPage = value;
				DictionaryUtil.Add(QueryParameters, "IdCardBackPage", value);
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

		public string LoanSubject
		{
			get
			{
				return loanSubject;
			}
			set	
			{
				loanSubject = value;
				DictionaryUtil.Add(QueryParameters, "LoanSubject", value);
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

		public string SmsIvToken
		{
			get
			{
				return smsIvToken;
			}
			set	
			{
				smsIvToken = value;
				DictionaryUtil.Add(QueryParameters, "SmsIvToken", value);
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

        public override UpdateEnterpriseCustomInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateEnterpriseCustomInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
