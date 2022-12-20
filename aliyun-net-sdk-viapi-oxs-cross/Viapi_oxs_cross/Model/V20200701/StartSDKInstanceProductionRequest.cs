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
using Aliyun.Acs.viapi_oxs_cross;
using Aliyun.Acs.viapi_oxs_cross.Transform;
using Aliyun.Acs.viapi_oxs_cross.Transform.V20200701;

namespace Aliyun.Acs.viapi_oxs_cross.Model.V20200701
{
    public class StartSDKInstanceProductionRequest : RpcAcsRequest<StartSDKInstanceProductionResponse>
    {
        public StartSDKInstanceProductionRequest()
            : base("viapi-oxs-cross", "2020-07-01", "StartSDKInstanceProduction")
        {
			Method = MethodType.POST;
        }

		private string instanceId;

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(BodyParameters, "InstanceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override StartSDKInstanceProductionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StartSDKInstanceProductionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
