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
using Aliyun.Acs.retailcloud.Transform;
using Aliyun.Acs.retailcloud.Transform.V20180313;

namespace Aliyun.Acs.retailcloud.Model.V20180313
{
    public class UpdateAppMonitorsRequest : RpcAcsRequest<UpdateAppMonitorsResponse>
    {
        public UpdateAppMonitorsRequest()
            : base("retailcloud", "2018-03-13", "UpdateAppMonitors", "retailcloud", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.retailcloud.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? mainUserId;

		private string silenceTime;

		private List<long?> monitorIdss = new List<long?>(){ };

		private long? templateId;

		public long? MainUserId
		{
			get
			{
				return mainUserId;
			}
			set	
			{
				mainUserId = value;
				DictionaryUtil.Add(BodyParameters, "MainUserId", value.ToString());
			}
		}

		public string SilenceTime
		{
			get
			{
				return silenceTime;
			}
			set	
			{
				silenceTime = value;
				DictionaryUtil.Add(BodyParameters, "SilenceTime", value);
			}
		}

		public List<long?> MonitorIdss
		{
			get
			{
				return monitorIdss;
			}

			set
			{
				monitorIdss = value;
				for (int i = 0; i < monitorIdss.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"MonitorIds." + (i + 1) , monitorIdss[i]);
				}
			}
		}

		public long? TemplateId
		{
			get
			{
				return templateId;
			}
			set	
			{
				templateId = value;
				DictionaryUtil.Add(BodyParameters, "TemplateId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateAppMonitorsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateAppMonitorsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
