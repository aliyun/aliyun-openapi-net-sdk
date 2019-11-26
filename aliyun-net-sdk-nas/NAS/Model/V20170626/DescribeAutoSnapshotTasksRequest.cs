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
using Aliyun.Acs.NAS.Transform;
using Aliyun.Acs.NAS.Transform.V20170626;

namespace Aliyun.Acs.NAS.Model.V20170626
{
    public class DescribeAutoSnapshotTasksRequest : RpcAcsRequest<DescribeAutoSnapshotTasksResponse>
    {
        public DescribeAutoSnapshotTasksRequest()
            : base("NAS", "2017-06-26", "DescribeAutoSnapshotTasks", "nas", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string fileSystemType;

		private int? pageNumber;

		private int? pageSize;

		private string fileSystemIds;

		private string autoSnapshotPolicyIds;

		public string FileSystemType
		{
			get
			{
				return fileSystemType;
			}
			set	
			{
				fileSystemType = value;
				DictionaryUtil.Add(QueryParameters, "FileSystemType", value);
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

		public string FileSystemIds
		{
			get
			{
				return fileSystemIds;
			}
			set	
			{
				fileSystemIds = value;
				DictionaryUtil.Add(QueryParameters, "FileSystemIds", value);
			}
		}

		public string AutoSnapshotPolicyIds
		{
			get
			{
				return autoSnapshotPolicyIds;
			}
			set	
			{
				autoSnapshotPolicyIds = value;
				DictionaryUtil.Add(QueryParameters, "AutoSnapshotPolicyIds", value);
			}
		}

        public override DescribeAutoSnapshotTasksResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeAutoSnapshotTasksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
