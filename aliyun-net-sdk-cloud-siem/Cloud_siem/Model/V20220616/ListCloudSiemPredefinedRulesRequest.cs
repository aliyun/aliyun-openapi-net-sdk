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
    public class ListCloudSiemPredefinedRulesRequest : RpcAcsRequest<ListCloudSiemPredefinedRulesResponse>
    {
        public ListCloudSiemPredefinedRulesRequest()
            : base("cloud-siem", "2022-06-16", "ListCloudSiemPredefinedRules", "cloud-siem", "openAPI")
        {
			Method = MethodType.POST;
        }

		private long? roleFor;

		private string attCk;

		private string ruleName;

		private long? startTime;

		private int? pageSize;

		private int? roleType;

		private string id;

		private string orderField;

		private string order;

		private string ruleType;

		private long? endTime;

		private int? currentPage;

		private string logSource;

		private string alertType;

		private string eventTransferType;

		private List<string> threatLevels = new List<string>(){ };

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

		public string AttCk
		{
			get
			{
				return attCk;
			}
			set	
			{
				attCk = value;
				DictionaryUtil.Add(BodyParameters, "AttCk", value);
			}
		}

		public string RuleName
		{
			get
			{
				return ruleName;
			}
			set	
			{
				ruleName = value;
				DictionaryUtil.Add(BodyParameters, "RuleName", value);
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

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(BodyParameters, "Id", value);
			}
		}

		public string OrderField
		{
			get
			{
				return orderField;
			}
			set	
			{
				orderField = value;
				DictionaryUtil.Add(BodyParameters, "OrderField", value);
			}
		}

		public string Order
		{
			get
			{
				return order;
			}
			set	
			{
				order = value;
				DictionaryUtil.Add(BodyParameters, "Order", value);
			}
		}

		public string RuleType
		{
			get
			{
				return ruleType;
			}
			set	
			{
				ruleType = value;
				DictionaryUtil.Add(BodyParameters, "RuleType", value);
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

		public string LogSource
		{
			get
			{
				return logSource;
			}
			set	
			{
				logSource = value;
				DictionaryUtil.Add(BodyParameters, "LogSource", value);
			}
		}

		public string AlertType
		{
			get
			{
				return alertType;
			}
			set	
			{
				alertType = value;
				DictionaryUtil.Add(BodyParameters, "AlertType", value);
			}
		}

		public string EventTransferType
		{
			get
			{
				return eventTransferType;
			}
			set	
			{
				eventTransferType = value;
				DictionaryUtil.Add(BodyParameters, "EventTransferType", value);
			}
		}

		public List<string> ThreatLevels
		{
			get
			{
				return threatLevels;
			}

			set
			{
				threatLevels = value;
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

        public override ListCloudSiemPredefinedRulesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListCloudSiemPredefinedRulesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
