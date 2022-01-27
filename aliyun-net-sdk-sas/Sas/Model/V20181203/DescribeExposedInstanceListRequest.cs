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
using Aliyun.Acs.Sas.Transform;
using Aliyun.Acs.Sas.Transform.V20181203;

namespace Aliyun.Acs.Sas.Model.V20181203
{
    public class DescribeExposedInstanceListRequest : RpcAcsRequest<DescribeExposedInstanceListResponse>
    {
        public DescribeExposedInstanceListRequest()
            : base("Sas", "2018-12-03", "DescribeExposedInstanceList", "sas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string exposurePort;

		private int? pageSize;

		private bool? vulStatus;

		private string exposureIp;

		private long? groupId;

		private int? currentPage;

		private string exposureComponent;

		private string instanceId;

		private string instanceName;

		private bool? healthStatus;

		public string ExposurePort
		{
			get
			{
				return exposurePort;
			}
			set	
			{
				exposurePort = value;
				DictionaryUtil.Add(QueryParameters, "ExposurePort", value);
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

		public bool? VulStatus
		{
			get
			{
				return vulStatus;
			}
			set	
			{
				vulStatus = value;
				DictionaryUtil.Add(QueryParameters, "VulStatus", value.ToString());
			}
		}

		public string ExposureIp
		{
			get
			{
				return exposureIp;
			}
			set	
			{
				exposureIp = value;
				DictionaryUtil.Add(QueryParameters, "ExposureIp", value);
			}
		}

		public long? GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value.ToString());
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
			}
		}

		public string ExposureComponent
		{
			get
			{
				return exposureComponent;
			}
			set	
			{
				exposureComponent = value;
				DictionaryUtil.Add(QueryParameters, "ExposureComponent", value);
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

		public string InstanceName
		{
			get
			{
				return instanceName;
			}
			set	
			{
				instanceName = value;
				DictionaryUtil.Add(QueryParameters, "InstanceName", value);
			}
		}

		public bool? HealthStatus
		{
			get
			{
				return healthStatus;
			}
			set	
			{
				healthStatus = value;
				DictionaryUtil.Add(QueryParameters, "HealthStatus", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeExposedInstanceListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeExposedInstanceListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
