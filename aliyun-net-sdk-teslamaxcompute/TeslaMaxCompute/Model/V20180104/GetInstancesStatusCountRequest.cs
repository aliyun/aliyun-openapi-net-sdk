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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.TeslaMaxCompute.Transform;
using Aliyun.Acs.TeslaMaxCompute.Transform.V20180104;
using System.Collections.Generic;

namespace Aliyun.Acs.TeslaMaxCompute.Model.V20180104
{
    public class GetInstancesStatusCountRequest : RpcAcsRequest<GetInstancesStatusCountResponse>
    {
        public GetInstancesStatusCountRequest()
            : base("TeslaMaxCompute", "2018-01-04", "GetInstancesStatusCount")
        {
        }

		private string cluster;

		private string region;

		public string Cluster
		{
			get
			{
				return cluster;
			}
			set	
			{
				cluster = value;
				DictionaryUtil.Add(QueryParameters, "Cluster", value);
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetInstancesStatusCountResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return GetInstancesStatusCountResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}