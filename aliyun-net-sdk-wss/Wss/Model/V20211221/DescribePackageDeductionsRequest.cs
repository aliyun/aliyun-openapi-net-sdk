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
using Aliyun.Acs.wss;
using Aliyun.Acs.wss.Transform;
using Aliyun.Acs.wss.Transform.V20211221;

namespace Aliyun.Acs.wss.Model.V20211221
{
    public class DescribePackageDeductionsRequest : RpcAcsRequest<DescribePackageDeductionsResponse>
    {
        public DescribePackageDeductionsRequest()
            : base("wss", "2021-12-21", "DescribePackageDeductions")
        {
			Method = MethodType.POST;
        }

		private int? pageNum;

		private string resourceType;

		private List<string> packageIdss = new List<string>(){ };

		private List<string> instanceIdss = new List<string>(){ };

		private int? pageSize;

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
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

		public List<string> PackageIdss
		{
			get
			{
				return packageIdss;
			}

			set
			{
				packageIdss = value;
			}
		}

		public List<string> InstanceIdss
		{
			get
			{
				return instanceIdss;
			}

			set
			{
				instanceIdss = value;
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribePackageDeductionsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribePackageDeductionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
