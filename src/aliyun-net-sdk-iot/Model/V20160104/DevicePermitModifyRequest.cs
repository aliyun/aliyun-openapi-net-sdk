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
using Aliyun.Acs.Iot.Transform.V20160104;

namespace Aliyun.Acs.Iot.Model.V20160104
{
    public class DevicePermitModifyRequest : RpcAcsRequest<DevicePermitModifyResponse>
    {
        public DevicePermitModifyRequest()
            : base("Iot", "2016-01-04", "DevicePermitModify")
        {
        }

		private long? _appKey;

		private long? _ruleId;

		private string _deviceId;

		private string _topicFullName;

		private string _grantType;

		public long? AppKey
		{
			get
			{
				return _appKey;
			}
			set	
			{
				_appKey = value;
				DictionaryUtil.Add(QueryParameters, "AppKey", value.ToString());
			}
		}

		public long? RuleId
		{
			get
			{
				return _ruleId;
			}
			set	
			{
				_ruleId = value;
				DictionaryUtil.Add(QueryParameters, "RuleId", value.ToString());
			}
		}

		public string DeviceId
		{
			get
			{
				return _deviceId;
			}
			set	
			{
				_deviceId = value;
				DictionaryUtil.Add(QueryParameters, "DeviceId", value);
			}
		}

		public string TopicFullName
		{
			get
			{
				return _topicFullName;
			}
			set	
			{
				_topicFullName = value;
				DictionaryUtil.Add(QueryParameters, "TopicFullName", value);
			}
		}

		public string GrantType
		{
			get
			{
				return _grantType;
			}
			set	
			{
				_grantType = value;
				DictionaryUtil.Add(QueryParameters, "GrantType", value);
			}
		}

        public override DevicePermitModifyResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DevicePermitModifyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}