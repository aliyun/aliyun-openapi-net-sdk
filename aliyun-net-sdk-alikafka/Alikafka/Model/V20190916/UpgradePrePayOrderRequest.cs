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
using Aliyun.Acs.alikafka.Transform;
using Aliyun.Acs.alikafka.Transform.V20190916;

namespace Aliyun.Acs.alikafka.Model.V20190916
{
    public class UpgradePrePayOrderRequest : RpcAcsRequest<UpgradePrePayOrderResponse>
    {
        public UpgradePrePayOrderRequest()
            : base("alikafka", "2019-09-16", "UpgradePrePayOrder", "alikafka", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.alikafka.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.alikafka.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? diskSize;

		private int? ioMax;

		private bool? eipModel;

		private string ioMaxSpec;

		private int? topicQuota;

		private int? eipMax;

		private string specType;

		private string instanceId;

		private int? partitionNum;

		public int? DiskSize
		{
			get
			{
				return diskSize;
			}
			set	
			{
				diskSize = value;
				DictionaryUtil.Add(QueryParameters, "DiskSize", value.ToString());
			}
		}

		public int? IoMax
		{
			get
			{
				return ioMax;
			}
			set	
			{
				ioMax = value;
				DictionaryUtil.Add(QueryParameters, "IoMax", value.ToString());
			}
		}

		public bool? EipModel
		{
			get
			{
				return eipModel;
			}
			set	
			{
				eipModel = value;
				DictionaryUtil.Add(QueryParameters, "EipModel", value.ToString());
			}
		}

		public string IoMaxSpec
		{
			get
			{
				return ioMaxSpec;
			}
			set	
			{
				ioMaxSpec = value;
				DictionaryUtil.Add(QueryParameters, "IoMaxSpec", value);
			}
		}

		public int? TopicQuota
		{
			get
			{
				return topicQuota;
			}
			set	
			{
				topicQuota = value;
				DictionaryUtil.Add(QueryParameters, "TopicQuota", value.ToString());
			}
		}

		public int? EipMax
		{
			get
			{
				return eipMax;
			}
			set	
			{
				eipMax = value;
				DictionaryUtil.Add(QueryParameters, "EipMax", value.ToString());
			}
		}

		public string SpecType
		{
			get
			{
				return specType;
			}
			set	
			{
				specType = value;
				DictionaryUtil.Add(QueryParameters, "SpecType", value);
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

		public int? PartitionNum
		{
			get
			{
				return partitionNum;
			}
			set	
			{
				partitionNum = value;
				DictionaryUtil.Add(QueryParameters, "PartitionNum", value.ToString());
			}
		}

        public override UpgradePrePayOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpgradePrePayOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
