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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.dms_enterprise;
using Aliyun.Acs.dms_enterprise.Transform;
using Aliyun.Acs.dms_enterprise.Transform.V20181101;

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
    public class GrantUserPermissionRequest : RpcAcsRequest<GrantUserPermissionResponse>
    {
        public GrantUserPermissionRequest()
            : base("dms-enterprise", "2018-11-01", "GrantUserPermission")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string permTypes;

		private string dsType;

		private string expireDate;

		private string userId;

		private long? tid;

		private string dbId;

		private string tableId;

		private bool? logic;

		private string tableName;

		public string PermTypes
		{
			get
			{
				return permTypes;
			}
			set	
			{
				permTypes = value;
				DictionaryUtil.Add(QueryParameters, "PermTypes", value);
			}
		}

		public string DsType
		{
			get
			{
				return dsType;
			}
			set	
			{
				dsType = value;
				DictionaryUtil.Add(QueryParameters, "DsType", value);
			}
		}

		public string ExpireDate
		{
			get
			{
				return expireDate;
			}
			set	
			{
				expireDate = value;
				DictionaryUtil.Add(QueryParameters, "ExpireDate", value);
			}
		}

		public string UserId
		{
			get
			{
				return userId;
			}
			set	
			{
				userId = value;
				DictionaryUtil.Add(QueryParameters, "UserId", value);
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

		public string DbId
		{
			get
			{
				return dbId;
			}
			set	
			{
				dbId = value;
				DictionaryUtil.Add(QueryParameters, "DbId", value);
			}
		}

		public string TableId
		{
			get
			{
				return tableId;
			}
			set	
			{
				tableId = value;
				DictionaryUtil.Add(QueryParameters, "TableId", value);
			}
		}

		public bool? Logic
		{
			get
			{
				return logic;
			}
			set	
			{
				logic = value;
				DictionaryUtil.Add(QueryParameters, "Logic", value.ToString());
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

        public override GrantUserPermissionResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GrantUserPermissionResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
