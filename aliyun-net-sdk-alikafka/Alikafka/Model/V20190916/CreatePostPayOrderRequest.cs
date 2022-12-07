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
    public class CreatePostPayOrderRequest : RpcAcsRequest<CreatePostPayOrderResponse>
    {
        public CreatePostPayOrderRequest()
            : base("alikafka", "2019-09-16", "CreatePostPayOrder", "alikafka", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.alikafka.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.alikafka.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? ioMax;

		private int? eipMax;

		private string specType;

		private string resourceGroupId;

		private List<string> tags = new List<string>(){ };

		private int? partitionNum;

		private int? diskSize;

		private string ioMaxSpec;

		private string diskType;

		private int? topicQuota;

		private int? deployType;

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

		public List<string> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				if(tags != null)
				{
					for (int depth1 = 0; depth1 < tags.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
						DictionaryUtil.Add(QueryParameters,"Tag." + (depth1 + 1), tags[depth1]);
					}
				}
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

		public string DiskType
		{
			get
			{
				return diskType;
			}
			set	
			{
				diskType = value;
				DictionaryUtil.Add(QueryParameters, "DiskType", value);
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

		public int? DeployType
		{
			get
			{
				return deployType;
			}
			set	
			{
				deployType = value;
				DictionaryUtil.Add(QueryParameters, "DeployType", value.ToString());
			}
		}

		public class Tag
		{

			private string value_;

			private string key;

			public string Value_
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

        public override CreatePostPayOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreatePostPayOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
