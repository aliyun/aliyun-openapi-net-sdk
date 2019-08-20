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
using Aliyun.Acs.CCC;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20170705;

namespace Aliyun.Acs.CCC.Model.V20170705
{
    public class PublishContactFlowVersionRequest : RpcAcsRequest<PublishContactFlowVersionResponse>
    {
        public PublishContactFlowVersionRequest()
            : base("CCC", "2017-07-05", "PublishContactFlowVersion")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string instanceId;

		private string contactFlowVersionId;

		private bool? useTianGong;

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

		public string ContactFlowVersionId
		{
			get
			{
				return contactFlowVersionId;
			}
			set	
			{
				contactFlowVersionId = value;
				DictionaryUtil.Add(QueryParameters, "ContactFlowVersionId", value);
			}
		}

		public bool? UseTianGong
		{
			get
			{
				return useTianGong;
			}
			set	
			{
				useTianGong = value;
				DictionaryUtil.Add(QueryParameters, "UseTianGong", value.ToString());
			}
		}

        public override PublishContactFlowVersionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PublishContactFlowVersionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
