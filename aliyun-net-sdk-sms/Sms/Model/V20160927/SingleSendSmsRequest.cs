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
using Aliyun.Acs.Sms.Transform;
using Aliyun.Acs.Sms.Transform.V20160927;
using System.Collections.Generic;

namespace Aliyun.Acs.Sms.Model.V20160927
{
    public class SingleSendSmsRequest : RpcAcsRequest<SingleSendSmsResponse>
    {
        public SingleSendSmsRequest()
            : base("Sms", "2016-09-27", "SingleSendSms")
        {
        }

		private long? ownerId;

		private string resourceOwnerAccount;

		private long? resourceOwnerId;

		private string signName;

		private string templateCode;

		private string recNum;

		private string paramString;

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

		public string RecNum
		{
			get
			{
				return recNum;
			}
			set	
			{
				recNum = value;
				DictionaryUtil.Add(QueryParameters, "RecNum", value);
			}
		}

		public string ParamString
		{
			get
			{
				return paramString;
			}
			set	
			{
				paramString = value;
				DictionaryUtil.Add(QueryParameters, "ParamString", value);
			}
		}

        public override SingleSendSmsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SingleSendSmsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}