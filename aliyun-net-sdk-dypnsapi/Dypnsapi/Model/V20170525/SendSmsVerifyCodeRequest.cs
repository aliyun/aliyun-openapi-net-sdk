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
using Aliyun.Acs.Dypnsapi.Transform;
using Aliyun.Acs.Dypnsapi.Transform.V20170525;

namespace Aliyun.Acs.Dypnsapi.Model.V20170525
{
    public class SendSmsVerifyCodeRequest : RpcAcsRequest<SendSmsVerifyCodeResponse>
    {
        public SendSmsVerifyCodeRequest()
            : base("Dypnsapi", "2017-05-25", "SendSmsVerifyCode", "dypnsapi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dypnsapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dypnsapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string countryCode;

		private string phoneNumber;

		private string smsUpExtendCode;

		private string signName;

		private long? autoRetry;

		private string resourceOwnerAccount;

		private long? validTime;

		private long? ownerId;

		private bool? returnVerifyCode;

		private long? codeType;

		private string schemeName;

		private long? duplicatePolicy;

		private string outId;

		private long? interval;

		private string templateCode;

		private string templateParam;

		private long? codeLength;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string CountryCode
		{
			get
			{
				return countryCode;
			}
			set	
			{
				countryCode = value;
				DictionaryUtil.Add(QueryParameters, "CountryCode", value);
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

		public string SmsUpExtendCode
		{
			get
			{
				return smsUpExtendCode;
			}
			set	
			{
				smsUpExtendCode = value;
				DictionaryUtil.Add(QueryParameters, "SmsUpExtendCode", value);
			}
		}

		public string SignName
		{
			get
			{
				return signName;
			}
			set	
			{
				signName = value;
				DictionaryUtil.Add(QueryParameters, "SignName", value);
			}
		}

		public long? AutoRetry
		{
			get
			{
				return autoRetry;
			}
			set	
			{
				autoRetry = value;
				DictionaryUtil.Add(QueryParameters, "AutoRetry", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ValidTime
		{
			get
			{
				return validTime;
			}
			set	
			{
				validTime = value;
				DictionaryUtil.Add(QueryParameters, "ValidTime", value.ToString());
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public bool? ReturnVerifyCode
		{
			get
			{
				return returnVerifyCode;
			}
			set	
			{
				returnVerifyCode = value;
				DictionaryUtil.Add(QueryParameters, "ReturnVerifyCode", value.ToString());
			}
		}

		public long? CodeType
		{
			get
			{
				return codeType;
			}
			set	
			{
				codeType = value;
				DictionaryUtil.Add(QueryParameters, "CodeType", value.ToString());
			}
		}

		public string SchemeName
		{
			get
			{
				return schemeName;
			}
			set	
			{
				schemeName = value;
				DictionaryUtil.Add(QueryParameters, "SchemeName", value);
			}
		}

		public long? DuplicatePolicy
		{
			get
			{
				return duplicatePolicy;
			}
			set	
			{
				duplicatePolicy = value;
				DictionaryUtil.Add(QueryParameters, "DuplicatePolicy", value.ToString());
			}
		}

		public string OutId
		{
			get
			{
				return outId;
			}
			set	
			{
				outId = value;
				DictionaryUtil.Add(QueryParameters, "OutId", value);
			}
		}

		public long? Interval
		{
			get
			{
				return interval;
			}
			set	
			{
				interval = value;
				DictionaryUtil.Add(QueryParameters, "Interval", value.ToString());
			}
		}

		public string TemplateCode
		{
			get
			{
				return templateCode;
			}
			set	
			{
				templateCode = value;
				DictionaryUtil.Add(QueryParameters, "TemplateCode", value);
			}
		}

		public string TemplateParam
		{
			get
			{
				return templateParam;
			}
			set	
			{
				templateParam = value;
				DictionaryUtil.Add(QueryParameters, "TemplateParam", value);
			}
		}

		public long? CodeLength
		{
			get
			{
				return codeLength;
			}
			set	
			{
				codeLength = value;
				DictionaryUtil.Add(QueryParameters, "CodeLength", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SendSmsVerifyCodeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SendSmsVerifyCodeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
