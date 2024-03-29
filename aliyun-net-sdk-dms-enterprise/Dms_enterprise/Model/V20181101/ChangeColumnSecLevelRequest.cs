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
using Aliyun.Acs.dms_enterprise.Transform;
using Aliyun.Acs.dms_enterprise.Transform.V20181101;

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
    public class ChangeColumnSecLevelRequest : RpcAcsRequest<ChangeColumnSecLevelResponse>
    {
        public ChangeColumnSecLevelRequest()
            : base("dms-enterprise", "2018-11-01", "ChangeColumnSecLevel", "dms-enterprise", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string schemaName;

		private bool? isLogic;

		private string newLevel;

		private string columnName;

		private long? tid;

		private long? dbId;

		private string tableName;

		public string SchemaName
		{
			get
			{
				return schemaName;
			}
			set	
			{
				schemaName = value;
				DictionaryUtil.Add(QueryParameters, "SchemaName", value);
			}
		}

		public bool? IsLogic
		{
			get
			{
				return isLogic;
			}
			set	
			{
				isLogic = value;
				DictionaryUtil.Add(QueryParameters, "IsLogic", value.ToString());
			}
		}

		public string NewLevel
		{
			get
			{
				return newLevel;
			}
			set	
			{
				newLevel = value;
				DictionaryUtil.Add(QueryParameters, "NewLevel", value);
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
				DictionaryUtil.Add(QueryParameters, "ColumnName", value);
			}
		}

		public long? Tid
		{
			get
			{
				return tid;
			}
			set	
			{
				tid = value;
				DictionaryUtil.Add(QueryParameters, "Tid", value.ToString());
			}
		}

		public long? DbId
		{
			get
			{
				return dbId;
			}
			set	
			{
				dbId = value;
				DictionaryUtil.Add(QueryParameters, "DbId", value.ToString());
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

        public override ChangeColumnSecLevelResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ChangeColumnSecLevelResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
