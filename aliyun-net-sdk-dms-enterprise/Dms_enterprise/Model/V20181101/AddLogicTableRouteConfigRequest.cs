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
    public class AddLogicTableRouteConfigRequest : RpcAcsRequest<AddLogicTableRouteConfigResponse>
    {
        public AddLogicTableRouteConfigRequest()
            : base("dms-enterprise", "2018-11-01", "AddLogicTableRouteConfig", "dms-enterprise", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dms_enterprise.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string routeKey;

		private long? tid;

		private string routeExpr;

		private long? tableId;

		public string RouteKey
		{
			get
			{
				return routeKey;
			}
			set	
			{
				routeKey = value;
				DictionaryUtil.Add(QueryParameters, "RouteKey", value);
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

		public string RouteExpr
		{
			get
			{
				return routeExpr;
			}
			set	
			{
				routeExpr = value;
				DictionaryUtil.Add(QueryParameters, "RouteExpr", value);
			}
		}

		public long? TableId
		{
			get
			{
				return tableId;
			}
			set	
			{
				tableId = value;
				DictionaryUtil.Add(QueryParameters, "TableId", value.ToString());
			}
		}

        public override AddLogicTableRouteConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddLogicTableRouteConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
