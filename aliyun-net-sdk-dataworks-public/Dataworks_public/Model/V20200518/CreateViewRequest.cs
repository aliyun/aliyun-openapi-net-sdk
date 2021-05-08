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
    public class CreateViewRequest : RpcAcsRequest<CreateViewResponse>
    {
        public CreateViewRequest()
            : base("dataworks-public", "2020-05-18", "CreateView")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string viewName;

		private string clientToken;

		private string selectSQL;

		private string selectWhere;

		private string selectTableName;

		private string comment;

		private string selectColumn;

		private string appGuid;

		private List<ViewColumn> viewColumns = new List<ViewColumn>(){ };

		public string ViewName
		{
			get
			{
				return viewName;
			}
			set	
			{
				viewName = value;
				DictionaryUtil.Add(BodyParameters, "ViewName", value);
			}
		}

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(BodyParameters, "ClientToken", value);
			}
		}

		public string SelectSQL
		{
			get
			{
				return selectSQL;
			}
			set	
			{
				selectSQL = value;
				DictionaryUtil.Add(BodyParameters, "SelectSQL", value);
			}
		}

		public string SelectWhere
		{
			get
			{
				return selectWhere;
			}
			set	
			{
				selectWhere = value;
				DictionaryUtil.Add(BodyParameters, "SelectWhere", value);
			}
		}

		public string SelectTableName
		{
			get
			{
				return selectTableName;
			}
			set	
			{
				selectTableName = value;
				DictionaryUtil.Add(BodyParameters, "SelectTableName", value);
			}
		}

		public string Comment
		{
			get
			{
				return comment;
			}
			set	
			{
				comment = value;
				DictionaryUtil.Add(BodyParameters, "Comment", value);
			}
		}

		public string SelectColumn
		{
			get
			{
				return selectColumn;
			}
			set	
			{
				selectColumn = value;
				DictionaryUtil.Add(BodyParameters, "SelectColumn", value);
			}
		}

		public string AppGuid
		{
			get
			{
				return appGuid;
			}
			set	
			{
				appGuid = value;
				DictionaryUtil.Add(BodyParameters, "AppGuid", value);
			}
		}

		public List<ViewColumn> ViewColumns
		{
			get
			{
				return viewColumns;
			}

			set
			{
				viewColumns = value;
				for (int i = 0; i < viewColumns.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"ViewColumn." + (i + 1) + ".Comment", viewColumns[i].Comment);
					DictionaryUtil.Add(BodyParameters,"ViewColumn." + (i + 1) + ".ColumnName", viewColumns[i].ColumnName);
				}
			}
		}

		public class ViewColumn
		{

			private string comment;

			private string columnName;

			public string Comment
			{
				get
				{
					return comment;
				}
				set	
				{
					comment = value;
				}
			}

			public string ColumnName
			{
				get
				{
					return columnName;
				}
				set	
				{
					columnName = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateViewResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateViewResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
