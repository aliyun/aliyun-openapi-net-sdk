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
using Aliyun.Acs.antiddos_public.Transform;
using Aliyun.Acs.antiddos_public.Transform.V20170518;

namespace Aliyun.Acs.antiddos_public.Model.V20170518
{
    public class DescribeInstanceRequest : RpcAcsRequest<DescribeInstanceResponse>
    {
        public DescribeInstanceRequest()
            : base("antiddos-public", "2017-05-18", "DescribeInstance", "ddosbasic", "openAPI")
        {
			Method = MethodType.POST;
        }

		private int? pageSize;

		private string ddosRegionId;

		private string instanceType;

		private string ddosStatus;

		private int? currentPage;

		private string instanceName;

		private string instanceId;

		private string instanceIp;

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

		public string DdosRegionId
		{
			get
			{
				return ddosRegionId;
			}
			set	
			{
				ddosRegionId = value;
				DictionaryUtil.Add(QueryParameters, "DdosRegionId", value);
			}
		}

		public string InstanceType
		{
			get
			{
				return instanceType;
			}
			set	
			{
				instanceType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceType", value);
			}
		}

		public string DdosStatus
		{
			get
			{
				return ddosStatus;
			}
			set	
			{
				ddosStatus = value;
				DictionaryUtil.Add(QueryParameters, "DdosStatus", value);
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

		public string InstanceIp
		{
			get
			{
				return instanceIp;
			}
			set	
			{
				instanceIp = value;
				DictionaryUtil.Add(QueryParameters, "InstanceIp", value);
			}
		}

        public override DescribeInstanceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeInstanceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
