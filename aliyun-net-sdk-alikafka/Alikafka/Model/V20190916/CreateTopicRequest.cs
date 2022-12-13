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
    public class CreateTopicRequest : RpcAcsRequest<CreateTopicResponse>
    {
        public CreateTopicRequest()
            : base("alikafka", "2019-09-16", "CreateTopic", "alikafka", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.alikafka.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.alikafka.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string remark;

		private long? replicationFactor;

		private long? minInsyncReplicas;

		private string instanceId;

		private string topic;

		private bool? compactTopic;

		private List<string> tags = new List<string>(){ };

		private string partitionNum;

		private string config;

		private bool? localTopic;

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
			}
		}

		public long? ReplicationFactor
		{
			get
			{
				return replicationFactor;
			}
			set	
			{
				replicationFactor = value;
				DictionaryUtil.Add(QueryParameters, "ReplicationFactor", value.ToString());
			}
		}

		public long? MinInsyncReplicas
		{
			get
			{
				return minInsyncReplicas;
			}
			set	
			{
				minInsyncReplicas = value;
				DictionaryUtil.Add(QueryParameters, "MinInsyncReplicas", value.ToString());
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

		public string Topic
		{
			get
			{
				return topic;
			}
			set	
			{
				topic = value;
				DictionaryUtil.Add(QueryParameters, "Topic", value);
			}
		}

		public bool? CompactTopic
		{
			get
			{
				return compactTopic;
			}
			set	
			{
				compactTopic = value;
				DictionaryUtil.Add(QueryParameters, "CompactTopic", value.ToString());
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

		public string PartitionNum
		{
			get
			{
				return partitionNum;
			}
			set	
			{
				partitionNum = value;
				DictionaryUtil.Add(QueryParameters, "PartitionNum", value);
			}
		}

		public string Config
		{
			get
			{
				return config;
			}
			set	
			{
				config = value;
				DictionaryUtil.Add(QueryParameters, "Config", value);
			}
		}

		public bool? LocalTopic
		{
			get
			{
				return localTopic;
			}
			set	
			{
				localTopic = value;
				DictionaryUtil.Add(QueryParameters, "LocalTopic", value.ToString());
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

        public override CreateTopicResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTopicResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
