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
    public class DescribeEntityInfoRequest : RpcAcsRequest<DescribeEntityInfoResponse>
    {
        public DescribeEntityInfoRequest()
            : base("cloud-siem", "2022-06-16", "DescribeEntityInfo", "cloud-siem", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string entityIdentity;

		private long? roleFor;

		private long? entityId;

		private int? roleType;

		private string sophonTaskId;

		private string incidentUuid;

		public string EntityIdentity
		{
			get
			{
				return entityIdentity;
			}
			set	
			{
				entityIdentity = value;
				DictionaryUtil.Add(BodyParameters, "EntityIdentity", value);
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
				DictionaryUtil.Add(BodyParameters, "RoleFor", value.ToString());
			}
		}

		public long? EntityId
		{
			get
			{
				return entityId;
			}
			set	
			{
				entityId = value;
				DictionaryUtil.Add(BodyParameters, "EntityId", value.ToString());
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

		public string SophonTaskId
		{
			get
			{
				return sophonTaskId;
			}
			set	
			{
				sophonTaskId = value;
				DictionaryUtil.Add(BodyParameters, "SophonTaskId", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeEntityInfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeEntityInfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
