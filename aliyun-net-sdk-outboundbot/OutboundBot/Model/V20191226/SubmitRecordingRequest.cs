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
using Aliyun.Acs.OutboundBot.Transform;
using Aliyun.Acs.OutboundBot.Transform.V20191226;

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
    public class SubmitRecordingRequest : RpcAcsRequest<SubmitRecordingResponse>
    {
        public SubmitRecordingRequest()
            : base("OutboundBot", "2019-12-26", "SubmitRecording", "outboundbot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string mergedRecording;

		private string resourceRecording;

		private string instanceId;

		private long? instanceOwnerId;

		private string taskId;

		public string MergedRecording
		{
			get
			{
				return mergedRecording;
			}
			set	
			{
				mergedRecording = value;
				DictionaryUtil.Add(QueryParameters, "MergedRecording", value);
			}
		}

		public string ResourceRecording
		{
			get
			{
				return resourceRecording;
			}
			set	
			{
				resourceRecording = value;
				DictionaryUtil.Add(QueryParameters, "ResourceRecording", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public long? InstanceOwnerId
		{
			get
			{
				return instanceOwnerId;
			}
			set	
			{
				instanceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceOwnerId", value.ToString());
			}
		}

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(QueryParameters, "TaskId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SubmitRecordingResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitRecordingResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
