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
using Aliyun.Acs.Cassandra.Transform;
using Aliyun.Acs.Cassandra.Transform.V20190101;

namespace Aliyun.Acs.Cassandra.Model.V20190101
{
    public class ModifyInstanceMaintainTimeRequest : RpcAcsRequest<ModifyInstanceMaintainTimeResponse>
    {
        public ModifyInstanceMaintainTimeRequest()
            : base("Cassandra", "2019-01-01", "ModifyInstanceMaintainTime", "Cassandra", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cassandra.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cassandra.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clusterId;

		private string maintainEndTime;

		private string maintainStartTime;

		public string ClusterId
		{
			get
			{
				return clusterId;
			}
			set	
			{
				clusterId = value;
				DictionaryUtil.Add(QueryParameters, "ClusterId", value);
			}
		}

		public string MaintainEndTime
		{
			get
			{
				return maintainEndTime;
			}
			set	
			{
				maintainEndTime = value;
				DictionaryUtil.Add(QueryParameters, "MaintainEndTime", value);
			}
		}

		public string MaintainStartTime
		{
			get
			{
				return maintainStartTime;
			}
			set	
			{
				maintainStartTime = value;
				DictionaryUtil.Add(QueryParameters, "MaintainStartTime", value);
			}
		}

        public override ModifyInstanceMaintainTimeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyInstanceMaintainTimeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
