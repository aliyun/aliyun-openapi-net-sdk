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
    public class SingleSendMailRequest : RpcAcsRequest<SingleSendMailResponse>
    {
        public SingleSendMailRequest()
            : base("Dm", "2015-11-23", "SingleSendMail")
        {
            Method = MethodType.POST;
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _accountName;

		private int? _addressType;

		private string _tagName;

		private bool? _replyToAddress;

		private string _toAddress;

		private string _subject;

		private string _htmlBody;

		private string _textBody;

		private string _fromAlias;

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

		public bool? ReplyToAddress
		{
			get
			{
				return _replyToAddress;
			}
			set	
			{
				_replyToAddress = value;
				DictionaryUtil.Add(QueryParameters, "ReplyToAddress", value.ToString());
			}
		}

		public string ToAddress
		{
			get
			{
				return _toAddress;
			}
			set	
			{
				_toAddress = value;
				DictionaryUtil.Add(QueryParameters, "ToAddress", value);
			}
		}

		public string Subject
		{
			get
			{
				return _subject;
			}
			set	
			{
				_subject = value;
				DictionaryUtil.Add(QueryParameters, "Subject", value);
			}
		}

		public string HtmlBody
		{
			get
			{
				return _htmlBody;
			}
			set	
			{
				_htmlBody = value;
				DictionaryUtil.Add(QueryParameters, "HtmlBody", value);
			}
		}

		public string TextBody
		{
			get
			{
				return _textBody;
			}
			set	
			{
				_textBody = value;
				DictionaryUtil.Add(QueryParameters, "TextBody", value);
			}
		}

		public string FromAlias
		{
			get
			{
				return _fromAlias;
			}
			set	
			{
				_fromAlias = value;
				DictionaryUtil.Add(QueryParameters, "FromAlias", value);
			}
		}

        public override SingleSendMailResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SingleSendMailResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}