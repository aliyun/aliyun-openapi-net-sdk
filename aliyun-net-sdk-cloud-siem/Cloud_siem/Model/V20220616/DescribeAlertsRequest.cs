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
    public class DescribeAlertsRequest : RpcAcsRequest<DescribeAlertsResponse>
    {
        public DescribeAlertsRequest()
            : base("cloud-siem", "2022-06-16", "DescribeAlerts", "cloud-siem", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string source;

		private string isDefend;

		private long? startTime;

		private string subUserId;

		private int? pageSize;

		private List<string> levels = new List<string>(){ };

		private long? endTime;

		private string alertTitle;

		private int? currentPage;

		private string alertUuid;

		public string Source
		{
			get
			{
				return source;
			}
			set	
			{
				source = value;
				DictionaryUtil.Add(BodyParameters, "Source", value);
			}
		}

		public string IsDefend
		{
			get
			{
				return isDefend;
			}
			set	
			{
				isDefend = value;
				DictionaryUtil.Add(BodyParameters, "IsDefend", value);
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

		public string SubUserId
		{
			get
			{
				return subUserId;
			}
			set	
			{
				subUserId = value;
				DictionaryUtil.Add(BodyParameters, "SubUserId", value);
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

		public List<string> Levels
		{
			get
			{
				return levels;
			}

			set
			{
				levels = value;
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

		public string AlertTitle
		{
			get
			{
				return alertTitle;
			}
			set	
			{
				alertTitle = value;
				DictionaryUtil.Add(BodyParameters, "AlertTitle", value);
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

		public string AlertUuid
		{
			get
			{
				return alertUuid;
			}
			set	
			{
				alertUuid = value;
				DictionaryUtil.Add(BodyParameters, "AlertUuid", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeAlertsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeAlertsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
