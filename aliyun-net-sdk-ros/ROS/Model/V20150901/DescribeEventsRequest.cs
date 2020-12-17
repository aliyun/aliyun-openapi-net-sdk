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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.ROS.Transform;
using Aliyun.Acs.ROS.Transform.V20150901;

namespace Aliyun.Acs.ROS.Model.V20150901
{
    public class DescribeEventsRequest : RoaAcsRequest<DescribeEventsResponse>
    {
        public DescribeEventsRequest()
            : base("ROS", "2015-09-01", "DescribeEvents", "ros", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ROS.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ROS.Endpoint.endpointRegionalType, null);
            }
			UriPattern = "/stacks/[StackName]/[StackId]/events";
			Method = MethodType.GET;
        }

		private string stackId;

		private int? pageSize;

		private string stackName;

		private string resourceName;

		private string resourceStatus;

		private string resourceType;

		private int? pageNumber;

		public string StackId
		{
			get
			{
				return stackId;
			}
			set	
			{
				stackId = value;
				DictionaryUtil.Add(PathParameters, "StackId", value);
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
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string StackName
		{
			get
			{
				return stackName;
			}
			set	
			{
				stackName = value;
				DictionaryUtil.Add(PathParameters, "StackName", value);
			}
		}

		public string ResourceName
		{
			get
			{
				return resourceName;
			}
			set	
			{
				resourceName = value;
				DictionaryUtil.Add(QueryParameters, "ResourceName", value);
			}
		}

		public string ResourceStatus
		{
			get
			{
				return resourceStatus;
			}
			set	
			{
				resourceStatus = value;
				DictionaryUtil.Add(QueryParameters, "ResourceStatus", value);
			}
		}

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

        public override DescribeEventsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeEventsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
