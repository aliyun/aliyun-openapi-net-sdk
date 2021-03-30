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
    public class UpdateTableAddColumnRequest : RpcAcsRequest<UpdateTableAddColumnResponse>
    {
        public UpdateTableAddColumnRequest()
            : base("dataworks-public", "2020-05-18", "UpdateTableAddColumn")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string tableGuid;

		private List<Column> columns = new List<Column>(){ };

		public string TableGuid
		{
			get
			{
				return tableGuid;
			}
			set	
			{
				tableGuid = value;
				DictionaryUtil.Add(QueryParameters, "TableGuid", value);
			}
		}

		public List<Column> Columns
		{
			get
			{
				return columns;
			}

			set
			{
				columns = value;
				for (int i = 0; i < columns.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Column." + (i + 1) + ".ColumnNameCn", columns[i].ColumnNameCn);
					DictionaryUtil.Add(BodyParameters,"Column." + (i + 1) + ".Comment", columns[i].Comment);
					DictionaryUtil.Add(BodyParameters,"Column." + (i + 1) + ".ColumnName", columns[i].ColumnName);
					DictionaryUtil.Add(BodyParameters,"Column." + (i + 1) + ".ColumnType", columns[i].ColumnType);
				}
			}
		}

		public class Column
		{

			private string columnNameCn;

			private string comment;

			private string columnName;

			private string columnType;

			public string ColumnNameCn
			{
				get
				{
					return columnNameCn;
				}
				set	
				{
					columnNameCn = value;
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

			public string ColumnType
			{
				get
				{
					return columnType;
				}
				set	
				{
					columnType = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateTableAddColumnResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateTableAddColumnResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
