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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.dms_enterprise.Model.V20181101;

namespace Aliyun.Acs.dms_enterprise.Transform.V20181101
{
    public class ListLogicTableRouteConfigResponseUnmarshaller
    {
        public static ListLogicTableRouteConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLogicTableRouteConfigResponse listLogicTableRouteConfigResponse = new ListLogicTableRouteConfigResponse();

			listLogicTableRouteConfigResponse.HttpResponse = _ctx.HttpResponse;
			listLogicTableRouteConfigResponse.RequestId = _ctx.StringValue("ListLogicTableRouteConfig.RequestId");
			listLogicTableRouteConfigResponse.ErrorCode = _ctx.StringValue("ListLogicTableRouteConfig.ErrorCode");
			listLogicTableRouteConfigResponse.ErrorMessage = _ctx.StringValue("ListLogicTableRouteConfig.ErrorMessage");
			listLogicTableRouteConfigResponse.Success = _ctx.BooleanValue("ListLogicTableRouteConfig.Success");

			List<ListLogicTableRouteConfigResponse.ListLogicTableRouteConfig_LogicTableRouteConfig> listLogicTableRouteConfigResponse_logicTableRouteConfigList = new List<ListLogicTableRouteConfigResponse.ListLogicTableRouteConfig_LogicTableRouteConfig>();
			for (int i = 0; i < _ctx.Length("ListLogicTableRouteConfig.LogicTableRouteConfigList.Length"); i++) {
				ListLogicTableRouteConfigResponse.ListLogicTableRouteConfig_LogicTableRouteConfig logicTableRouteConfig = new ListLogicTableRouteConfigResponse.ListLogicTableRouteConfig_LogicTableRouteConfig();
				logicTableRouteConfig.RouteKey = _ctx.StringValue("ListLogicTableRouteConfig.LogicTableRouteConfigList["+ i +"].RouteKey");
				logicTableRouteConfig.RouteExpr = _ctx.StringValue("ListLogicTableRouteConfig.LogicTableRouteConfigList["+ i +"].RouteExpr");
				logicTableRouteConfig.TableId = _ctx.LongValue("ListLogicTableRouteConfig.LogicTableRouteConfigList["+ i +"].TableId");

				listLogicTableRouteConfigResponse_logicTableRouteConfigList.Add(logicTableRouteConfig);
			}
			listLogicTableRouteConfigResponse.LogicTableRouteConfigList = listLogicTableRouteConfigResponse_logicTableRouteConfigList;
        
			return listLogicTableRouteConfigResponse;
        }
    }
}
