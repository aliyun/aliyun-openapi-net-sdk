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
using Aliyun.Acs.BssOpenApi;
using Aliyun.Acs.BssOpenApi.Transform;
using Aliyun.Acs.BssOpenApi.Transform.V20171214;

namespace Aliyun.Acs.BssOpenApi.Model.V20171214
{
    public class ModifyAccountRelationRequest : RpcAcsRequest<ModifyAccountRelationResponse>
    {
        public ModifyAccountRelationRequest()
            : base("BssOpenApi", "2017-12-14", "ModifyAccountRelation")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.BssOpenApi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string childNick;

		private string relationOperation;

		private string relationType;

		private long? parentUserId;

		private long? childUserId;

		private string requestId;

		private List<string> permissionCodess = new List<string>(){ };

		private List<string> roleCodess = new List<string>(){ };

		public string ChildNick
		{
			get
			{
				return childNick;
			}
			set	
			{
				childNick = value;
				DictionaryUtil.Add(QueryParameters, "ChildNick", value);
			}
		}

		public string RelationOperation
		{
			get
			{
				return relationOperation;
			}
			set	
			{
				relationOperation = value;
				DictionaryUtil.Add(QueryParameters, "RelationOperation", value);
			}
		}

		public string RelationType
		{
			get
			{
				return relationType;
			}
			set	
			{
				relationType = value;
				DictionaryUtil.Add(QueryParameters, "RelationType", value);
			}
		}

		public long? ParentUserId
		{
			get
			{
				return parentUserId;
			}
			set	
			{
				parentUserId = value;
				DictionaryUtil.Add(QueryParameters, "ParentUserId", value.ToString());
			}
		}

		public long? ChildUserId
		{
			get
			{
				return childUserId;
			}
			set	
			{
				childUserId = value;
				DictionaryUtil.Add(QueryParameters, "ChildUserId", value.ToString());
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
				DictionaryUtil.Add(QueryParameters, "RequestId", value);
			}
		}

		public List<string> PermissionCodess
		{
			get
			{
				return permissionCodess;
			}

			set
			{
				permissionCodess = value;
				for (int i = 0; i < permissionCodess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"PermissionCodes." + (i + 1) , permissionCodess[i]);
				}
			}
		}

		public List<string> RoleCodess
		{
			get
			{
				return roleCodess;
			}

			set
			{
				roleCodess = value;
				for (int i = 0; i < roleCodess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RoleCodes." + (i + 1) , roleCodess[i]);
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyAccountRelationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyAccountRelationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
