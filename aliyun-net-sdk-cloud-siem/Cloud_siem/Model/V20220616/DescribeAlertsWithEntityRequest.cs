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
    public class DescribeAlertsWithEntityRequest : RpcAcsRequest<DescribeAlertsWithEntityResponse>
    {
        public DescribeAlertsWithEntityRequest()
            : base("cloud-siem", "2022-06-16", "DescribeAlertsWithEntity", "cloud-siem", "openAPI")
        {
			Method = MethodType.POST;
        }

		private long? roleFor;

		private long? entityId;

		private long? startTime;

		private int? pageSize;

		private int? roleType;

		private string sophonTaskId;

		private long? endTime;

		private int? currentPage;

		private string entityUuid;

		private string incidentUuid;

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

		public long? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(BodyParameters, "StartTime", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(BodyParameters, "PageSize", value.ToString());
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

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(BodyParameters, "EndTime", value.ToString());
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(BodyParameters, "CurrentPage", value.ToString());
			}
		}

		public string EntityUuid
		{
			get
			{
				return entityUuid;
			}
			set	
			{
				entityUuid = value;
				DictionaryUtil.Add(BodyParameters, "EntityUuid", value);
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

        public override DescribeAlertsWithEntityResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeAlertsWithEntityResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
