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
using Aliyun.Acs.sophonsoar;
using Aliyun.Acs.sophonsoar.Transform;
using Aliyun.Acs.sophonsoar.Transform.V20220728;

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
    public class RunNotifyComponentWithMessageCenterRequest : RpcAcsRequest<RunNotifyComponentWithMessageCenterResponse>
    {
        public RunNotifyComponentWithMessageCenterRequest()
            : base("sophonsoar", "2022-07-28", "RunNotifyComponentWithMessageCenter")
        {
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string eventId;

		private long? roleFor;

		private string componentName;

		private string _params;

		private string actionName;

		private string nodeName;

		private string playbookUuid;

		private int? assetId;

		private string roleType;

		private string aliuid;

		private string lang;

		private List<string> channelTypeLists = new List<string>(){ };

		public string EventId
		{
			get
			{
				return eventId;
			}
			set	
			{
				eventId = value;
				DictionaryUtil.Add(QueryParameters, "EventId", value);
			}
		}

		public long? RoleFor
		{
			get
			{
				return roleFor;
			}
			set	
			{
				roleFor = value;
				DictionaryUtil.Add(QueryParameters, "RoleFor", value.ToString());
			}
		}

		public string ComponentName
		{
			get
			{
				return componentName;
			}
			set	
			{
				componentName = value;
				DictionaryUtil.Add(QueryParameters, "ComponentName", value);
			}
		}

		public string _Params
		{
			get
			{
				return _params;
			}
			set	
			{
				_params = value;
				DictionaryUtil.Add(QueryParameters, "Params", value);
			}
		}

		public string ActionName
		{
			get
			{
				return actionName;
			}
			set	
			{
				actionName = value;
				DictionaryUtil.Add(QueryParameters, "ActionName", value);
			}
		}

		public string NodeName
		{
			get
			{
				return nodeName;
			}
			set	
			{
				nodeName = value;
				DictionaryUtil.Add(QueryParameters, "NodeName", value);
			}
		}

		public string PlaybookUuid
		{
			get
			{
				return playbookUuid;
			}
			set	
			{
				playbookUuid = value;
				DictionaryUtil.Add(QueryParameters, "PlaybookUuid", value);
			}
		}

		public int? AssetId
		{
			get
			{
				return assetId;
			}
			set	
			{
				assetId = value;
				DictionaryUtil.Add(QueryParameters, "AssetId", value.ToString());
			}
		}

		public string RoleType
		{
			get
			{
				return roleType;
			}
			set	
			{
				roleType = value;
				DictionaryUtil.Add(QueryParameters, "RoleType", value);
			}
		}

		public string Aliuid
		{
			get
			{
				return aliuid;
			}
			set	
			{
				aliuid = value;
				DictionaryUtil.Add(QueryParameters, "Aliuid", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public List<string> ChannelTypeLists
		{
			get
			{
				return channelTypeLists;
			}

			set
			{
				channelTypeLists = value;
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RunNotifyComponentWithMessageCenterResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RunNotifyComponentWithMessageCenterResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
