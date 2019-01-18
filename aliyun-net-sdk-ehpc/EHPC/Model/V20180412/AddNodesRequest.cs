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
using Aliyun.Acs.EHPC.Transform;
using Aliyun.Acs.EHPC.Transform.V20180412;
using System.Collections.Generic;

namespace Aliyun.Acs.EHPC.Model.V20180412
{
    public class AddNodesRequest : RpcAcsRequest<AddNodesResponse>
    {
        public AddNodesRequest()
            : base("EHPC", "2018-04-12", "AddNodes", "ehs", "openAPI")
        {
        }

		private int? autoRenewPeriod;

		private int? period;

		private string imageId;

		private int? count;

		private string clusterId;

		private string computeSpotStrategy;

		private string jobQueue;

		private string accessKeyId;

		private string imageOwnerAlias;

		private string periodUnit;

		private string autoRenew;

		private string ecsChargeType;

		private string createMode;

		private int? systemDiskSize;

		private string action;

		private string instanceType;

		private string computeSpotPriceLimit;

		public int? AutoRenewPeriod
		{
			get
			{
				return autoRenewPeriod;
			}
			set	
			{
				autoRenewPeriod = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenewPeriod", value.ToString());
			}
		}

		public int? Period
		{
			get
			{
				return period;
			}
			set	
			{
				period = value;
				DictionaryUtil.Add(QueryParameters, "Period", value.ToString());
			}
		}

		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
			}
		}

		public int? Count
		{
			get
			{
				return count;
			}
			set	
			{
				count = value;
				DictionaryUtil.Add(QueryParameters, "Count", value.ToString());
			}
		}

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

		public string ComputeSpotStrategy
		{
			get
			{
				return computeSpotStrategy;
			}
			set	
			{
				computeSpotStrategy = value;
				DictionaryUtil.Add(QueryParameters, "ComputeSpotStrategy", value);
			}
		}

		public string JobQueue
		{
			get
			{
				return jobQueue;
			}
			set	
			{
				jobQueue = value;
				DictionaryUtil.Add(QueryParameters, "JobQueue", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string ImageOwnerAlias
		{
			get
			{
				return imageOwnerAlias;
			}
			set	
			{
				imageOwnerAlias = value;
				DictionaryUtil.Add(QueryParameters, "ImageOwnerAlias", value);
			}
		}

		public string PeriodUnit
		{
			get
			{
				return periodUnit;
			}
			set	
			{
				periodUnit = value;
				DictionaryUtil.Add(QueryParameters, "PeriodUnit", value);
			}
		}

		public string AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenew", value);
			}
		}

		public string EcsChargeType
		{
			get
			{
				return ecsChargeType;
			}
			set	
			{
				ecsChargeType = value;
				DictionaryUtil.Add(QueryParameters, "EcsChargeType", value);
			}
		}

		public string CreateMode
		{
			get
			{
				return createMode;
			}
			set	
			{
				createMode = value;
				DictionaryUtil.Add(QueryParameters, "CreateMode", value);
			}
		}

		public int? SystemDiskSize
		{
			get
			{
				return systemDiskSize;
			}
			set	
			{
				systemDiskSize = value;
				DictionaryUtil.Add(QueryParameters, "SystemDiskSize", value.ToString());
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public string ComputeSpotPriceLimit
		{
			get
			{
				return computeSpotPriceLimit;
			}
			set	
			{
				computeSpotPriceLimit = value;
				DictionaryUtil.Add(QueryParameters, "ComputeSpotPriceLimit", value);
			}
		}

        public override AddNodesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AddNodesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}