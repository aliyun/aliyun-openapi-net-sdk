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
    public class MetastoreUpdateKafkaTopicBatchRequest : RpcAcsRequest<MetastoreUpdateKafkaTopicBatchResponse>
    {
        public MetastoreUpdateKafkaTopicBatchRequest()
            : base("Emr", "2016-04-08", "MetastoreUpdateKafkaTopicBatch", "emr", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private List<TopicParam> topicParams;

		private string regionId;

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

		public List<TopicParam> TopicParams
		{
			get
			{
				return topicParams;
			}

			set
			{
				topicParams = value;
				for (int i = 0; i < topicParams.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TopicParam." + (i + 1) + ".TopicId", topicParams[i].TopicId);
					DictionaryUtil.Add(QueryParameters,"TopicParam." + (i + 1) + ".NumPartitions", topicParams[i].NumPartitions);
				}
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

		public class TopicParam
		{

			private string topicId;

			private int? numPartitions;

			public string TopicId
			{
				get
				{
					return topicId;
				}
				set	
				{
					topicId = value;
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
				}
			}
		}

        public override MetastoreUpdateKafkaTopicBatchResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MetastoreUpdateKafkaTopicBatchResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
