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
using Aliyun.Acs.Ons.Transform;
using Aliyun.Acs.Ons.Transform.V20190214;

namespace Aliyun.Acs.Ons.Model.V20190214
{
    public class OnsConsumerStatusRequest : RpcAcsRequest<OnsConsumerStatusResponse>
    {
        public OnsConsumerStatusRequest()
            : base("Ons", "2019-02-14", "OnsConsumerStatus", "ons", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ons.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ons.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string groupId;

		private string instanceId;

		private bool? needJstack;

		private bool? detail;

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
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

		public bool? NeedJstack
		{
			get
			{
				return needJstack;
			}
			set	
			{
				needJstack = value;
				DictionaryUtil.Add(QueryParameters, "NeedJstack", value.ToString());
			}
		}

		public bool? Detail
		{
			get
			{
				return detail;
			}
			set	
			{
				detail = value;
				DictionaryUtil.Add(QueryParameters, "Detail", value.ToString());
			}
		}

        public override OnsConsumerStatusResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return OnsConsumerStatusResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
