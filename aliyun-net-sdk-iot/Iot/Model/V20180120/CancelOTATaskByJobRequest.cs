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
    public class CancelOTATaskByJobRequest : RpcAcsRequest<CancelOTATaskByJobResponse>
    {
        public CancelOTATaskByJobRequest()
            : base("Iot", "2018-01-20", "CancelOTATaskByJob", "iot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? cancelScheduledTask;

		private string jobId;

		private string iotInstanceId;

		private bool? cancelQueuedTask;

		private bool? cancelInProgressTask;

		private bool? cancelNotifiedTask;

		public bool? CancelScheduledTask
		{
			get
			{
				return cancelScheduledTask;
			}
			set	
			{
				cancelScheduledTask = value;
				DictionaryUtil.Add(QueryParameters, "CancelScheduledTask", value.ToString());
			}
		}

		public string JobId
		{
			get
			{
				return jobId;
			}
			set	
			{
				jobId = value;
				DictionaryUtil.Add(QueryParameters, "JobId", value);
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

		public bool? CancelQueuedTask
		{
			get
			{
				return cancelQueuedTask;
			}
			set	
			{
				cancelQueuedTask = value;
				DictionaryUtil.Add(QueryParameters, "CancelQueuedTask", value.ToString());
			}
		}

		public bool? CancelInProgressTask
		{
			get
			{
				return cancelInProgressTask;
			}
			set	
			{
				cancelInProgressTask = value;
				DictionaryUtil.Add(QueryParameters, "CancelInProgressTask", value.ToString());
			}
		}

		public bool? CancelNotifiedTask
		{
			get
			{
				return cancelNotifiedTask;
			}
			set	
			{
				cancelNotifiedTask = value;
				DictionaryUtil.Add(QueryParameters, "CancelNotifiedTask", value.ToString());
			}
		}

        public override CancelOTATaskByJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CancelOTATaskByJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
