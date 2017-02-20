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
using Aliyun.Acs.Push.Transform.V20150827;

namespace Aliyun.Acs.Push.Model.V20150827
{
    public class PushByteMessageRequest : RpcAcsRequest<PushByteMessageResponse>
    {
        public PushByteMessageRequest()
            : base("Push", "2015-08-27", "PushByteMessage")
        {
        }

		private long? _appId;

		private int? _sendType;

		private string _accounts;

		private string _deviceIds;

		private string _pushContent;

		public long? AppId
		{
			get
			{
				return _appId;
			}
			set	
			{
				_appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value.ToString());
			}
		}

		public int? SendType
		{
			get
			{
				return _sendType;
			}
			set	
			{
				_sendType = value;
				DictionaryUtil.Add(QueryParameters, "SendType", value.ToString());
			}
		}

		public string Accounts
		{
			get
			{
				return _accounts;
			}
			set	
			{
				_accounts = value;
				DictionaryUtil.Add(QueryParameters, "Accounts", value);
			}
		}

		public string DeviceIds
		{
			get
			{
				return _deviceIds;
			}
			set	
			{
				_deviceIds = value;
				DictionaryUtil.Add(QueryParameters, "DeviceIds", value);
			}
		}

		public string PushContent
		{
			get
			{
				return _pushContent;
			}
			set	
			{
				_pushContent = value;
				DictionaryUtil.Add(QueryParameters, "PushContent", value);
			}
		}

        public override PushByteMessageResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return PushByteMessageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}