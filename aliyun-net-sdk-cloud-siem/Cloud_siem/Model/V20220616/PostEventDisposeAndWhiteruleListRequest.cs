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
using Aliyun.Acs.cloud_siem.Transform;
using Aliyun.Acs.cloud_siem.Transform.V20220616;

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
    public class PostEventDisposeAndWhiteruleListRequest : RpcAcsRequest<PostEventDisposeAndWhiteruleListResponse>
    {
        public PostEventDisposeAndWhiteruleListRequest()
            : base("cloud-siem", "2022-06-16", "PostEventDisposeAndWhiteruleList", "cloud-siem", "openAPI")
        {
			Method = MethodType.POST;
        }

		private long? roleFor;

		private string remark;

		private string eventDispose;

		private string receiverInfo;

		private int? roleType;

		private string owner;

		private string threatLevel;

		private string incidentUuid;

		private int? status;

		public long? RoleFor
		{
			get
			{
				return roleFor;
			}
			set	
			{
				roleFor = value;
				DictionaryUtil.Add(BodyParameters, "RoleFor", value.ToString());
			}
		}

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(BodyParameters, "Remark", value);
			}
		}

		public string EventDispose
		{
			get
			{
				return eventDispose;
			}
			set	
			{
				eventDispose = value;
				DictionaryUtil.Add(BodyParameters, "EventDispose", value);
			}
		}

		public string ReceiverInfo
		{
			get
			{
				return receiverInfo;
			}
			set	
			{
				receiverInfo = value;
				DictionaryUtil.Add(BodyParameters, "ReceiverInfo", value);
			}
		}

		public int? RoleType
		{
			get
			{
				return roleType;
			}
			set	
			{
				roleType = value;
				DictionaryUtil.Add(BodyParameters, "RoleType", value.ToString());
			}
		}

		public string Owner
		{
			get
			{
				return owner;
			}
			set	
			{
				owner = value;
				DictionaryUtil.Add(BodyParameters, "Owner", value);
			}
		}

		public string ThreatLevel
		{
			get
			{
				return threatLevel;
			}
			set	
			{
				threatLevel = value;
				DictionaryUtil.Add(BodyParameters, "ThreatLevel", value);
			}
		}

		public string IncidentUuid
		{
			get
			{
				return incidentUuid;
			}
			set	
			{
				incidentUuid = value;
				DictionaryUtil.Add(BodyParameters, "IncidentUuid", value);
			}
		}

		public int? Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(BodyParameters, "Status", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override PostEventDisposeAndWhiteruleListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PostEventDisposeAndWhiteruleListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
