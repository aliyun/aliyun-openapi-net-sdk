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
    public class CreatePermissionApplyOrderRequest : RpcAcsRequest<CreatePermissionApplyOrderResponse>
    {
        public CreatePermissionApplyOrderRequest()
            : base("dataworks-public", "2020-05-18", "CreatePermissionApplyOrder")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string applyReason;

		private string maxComputeProjectName;

		private List<ApplyObject> applyObjects = new List<ApplyObject>(){ };

		private string applyUserIds;

		private long? deadline;

		private int? workspaceId;

		private int? orderType;

		private string engineType;

		public string ApplyReason
		{
			get
			{
				return applyReason;
			}
			set	
			{
				applyReason = value;
				DictionaryUtil.Add(QueryParameters, "ApplyReason", value);
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

		public List<ApplyObject> ApplyObjects
		{
			get
			{
				return applyObjects;
			}

			set
			{
				applyObjects = value;
				for (int i = 0; i < applyObjects.Count; i++)
				{
					for (int j = 0; j < applyObjects[i].ColumnMetaLists.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"ApplyObject." + (i + 1) + ".ColumnMetaList." +(j + 1), applyObjects[i].ColumnMetaLists[j]);
					}
					DictionaryUtil.Add(QueryParameters,"ApplyObject." + (i + 1) + ".Name", applyObjects[i].Name);
					DictionaryUtil.Add(QueryParameters,"ApplyObject." + (i + 1) + ".Actions", applyObjects[i].Actions);
				}
			}
		}

		public string ApplyUserIds
		{
			get
			{
				return applyUserIds;
			}
			set	
			{
				applyUserIds = value;
				DictionaryUtil.Add(QueryParameters, "ApplyUserIds", value);
			}
		}

		public long? Deadline
		{
			get
			{
				return deadline;
			}
			set	
			{
				deadline = value;
				DictionaryUtil.Add(QueryParameters, "Deadline", value.ToString());
			}
		}

		public int? WorkspaceId
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

		public int? OrderType
		{
			get
			{
				return orderType;
			}
			set	
			{
				orderType = value;
				DictionaryUtil.Add(QueryParameters, "OrderType", value.ToString());
			}
		}

		public string EngineType
		{
			get
			{
				return engineType;
			}
			set	
			{
				engineType = value;
				DictionaryUtil.Add(QueryParameters, "EngineType", value);
			}
		}

		public class ApplyObject
		{

			private List<ColumnMetaList> columnMetaLists = new List<ColumnMetaList>(){ };

			private string name;

			private string actions;

			public List<ColumnMetaList> ColumnMetaLists
			{
				get
				{
					return columnMetaLists;
				}
				set	
				{
					columnMetaLists = value;
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

			public string Actions
			{
				get
				{
					return actions;
				}
				set	
				{
					actions = value;
				}
			}

			public class ColumnMetaList
			{

				private string name;

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
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreatePermissionApplyOrderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreatePermissionApplyOrderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
