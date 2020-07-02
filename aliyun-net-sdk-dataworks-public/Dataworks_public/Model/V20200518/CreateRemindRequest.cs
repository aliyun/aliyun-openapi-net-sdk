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
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class CreateRemindRequest : RpcAcsRequest<CreateRemindResponse>
    {
        public CreateRemindRequest()
            : base("dataworks-public", "2020-05-18", "CreateRemind", "dide", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string dndEnd;

		private string alertUnit;

		private string remindUnit;

		private int? alertInterval;

		private string alertMethods;

		private string robotUrls;

		private int? maxAlertTimes;

		private string bizProcessIds;

		private string remindType;

		private string alertTargets;

		private string baselineIds;

		private string detail;

		private string remindName;

		private long? projectId;

		private string nodeIds;

		public string DndEnd
		{
			get
			{
				return dndEnd;
			}
			set	
			{
				dndEnd = value;
				DictionaryUtil.Add(BodyParameters, "DndEnd", value);
			}
		}

		public string AlertUnit
		{
			get
			{
				return alertUnit;
			}
			set	
			{
				alertUnit = value;
				DictionaryUtil.Add(BodyParameters, "AlertUnit", value);
			}
		}

		public string RemindUnit
		{
			get
			{
				return remindUnit;
			}
			set	
			{
				remindUnit = value;
				DictionaryUtil.Add(BodyParameters, "RemindUnit", value);
			}
		}

		public int? AlertInterval
		{
			get
			{
				return alertInterval;
			}
			set	
			{
				alertInterval = value;
				DictionaryUtil.Add(BodyParameters, "AlertInterval", value.ToString());
			}
		}

		public string AlertMethods
		{
			get
			{
				return alertMethods;
			}
			set	
			{
				alertMethods = value;
				DictionaryUtil.Add(BodyParameters, "AlertMethods", value);
			}
		}

		public string RobotUrls
		{
			get
			{
				return robotUrls;
			}
			set	
			{
				robotUrls = value;
				DictionaryUtil.Add(BodyParameters, "RobotUrls", value);
			}
		}

		public int? MaxAlertTimes
		{
			get
			{
				return maxAlertTimes;
			}
			set	
			{
				maxAlertTimes = value;
				DictionaryUtil.Add(BodyParameters, "MaxAlertTimes", value.ToString());
			}
		}

		public string BizProcessIds
		{
			get
			{
				return bizProcessIds;
			}
			set	
			{
				bizProcessIds = value;
				DictionaryUtil.Add(BodyParameters, "BizProcessIds", value);
			}
		}

		public string RemindType
		{
			get
			{
				return remindType;
			}
			set	
			{
				remindType = value;
				DictionaryUtil.Add(BodyParameters, "RemindType", value);
			}
		}

		public string AlertTargets
		{
			get
			{
				return alertTargets;
			}
			set	
			{
				alertTargets = value;
				DictionaryUtil.Add(BodyParameters, "AlertTargets", value);
			}
		}

		public string BaselineIds
		{
			get
			{
				return baselineIds;
			}
			set	
			{
				baselineIds = value;
				DictionaryUtil.Add(BodyParameters, "BaselineIds", value);
			}
		}

		public string Detail
		{
			get
			{
				return detail;
			}
			set	
			{
				detail = value;
				DictionaryUtil.Add(BodyParameters, "Detail", value);
			}
		}

		public string RemindName
		{
			get
			{
				return remindName;
			}
			set	
			{
				remindName = value;
				DictionaryUtil.Add(BodyParameters, "RemindName", value);
			}
		}

		public long? ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(BodyParameters, "ProjectId", value.ToString());
			}
		}

		public string NodeIds
		{
			get
			{
				return nodeIds;
			}
			set	
			{
				nodeIds = value;
				DictionaryUtil.Add(BodyParameters, "NodeIds", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateRemindResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateRemindResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
