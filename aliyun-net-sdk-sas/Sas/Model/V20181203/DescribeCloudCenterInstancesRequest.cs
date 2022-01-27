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
    public class DescribeCloudCenterInstancesRequest : RpcAcsRequest<DescribeCloudCenterInstancesResponse>
    {
        public DescribeCloudCenterInstancesRequest()
            : base("Sas", "2018-12-03", "DescribeCloudCenterInstances", "sas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Sas.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string criteria;

		private int? importance;

		private bool? noPage;

		private int? pageSize;

		private string logicalExp;

		private int? currentPage;

		private string machineTypes;

		public string Criteria
		{
			get
			{
				return criteria;
			}
			set	
			{
				criteria = value;
				DictionaryUtil.Add(QueryParameters, "Criteria", value);
			}
		}

		public int? Importance
		{
			get
			{
				return importance;
			}
			set	
			{
				importance = value;
				DictionaryUtil.Add(QueryParameters, "Importance", value.ToString());
			}
		}

		public bool? NoPage
		{
			get
			{
				return noPage;
			}
			set	
			{
				noPage = value;
				DictionaryUtil.Add(QueryParameters, "NoPage", value.ToString());
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

		public string LogicalExp
		{
			get
			{
				return logicalExp;
			}
			set	
			{
				logicalExp = value;
				DictionaryUtil.Add(QueryParameters, "LogicalExp", value);
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

		public string MachineTypes
		{
			get
			{
				return machineTypes;
			}
			set	
			{
				machineTypes = value;
				DictionaryUtil.Add(QueryParameters, "MachineTypes", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeCloudCenterInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeCloudCenterInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
