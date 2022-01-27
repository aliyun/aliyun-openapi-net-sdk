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
using Aliyun.Acs.LinkWAN.Transform;
using Aliyun.Acs.LinkWAN.Transform.V20190301;

namespace Aliyun.Acs.LinkWAN.Model.V20190301
{
    public class SubmitGatewayLocalConfigAddingTaskRequest : RpcAcsRequest<SubmitGatewayLocalConfigAddingTaskResponse>
    {
        public SubmitGatewayLocalConfigAddingTaskRequest()
            : base("LinkWAN", "2019-03-01", "SubmitGatewayLocalConfigAddingTask", "linkwan", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.LinkWAN.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.LinkWAN.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? freq;

		private int? datr;

		private string d2dKey;

		private string gwEui;

		private string d2dAddr;

		public int? Freq
		{
			get
			{
				return freq;
			}
			set	
			{
				freq = value;
				DictionaryUtil.Add(QueryParameters, "Freq", value.ToString());
			}
		}

		public int? Datr
		{
			get
			{
				return datr;
			}
			set	
			{
				datr = value;
				DictionaryUtil.Add(QueryParameters, "Datr", value.ToString());
			}
		}

		public string D2dKey
		{
			get
			{
				return d2dKey;
			}
			set	
			{
				d2dKey = value;
				DictionaryUtil.Add(QueryParameters, "D2dKey", value);
			}
		}

		public string GwEui
		{
			get
			{
				return gwEui;
			}
			set	
			{
				gwEui = value;
				DictionaryUtil.Add(QueryParameters, "GwEui", value);
			}
		}

		public string D2dAddr
		{
			get
			{
				return d2dAddr;
			}
			set	
			{
				d2dAddr = value;
				DictionaryUtil.Add(QueryParameters, "D2dAddr", value);
			}
		}

        public override SubmitGatewayLocalConfigAddingTaskResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SubmitGatewayLocalConfigAddingTaskResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
