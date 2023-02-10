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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class CreateLiveStreamMonitorRequest : RpcAcsRequest<CreateLiveStreamMonitorResponse>
    {
        public CreateLiveStreamMonitorRequest()
            : base("live", "2016-11-01", "CreateLiveStreamMonitor", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string monitorConfig;

		private string monitorName;

		private string stream;

		private string outputTemplate;

		private string app;

		private string inputList;

		private long? ownerId;

		private string domain;

		public string MonitorConfig
		{
			get
			{
				return monitorConfig;
			}
			set	
			{
				monitorConfig = value;
				DictionaryUtil.Add(QueryParameters, "MonitorConfig", value);
			}
		}

		public string MonitorName
		{
			get
			{
				return monitorName;
			}
			set	
			{
				monitorName = value;
				DictionaryUtil.Add(QueryParameters, "MonitorName", value);
			}
		}

		public string Stream
		{
			get
			{
				return stream;
			}
			set	
			{
				stream = value;
				DictionaryUtil.Add(QueryParameters, "Stream", value);
			}
		}

		public string OutputTemplate
		{
			get
			{
				return outputTemplate;
			}
			set	
			{
				outputTemplate = value;
				DictionaryUtil.Add(QueryParameters, "OutputTemplate", value);
			}
		}

		public string App
		{
			get
			{
				return app;
			}
			set	
			{
				app = value;
				DictionaryUtil.Add(QueryParameters, "App", value);
			}
		}

		public string InputList
		{
			get
			{
				return inputList;
			}
			set	
			{
				inputList = value;
				DictionaryUtil.Add(QueryParameters, "InputList", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
				DictionaryUtil.Add(QueryParameters, "Domain", value);
			}
		}

        public override CreateLiveStreamMonitorResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateLiveStreamMonitorResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
