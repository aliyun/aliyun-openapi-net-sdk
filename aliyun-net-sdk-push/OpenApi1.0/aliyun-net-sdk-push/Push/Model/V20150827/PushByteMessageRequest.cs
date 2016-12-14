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
using Aliyun.Acs.Push.Transform;
using Aliyun.Acs.Push.Transform.V20150827;
using System.Collections.Generic;

namespace Aliyun.Acs.Push.Model.V20150827
{
    public class PushByteMessageRequest : RpcAcsRequest<PushByteMessageResponse>
    {
        public PushByteMessageRequest()
            : base("Push", "2015-08-27", "PushByteMessage")
        {
        }

		private long? appId;

		private int? sendType;

		private string accounts;

		private string deviceIds;

		private string pushContent;

		public long? AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value.ToString());
			}
		}

		public int? SendType
		{
			get
			{
				return sendType;
			}
			set	
			{
				sendType = value;
				DictionaryUtil.Add(QueryParameters, "SendType", value.ToString());
			}
		}

		public string Accounts
		{
			get
			{
				return accounts;
			}
			set	
			{
				accounts = value;
				DictionaryUtil.Add(QueryParameters, "Accounts", value);
			}
		}

		public string DeviceIds
		{
			get
			{
				return deviceIds;
			}
			set	
			{
				deviceIds = value;
				DictionaryUtil.Add(QueryParameters, "DeviceIds", value);
			}
		}

		public string PushContent
		{
			get
			{
				return pushContent;
			}
			set	
			{
				pushContent = value;
				DictionaryUtil.Add(QueryParameters, "PushContent", value);
			}
		}

        public override PushByteMessageResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return PushByteMessageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}