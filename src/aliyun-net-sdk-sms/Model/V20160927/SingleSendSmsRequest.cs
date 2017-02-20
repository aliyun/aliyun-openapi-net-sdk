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
using Aliyun.Acs.Sms.Transform.V20160927;

namespace Aliyun.Acs.Sms.Model.V20160927
{
    public class SingleSendSmsRequest : RpcAcsRequest<SingleSendSmsResponse>
    {
        public SingleSendSmsRequest()
            : base("Sms", "2016-09-27", "SingleSendSms")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _signName;

		private string _templateCode;

		private string _recNum;

		private string _paramString;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string SignName
		{
			get
			{
				return _signName;
			}
			set	
			{
				_signName = value;
				DictionaryUtil.Add(QueryParameters, "SignName", value);
			}
		}

		public string TemplateCode
		{
			get
			{
				return _templateCode;
			}
			set	
			{
				_templateCode = value;
				DictionaryUtil.Add(QueryParameters, "TemplateCode", value);
			}
		}

		public string RecNum
		{
			get
			{
				return _recNum;
			}
			set	
			{
				_recNum = value;
				DictionaryUtil.Add(QueryParameters, "RecNum", value);
			}
		}

		public string ParamString
		{
			get
			{
				return _paramString;
			}
			set	
			{
				_paramString = value;
				DictionaryUtil.Add(QueryParameters, "ParamString", value);
			}
		}

        public override SingleSendSmsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SingleSendSmsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}