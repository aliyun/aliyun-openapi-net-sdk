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
using Aliyun.Acs.ComputeNestSupplier;
using Aliyun.Acs.ComputeNestSupplier.Transform;
using Aliyun.Acs.ComputeNestSupplier.Transform.V20210521;

namespace Aliyun.Acs.ComputeNestSupplier.Model.V20210521
{
    public class ListArtifactsRequest : RpcAcsRequest<ListArtifactsResponse>
    {
        public ListArtifactsRequest()
            : base("ComputeNestSupplier", "2021-05-21", "ListArtifacts")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ComputeNestSupplier.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ComputeNestSupplier.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string nextToken;

		private List<Filter> filters = new List<Filter>(){ };

		private string maxResults;

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
			}
		}

		public List<Filter> Filters
		{
			get
			{
				return filters;
			}

			set
			{
				filters = value;
				if(filters != null)
				{
					for (int depth1 = 0; depth1 < filters.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Filter." + (depth1 + 1), filters[depth1]);
					}
				}
			}
		}

		public string MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(QueryParameters, "MaxResults", value);
			}
		}

		public class Filter
		{

			private List<string> valuess = new List<string>(){ };

			private string name;

			public List<string> Valuess
			{
				get
				{
					return valuess;
				}
				set	
				{
					valuess = value;
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
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListArtifactsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListArtifactsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
