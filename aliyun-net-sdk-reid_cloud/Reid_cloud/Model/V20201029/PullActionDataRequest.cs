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
using Aliyun.Acs.reid_cloud.Transform;
using Aliyun.Acs.reid_cloud.Transform.V20201029;

namespace Aliyun.Acs.reid_cloud.Model.V20201029
{
    public class PullActionDataRequest : RpcAcsRequest<PullActionDataResponse>
    {
        public PullActionDataRequest()
            : base("reid_cloud", "2020-10-29", "PullActionData", "1.2.1", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.reid_cloud.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.reid_cloud.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? partitionIndex;

		private long? storeId;

		private long? endMessageId;

		private int? limit;

		private long? startMessageId;

		public int? PartitionIndex
		{
			get
			{
				return partitionIndex;
			}
			set	
			{
				partitionIndex = value;
				DictionaryUtil.Add(BodyParameters, "PartitionIndex", value.ToString());
			}
		}

		public long? StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
				DictionaryUtil.Add(BodyParameters, "StoreId", value.ToString());
			}
		}

		public long? EndMessageId
		{
			get
			{
				return endMessageId;
			}
			set	
			{
				endMessageId = value;
				DictionaryUtil.Add(BodyParameters, "EndMessageId", value.ToString());
			}
		}

		public int? Limit
		{
			get
			{
				return limit;
			}
			set	
			{
				limit = value;
				DictionaryUtil.Add(BodyParameters, "Limit", value.ToString());
			}
		}

		public long? StartMessageId
		{
			get
			{
				return startMessageId;
			}
			set	
			{
				startMessageId = value;
				DictionaryUtil.Add(BodyParameters, "StartMessageId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override PullActionDataResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PullActionDataResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
