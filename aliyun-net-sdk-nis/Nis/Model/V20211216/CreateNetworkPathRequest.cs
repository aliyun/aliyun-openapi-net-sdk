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
using Aliyun.Acs.nis.Transform;
using Aliyun.Acs.nis.Transform.V20211216;

namespace Aliyun.Acs.nis.Model.V20211216
{
    public class CreateNetworkPathRequest : RpcAcsRequest<CreateNetworkPathResponse>
    {
        public CreateNetworkPathRequest()
            : base("nis", "2021-12-16", "CreateNetworkPath", "networkana", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string targetId;

		private string targetType;

		private string targetIpAddress;

		private string networkPathName;

		private int? sourcePort;

		private string resourceGroupId;

		private string protocol;

		private string sourceType;

		private List<string> tags = new List<string>(){ };

		private int? targetPort;

		private string sourceId;

		private string sourceIpAddress;

		private string networkPathDescription;

		public string TargetId
		{
			get
			{
				return targetId;
			}
			set	
			{
				targetId = value;
				DictionaryUtil.Add(QueryParameters, "TargetId", value);
			}
		}

		public string TargetType
		{
			get
			{
				return targetType;
			}
			set	
			{
				targetType = value;
				DictionaryUtil.Add(QueryParameters, "TargetType", value);
			}
		}

		public string TargetIpAddress
		{
			get
			{
				return targetIpAddress;
			}
			set	
			{
				targetIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "TargetIpAddress", value);
			}
		}

		public string NetworkPathName
		{
			get
			{
				return networkPathName;
			}
			set	
			{
				networkPathName = value;
				DictionaryUtil.Add(QueryParameters, "NetworkPathName", value);
			}
		}

		public int? SourcePort
		{
			get
			{
				return sourcePort;
			}
			set	
			{
				sourcePort = value;
				DictionaryUtil.Add(QueryParameters, "SourcePort", value.ToString());
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

		public string Protocol
		{
			get
			{
				return protocol;
			}
			set	
			{
				protocol = value;
				DictionaryUtil.Add(QueryParameters, "Protocol", value);
			}
		}

		public string SourceType
		{
			get
			{
				return sourceType;
			}
			set	
			{
				sourceType = value;
				DictionaryUtil.Add(QueryParameters, "SourceType", value);
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

		public int? TargetPort
		{
			get
			{
				return targetPort;
			}
			set	
			{
				targetPort = value;
				DictionaryUtil.Add(QueryParameters, "TargetPort", value.ToString());
			}
		}

		public string SourceId
		{
			get
			{
				return sourceId;
			}
			set	
			{
				sourceId = value;
				DictionaryUtil.Add(QueryParameters, "SourceId", value);
			}
		}

		public string SourceIpAddress
		{
			get
			{
				return sourceIpAddress;
			}
			set	
			{
				sourceIpAddress = value;
				DictionaryUtil.Add(QueryParameters, "SourceIpAddress", value);
			}
		}

		public string NetworkPathDescription
		{
			get
			{
				return networkPathDescription;
			}
			set	
			{
				networkPathDescription = value;
				DictionaryUtil.Add(QueryParameters, "NetworkPathDescription", value);
			}
		}

		public class Tag
		{

			private string key;

			private string value_;

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
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateNetworkPathResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateNetworkPathResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
