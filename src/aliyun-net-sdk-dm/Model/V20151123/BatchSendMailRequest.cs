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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Dm.Transform.V20151123;

namespace Aliyun.Acs.Dm.Model.V20151123
{
    public class BatchSendMailRequest : RpcAcsRequest<BatchSendMailResponse>
    {
        public BatchSendMailRequest()
            : base("Dm", "2015-11-23", "BatchSendMail")
        {
            Method = MethodType.POST;
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _templateName;

		private string _accountName;

		private string _receiversName;

		private int? _addressType;

		private string _tagName;

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

		public string TemplateName
		{
			get
			{
				return _templateName;
			}
			set	
			{
				_templateName = value;
				DictionaryUtil.Add(QueryParameters, "TemplateName", value);
			}
		}

		public string AccountName
		{
			get
			{
				return _accountName;
			}
			set	
			{
				_accountName = value;
				DictionaryUtil.Add(QueryParameters, "AccountName", value);
			}
		}

		public string ReceiversName
		{
			get
			{
				return _receiversName;
			}
			set	
			{
				_receiversName = value;
				DictionaryUtil.Add(QueryParameters, "ReceiversName", value);
			}
		}

		public int? AddressType
		{
			get
			{
				return _addressType;
			}
			set	
			{
				_addressType = value;
				DictionaryUtil.Add(QueryParameters, "AddressType", value.ToString());
			}
		}

		public string TagName
		{
			get
			{
				return _tagName;
			}
			set	
			{
				_tagName = value;
				DictionaryUtil.Add(QueryParameters, "TagName", value);
			}
		}

        public override BatchSendMailResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return BatchSendMailResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}