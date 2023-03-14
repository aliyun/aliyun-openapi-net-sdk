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
using Aliyun.Acs.Dypnsapi_intl;
using Aliyun.Acs.Dypnsapi_intl.Transform;
using Aliyun.Acs.Dypnsapi_intl.Transform.V20170725;

namespace Aliyun.Acs.Dypnsapi_intl.Model.V20170725
{
    public class CheckVerificationRequest : RpcAcsRequest<CheckVerificationResponse>
    {
        public CheckVerificationRequest()
            : base("Dypnsapi-intl", "2017-07-25", "CheckVerification")
        {
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string code;

		private string serviceSid;

		private string verificationId;

		private string resourceOwnerAccount;

		private long? ownerId;

		private string to;

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

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
				DictionaryUtil.Add(QueryParameters, "Code", value);
			}
		}

		public string ServiceSid
		{
			get
			{
				return serviceSid;
			}
			set	
			{
				serviceSid = value;
				DictionaryUtil.Add(QueryParameters, "ServiceSid", value);
			}
		}

		public string VerificationId
		{
			get
			{
				return verificationId;
			}
			set	
			{
				verificationId = value;
				DictionaryUtil.Add(QueryParameters, "VerificationId", value);
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

		public string To
		{
			get
			{
				return to;
			}
			set	
			{
				to = value;
				DictionaryUtil.Add(QueryParameters, "To", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CheckVerificationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CheckVerificationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
