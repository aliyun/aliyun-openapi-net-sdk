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
using Aliyun.Acs.sae.Transform;
using Aliyun.Acs.sae.Transform.V20190506;

namespace Aliyun.Acs.sae.Model.V20190506
{
    public class RollbackApplicationRequest : RoaAcsRequest<RollbackApplicationResponse>
    {
        public RollbackApplicationRequest()
            : base("sae", "2019-05-06", "RollbackApplication", "serverless", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.sae.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/pop/v1/sam/app/rollbackApplication";
			Method = MethodType.PUT;
        }

		private int? minReadyInstances;

		private string versionId;

		private string appId;

		private int? batchWaitTime;

		private string autoEnableApplicationScalingRule;

		private string updateStrategy;

		public int? MinReadyInstances
		{
			get
			{
				return minReadyInstances;
			}
			set	
			{
				minReadyInstances = value;
				DictionaryUtil.Add(QueryParameters, "MinReadyInstances", value.ToString());
			}
		}

		public string VersionId
		{
			get
			{
				return versionId;
			}
			set	
			{
				versionId = value;
				DictionaryUtil.Add(QueryParameters, "VersionId", value);
			}
		}

		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		public int? BatchWaitTime
		{
			get
			{
				return batchWaitTime;
			}
			set	
			{
				batchWaitTime = value;
				DictionaryUtil.Add(QueryParameters, "BatchWaitTime", value.ToString());
			}
		}

		public string AutoEnableApplicationScalingRule
		{
			get
			{
				return autoEnableApplicationScalingRule;
			}
			set	
			{
				autoEnableApplicationScalingRule = value;
				DictionaryUtil.Add(QueryParameters, "AutoEnableApplicationScalingRule", value);
			}
		}

		public string UpdateStrategy
		{
			get
			{
				return updateStrategy;
			}
			set	
			{
				updateStrategy = value;
				DictionaryUtil.Add(QueryParameters, "UpdateStrategy", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RollbackApplicationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RollbackApplicationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
