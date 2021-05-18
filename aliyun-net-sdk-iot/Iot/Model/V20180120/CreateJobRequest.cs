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
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20180120;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class CreateJobRequest : RpcAcsRequest<CreateJobResponse>
    {
        public CreateJobRequest()
            : base("Iot", "2018-01-20", "CreateJob", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Iot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string jobDocument;

		private string description;

		private string type;

		private string rolloutConfig;

		private string iotInstanceId;

		private string jobName;

		private string timeoutConfig;

		private string targetConfig;

		private string jobFile;

		private long? scheduledTime;

		public string JobDocument
		{
			get
			{
				return jobDocument;
			}
			set	
			{
				jobDocument = value;
				DictionaryUtil.Add(QueryParameters, "JobDocument", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(QueryParameters, "Type", value);
			}
		}

		public string RolloutConfig
		{
			get
			{
				return rolloutConfig;
			}
			set	
			{
				rolloutConfig = value;
				DictionaryUtil.Add(QueryParameters, "RolloutConfig", value);
			}
		}

		public string IotInstanceId
		{
			get
			{
				return iotInstanceId;
			}
			set	
			{
				iotInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "IotInstanceId", value);
			}
		}

		public string JobName
		{
			get
			{
				return jobName;
			}
			set	
			{
				jobName = value;
				DictionaryUtil.Add(QueryParameters, "JobName", value);
			}
		}

		public string TimeoutConfig
		{
			get
			{
				return timeoutConfig;
			}
			set	
			{
				timeoutConfig = value;
				DictionaryUtil.Add(QueryParameters, "TimeoutConfig", value);
			}
		}

		public string TargetConfig
		{
			get
			{
				return targetConfig;
			}
			set	
			{
				targetConfig = value;
				DictionaryUtil.Add(QueryParameters, "TargetConfig", value);
			}
		}

		public string JobFile
		{
			get
			{
				return jobFile;
			}
			set	
			{
				jobFile = value;
				DictionaryUtil.Add(QueryParameters, "JobFile", value);
			}
		}

		public long? ScheduledTime
		{
			get
			{
				return scheduledTime;
			}
			set	
			{
				scheduledTime = value;
				DictionaryUtil.Add(QueryParameters, "ScheduledTime", value.ToString());
			}
		}

        public override CreateJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
