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
using Aliyun.Acs.idrsservice.Transform;
using Aliyun.Acs.idrsservice.Transform.V20200630;

namespace Aliyun.Acs.idrsservice.Model.V20200630
{
    public class UpdateServiceConfigurationRequest : RpcAcsRequest<UpdateServiceConfigurationResponse>
    {
        public UpdateServiceConfigurationRequest()
            : base("idrsservice", "2020-06-30", "UpdateServiceConfiguration", "idrsservice", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.idrsservice.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.idrsservice.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? liveRecordMaxClient;

		private int? liveRecordVideoResolution;

		private int? taskItemQueueSize;

		private int? liveRecordLayout;

		private int? clientQueueSize;

		private string liveRecordTaskProfile;

		private bool? liveRecordAll;

		private bool? liveRecordEveryOne;

		public int? LiveRecordMaxClient
		{
			get
			{
				return liveRecordMaxClient;
			}
			set	
			{
				liveRecordMaxClient = value;
				DictionaryUtil.Add(QueryParameters, "LiveRecordMaxClient", value.ToString());
			}
		}

		public int? LiveRecordVideoResolution
		{
			get
			{
				return liveRecordVideoResolution;
			}
			set	
			{
				liveRecordVideoResolution = value;
				DictionaryUtil.Add(QueryParameters, "LiveRecordVideoResolution", value.ToString());
			}
		}

		public int? TaskItemQueueSize
		{
			get
			{
				return taskItemQueueSize;
			}
			set	
			{
				taskItemQueueSize = value;
				DictionaryUtil.Add(QueryParameters, "TaskItemQueueSize", value.ToString());
			}
		}

		public int? LiveRecordLayout
		{
			get
			{
				return liveRecordLayout;
			}
			set	
			{
				liveRecordLayout = value;
				DictionaryUtil.Add(QueryParameters, "LiveRecordLayout", value.ToString());
			}
		}

		public int? ClientQueueSize
		{
			get
			{
				return clientQueueSize;
			}
			set	
			{
				clientQueueSize = value;
				DictionaryUtil.Add(QueryParameters, "ClientQueueSize", value.ToString());
			}
		}

		public string LiveRecordTaskProfile
		{
			get
			{
				return liveRecordTaskProfile;
			}
			set	
			{
				liveRecordTaskProfile = value;
				DictionaryUtil.Add(QueryParameters, "LiveRecordTaskProfile", value);
			}
		}

		public bool? LiveRecordAll
		{
			get
			{
				return liveRecordAll;
			}
			set	
			{
				liveRecordAll = value;
				DictionaryUtil.Add(QueryParameters, "LiveRecordAll", value.ToString());
			}
		}

		public bool? LiveRecordEveryOne
		{
			get
			{
				return liveRecordEveryOne;
			}
			set	
			{
				liveRecordEveryOne = value;
				DictionaryUtil.Add(QueryParameters, "LiveRecordEveryOne", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateServiceConfigurationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateServiceConfigurationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
