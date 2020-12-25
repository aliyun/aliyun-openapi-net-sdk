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
using Aliyun.Acs.Emr.Transform;
using Aliyun.Acs.Emr.Transform.V20160408;

namespace Aliyun.Acs.Emr.Model.V20160408
{
    public class RunScalingActionV2Request : RpcAcsRequest<RunScalingActionV2Response>
    {
        public RunScalingActionV2Request()
            : base("Emr", "2016-04-08", "RunScalingActionV2", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string scalingActionType;

		private string scalingGroupBizId;

		private string resourceGroupId;

		private string actionParam;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string ScalingActionType
		{
			get
			{
				return scalingActionType;
			}
			set	
			{
				scalingActionType = value;
				DictionaryUtil.Add(QueryParameters, "ScalingActionType", value);
			}
		}

		public string ScalingGroupBizId
		{
			get
			{
				return scalingGroupBizId;
			}
			set	
			{
				scalingGroupBizId = value;
				DictionaryUtil.Add(QueryParameters, "ScalingGroupBizId", value);
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public string ActionParam
		{
			get
			{
				return actionParam;
			}
			set	
			{
				actionParam = value;
				DictionaryUtil.Add(QueryParameters, "ActionParam", value);
			}
		}

        public override RunScalingActionV2Response GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RunScalingActionV2ResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
