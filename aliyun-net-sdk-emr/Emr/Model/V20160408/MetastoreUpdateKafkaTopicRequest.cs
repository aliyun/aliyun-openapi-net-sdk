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
    public class MetastoreUpdateKafkaTopicRequest : RpcAcsRequest<MetastoreUpdateKafkaTopicResponse>
    {
        public MetastoreUpdateKafkaTopicRequest()
            : base("Emr", "2016-04-08", "MetastoreUpdateKafkaTopic", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string topicId;

		private string regionId;

		private List<AdvancedConfig> advancedConfigs;

		private int? numPartitions;

		private string accessKeyId;

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

		public string TopicId
		{
			get
			{
				return topicId;
			}
			set	
			{
				topicId = value;
				DictionaryUtil.Add(QueryParameters, "TopicId", value);
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public List<AdvancedConfig> AdvancedConfigs
		{
			get
			{
				return advancedConfigs;
			}

			set
			{
				advancedConfigs = value;
				for (int i = 0; i < advancedConfigs.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"AdvancedConfig." + (i + 1) + ".Value", advancedConfigs[i].Value);
					DictionaryUtil.Add(QueryParameters,"AdvancedConfig." + (i + 1) + ".Key", advancedConfigs[i].Key);
				}
			}
		}

		public int? NumPartitions
		{
			get
			{
				return numPartitions;
			}
			set	
			{
				numPartitions = value;
				DictionaryUtil.Add(QueryParameters, "NumPartitions", value.ToString());
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

		public class AdvancedConfig
		{

			private string value_;

			private string key;

			public string Value
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

        public override MetastoreUpdateKafkaTopicResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MetastoreUpdateKafkaTopicResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
