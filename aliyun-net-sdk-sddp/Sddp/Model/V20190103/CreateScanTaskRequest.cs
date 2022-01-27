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
using Aliyun.Acs.Sddp;
using Aliyun.Acs.Sddp.Transform;
using Aliyun.Acs.Sddp.Transform.V20190103;

namespace Aliyun.Acs.Sddp.Model.V20190103
{
    public class CreateScanTaskRequest : RpcAcsRequest<CreateScanTaskResponse>
    {
        public CreateScanTaskRequest()
            : base("Sddp", "2019-01-03", "CreateScanTask")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sddp.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sddp.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? runHour;

		private string scanRangeContent;

		private string taskName;

		private long? dataLimitId;

		private int? runMinute;

		private int? intervalDay;

		private int? scanRange;

		private string ossScanPath;

		private long? resourceType;

		private string taskUserName;

		public int? RunHour
		{
			get
			{
				return runHour;
			}
			set	
			{
				runHour = value;
				DictionaryUtil.Add(QueryParameters, "RunHour", value.ToString());
			}
		}

		public string ScanRangeContent
		{
			get
			{
				return scanRangeContent;
			}
			set	
			{
				scanRangeContent = value;
				DictionaryUtil.Add(QueryParameters, "ScanRangeContent", value);
			}
		}

		public string TaskName
		{
			get
			{
				return taskName;
			}
			set	
			{
				taskName = value;
				DictionaryUtil.Add(QueryParameters, "TaskName", value);
			}
		}

		public long? DataLimitId
		{
			get
			{
				return dataLimitId;
			}
			set	
			{
				dataLimitId = value;
				DictionaryUtil.Add(QueryParameters, "DataLimitId", value.ToString());
			}
		}

		public int? RunMinute
		{
			get
			{
				return runMinute;
			}
			set	
			{
				runMinute = value;
				DictionaryUtil.Add(QueryParameters, "RunMinute", value.ToString());
			}
		}

		public int? IntervalDay
		{
			get
			{
				return intervalDay;
			}
			set	
			{
				intervalDay = value;
				DictionaryUtil.Add(QueryParameters, "IntervalDay", value.ToString());
			}
		}

		public int? ScanRange
		{
			get
			{
				return scanRange;
			}
			set	
			{
				scanRange = value;
				DictionaryUtil.Add(QueryParameters, "ScanRange", value.ToString());
			}
		}

		public string OssScanPath
		{
			get
			{
				return ossScanPath;
			}
			set	
			{
				ossScanPath = value;
				DictionaryUtil.Add(QueryParameters, "OssScanPath", value);
			}
		}

		public long? ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value.ToString());
			}
		}

		public string TaskUserName
		{
			get
			{
				return taskUserName;
			}
			set	
			{
				taskUserName = value;
				DictionaryUtil.Add(QueryParameters, "TaskUserName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateScanTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateScanTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
