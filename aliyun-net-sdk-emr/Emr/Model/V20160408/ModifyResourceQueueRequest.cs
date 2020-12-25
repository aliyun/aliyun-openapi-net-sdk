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
    public class ModifyResourceQueueRequest : RpcAcsRequest<ModifyResourceQueueResponse>
    {
        public ModifyResourceQueueRequest()
            : base("Emr", "2016-04-08", "ModifyResourceQueue", "emr", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Emr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string qualifiedName;

		private long? resourcePoolId;

		private string clusterId;

		private bool? leaf;

		private long? parentQueueId;

		private string name;

		private string id;

		private List<Config> configs = new List<Config>(){ };

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

		public string QualifiedName
		{
			get
			{
				return qualifiedName;
			}
			set	
			{
				qualifiedName = value;
				DictionaryUtil.Add(QueryParameters, "QualifiedName", value);
			}
		}

		public long? ResourcePoolId
		{
			get
			{
				return resourcePoolId;
			}
			set	
			{
				resourcePoolId = value;
				DictionaryUtil.Add(QueryParameters, "ResourcePoolId", value.ToString());
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

		public bool? Leaf
		{
			get
			{
				return leaf;
			}
			set	
			{
				leaf = value;
				DictionaryUtil.Add(QueryParameters, "Leaf", value.ToString());
			}
		}

		public long? ParentQueueId
		{
			get
			{
				return parentQueueId;
			}
			set	
			{
				parentQueueId = value;
				DictionaryUtil.Add(QueryParameters, "ParentQueueId", value.ToString());
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string Id
		{
			get
			{
				return id;
			}
			set	
			{
				id = value;
				DictionaryUtil.Add(QueryParameters, "Id", value);
			}
		}

		public List<Config> Configs
		{
			get
			{
				return configs;
			}

			set
			{
				configs = value;
				for (int i = 0; i < configs.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Config." + (i + 1) + ".ConfigKey", configs[i].ConfigKey);
					DictionaryUtil.Add(QueryParameters,"Config." + (i + 1) + ".Note", configs[i].Note);
					DictionaryUtil.Add(QueryParameters,"Config." + (i + 1) + ".ConfigValue", configs[i].ConfigValue);
					DictionaryUtil.Add(QueryParameters,"Config." + (i + 1) + ".Id", configs[i].Id);
					DictionaryUtil.Add(QueryParameters,"Config." + (i + 1) + ".Category", configs[i].Category);
				}
			}
		}

		public class Config
		{

			private string configKey;

			private string note;

			private string configValue;

			private long? id;

			private string category;

			public string ConfigKey
			{
				get
				{
					return configKey;
				}
				set	
				{
					configKey = value;
				}
			}

			public string Note
			{
				get
				{
					return note;
				}
				set	
				{
					note = value;
				}
			}

			public string ConfigValue
			{
				get
				{
					return configValue;
				}
				set	
				{
					configValue = value;
				}
			}

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}
		}

        public override ModifyResourceQueueResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyResourceQueueResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
