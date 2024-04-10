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
    public class CreateNetworkReachableAnalysisRequest : RpcAcsRequest<CreateNetworkReachableAnalysisResponse>
    {
        public CreateNetworkReachableAnalysisRequest()
            : base("nis", "2021-12-16", "CreateNetworkReachableAnalysis", "networkana", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string networkPathId;

		private List<string> tags = new List<string>(){ };

		public string NetworkPathId
		{
			get
			{
				return networkPathId;
			}
			set	
			{
				networkPathId = value;
				DictionaryUtil.Add(QueryParameters, "NetworkPathId", value);
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

        public override CreateNetworkReachableAnalysisResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateNetworkReachableAnalysisResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
