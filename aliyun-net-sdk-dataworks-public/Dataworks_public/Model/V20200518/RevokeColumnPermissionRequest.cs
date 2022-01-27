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
using Aliyun.Acs.dataworks_public;
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class RevokeColumnPermissionRequest : RpcAcsRequest<RevokeColumnPermissionResponse>
    {
        public RevokeColumnPermissionRequest()
            : base("dataworks-public", "2020-05-18", "RevokeColumnPermission")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string revokeUserName;

		private string maxComputeProjectName;

		private string columns;

		private string revokeUserId;

		private string tableName;

		private long? workspaceId;

		public string RevokeUserName
		{
			get
			{
				return revokeUserName;
			}
			set	
			{
				revokeUserName = value;
				DictionaryUtil.Add(QueryParameters, "RevokeUserName", value);
			}
		}

		public string MaxComputeProjectName
		{
			get
			{
				return maxComputeProjectName;
			}
			set	
			{
				maxComputeProjectName = value;
				DictionaryUtil.Add(QueryParameters, "MaxComputeProjectName", value);
			}
		}

		public string Columns
		{
			get
			{
				return columns;
			}
			set	
			{
				columns = value;
				DictionaryUtil.Add(QueryParameters, "Columns", value);
			}
		}

		public string RevokeUserId
		{
			get
			{
				return revokeUserId;
			}
			set	
			{
				revokeUserId = value;
				DictionaryUtil.Add(QueryParameters, "RevokeUserId", value);
			}
		}

		public string TableName
		{
			get
			{
				return tableName;
			}
			set	
			{
				tableName = value;
				DictionaryUtil.Add(QueryParameters, "TableName", value);
			}
		}

		public long? WorkspaceId
		{
			get
			{
				return workspaceId;
			}
			set	
			{
				workspaceId = value;
				DictionaryUtil.Add(QueryParameters, "WorkspaceId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override RevokeColumnPermissionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return RevokeColumnPermissionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
