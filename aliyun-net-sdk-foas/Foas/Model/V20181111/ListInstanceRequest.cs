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
using Aliyun.Acs.foas.Transform;
using Aliyun.Acs.foas.Transform.V20181111;

namespace Aliyun.Acs.foas.Model.V20181111
{
    public class ListInstanceRequest : RoaAcsRequest<ListInstanceResponse>
    {
        public ListInstanceRequest()
            : base("foas", "2018-11-11", "ListInstance", "foas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/api/v2/projects/[projectName]/instances";
			Method = MethodType.GET;
        }

		private string projectName;

		private long? endBeginTs;

		private string expectState;

		private string jobType;

		private string apiType;

		private string actualState;

		private long? endEndTs;

		private long? startEndTs;

		private int? pageSize;

		private long? startBeginTs;

		private int? pageIndex;

		private bool? isArchived;

		private string jobName;

		public string ProjectName
		{
			get
			{
				return projectName;
			}
			set	
			{
				projectName = value;
				DictionaryUtil.Add(PathParameters, "projectName", value);
			}
		}

		public long? EndBeginTs
		{
			get
			{
				return endBeginTs;
			}
			set	
			{
				endBeginTs = value;
				DictionaryUtil.Add(QueryParameters, "endBeginTs", value.ToString());
			}
		}

		public string ExpectState
		{
			get
			{
				return expectState;
			}
			set	
			{
				expectState = value;
				DictionaryUtil.Add(QueryParameters, "expectState", value);
			}
		}

		public string JobType
		{
			get
			{
				return jobType;
			}
			set	
			{
				jobType = value;
				DictionaryUtil.Add(QueryParameters, "jobType", value);
			}
		}

		public string ApiType
		{
			get
			{
				return apiType;
			}
			set	
			{
				apiType = value;
				DictionaryUtil.Add(QueryParameters, "apiType", value);
			}
		}

		public string ActualState
		{
			get
			{
				return actualState;
			}
			set	
			{
				actualState = value;
				DictionaryUtil.Add(QueryParameters, "actualState", value);
			}
		}

		public long? EndEndTs
		{
			get
			{
				return endEndTs;
			}
			set	
			{
				endEndTs = value;
				DictionaryUtil.Add(QueryParameters, "endEndTs", value.ToString());
			}
		}

		public long? StartEndTs
		{
			get
			{
				return startEndTs;
			}
			set	
			{
				startEndTs = value;
				DictionaryUtil.Add(QueryParameters, "startEndTs", value.ToString());
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "pageSize", value.ToString());
			}
		}

		public long? StartBeginTs
		{
			get
			{
				return startBeginTs;
			}
			set	
			{
				startBeginTs = value;
				DictionaryUtil.Add(QueryParameters, "startBeginTs", value.ToString());
			}
		}

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
				DictionaryUtil.Add(QueryParameters, "pageIndex", value.ToString());
			}
		}

		public bool? IsArchived
		{
			get
			{
				return isArchived;
			}
			set	
			{
				isArchived = value;
				DictionaryUtil.Add(QueryParameters, "isArchived", value.ToString());
			}
		}

		public string JobName
		{
			get
			{
				return jobName;
			}
			set	
			{
				jobName = value;
				DictionaryUtil.Add(QueryParameters, "jobName", value);
			}
		}

        public override ListInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
