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
    public class DescribeSoarRecordsRequest : RpcAcsRequest<DescribeSoarRecordsResponse>
    {
        public DescribeSoarRecordsRequest()
            : base("sophonsoar", "2022-07-28", "DescribeSoarRecords")
        {
			Protocol = ProtocolType.HTTPS;
        }

		private string taskflowMd5;

		private long? endMillis;

		private long? startMillis;

		private int? pageNumber;

		private string taskStatus;

		private string playbookUuid;

		private string requestUuid;

		private int? pageSize;

		private string triggerUser;

		private string lang;

		public string TaskflowMd5
		{
			get
			{
				return taskflowMd5;
			}
			set	
			{
				taskflowMd5 = value;
				DictionaryUtil.Add(QueryParameters, "TaskflowMd5", value);
			}
		}

		public long? EndMillis
		{
			get
			{
				return endMillis;
			}
			set	
			{
				endMillis = value;
				DictionaryUtil.Add(QueryParameters, "EndMillis", value.ToString());
			}
		}

		public long? StartMillis
		{
			get
			{
				return startMillis;
			}
			set	
			{
				startMillis = value;
				DictionaryUtil.Add(QueryParameters, "StartMillis", value.ToString());
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string TaskStatus
		{
			get
			{
				return taskStatus;
			}
			set	
			{
				taskStatus = value;
				DictionaryUtil.Add(QueryParameters, "TaskStatus", value);
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

		public string RequestUuid
		{
			get
			{
				return requestUuid;
			}
			set	
			{
				requestUuid = value;
				DictionaryUtil.Add(QueryParameters, "RequestUuid", value);
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string TriggerUser
		{
			get
			{
				return triggerUser;
			}
			set	
			{
				triggerUser = value;
				DictionaryUtil.Add(QueryParameters, "TriggerUser", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeSoarRecordsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeSoarRecordsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
