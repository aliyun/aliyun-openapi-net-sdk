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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class QueryTenantBizConfigResponseUnmarshaller
    {
        public static QueryTenantBizConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTenantBizConfigResponse queryTenantBizConfigResponse = new QueryTenantBizConfigResponse();

			queryTenantBizConfigResponse.HttpResponse = _ctx.HttpResponse;
			queryTenantBizConfigResponse.Code = _ctx.StringValue("QueryTenantBizConfig.Code");
			queryTenantBizConfigResponse.Success = _ctx.BooleanValue("QueryTenantBizConfig.Success");
			queryTenantBizConfigResponse.Message = _ctx.StringValue("QueryTenantBizConfig.Message");
			queryTenantBizConfigResponse.RequestId = _ctx.StringValue("QueryTenantBizConfig.RequestId");

			List<QueryTenantBizConfigResponse.QueryTenantBizConfig_Config> queryTenantBizConfigResponse_model = new List<QueryTenantBizConfigResponse.QueryTenantBizConfig_Config>();
			for (int i = 0; i < _ctx.Length("QueryTenantBizConfig.Model.Length"); i++) {
				QueryTenantBizConfigResponse.QueryTenantBizConfig_Config config = new QueryTenantBizConfigResponse.QueryTenantBizConfig_Config();
				config.BizId = _ctx.StringValue("QueryTenantBizConfig.Model["+ i +"].BizId");
				config.Key = _ctx.StringValue("QueryTenantBizConfig.Model["+ i +"].Key");
				config._Value = _ctx.StringValue("QueryTenantBizConfig.Model["+ i +"].Value");
				config.ConfigValueType = _ctx.StringValue("QueryTenantBizConfig.Model["+ i +"].ConfigValueType");
				config.ConfigDescription = _ctx.StringValue("QueryTenantBizConfig.Model["+ i +"].ConfigDescription");

				queryTenantBizConfigResponse_model.Add(config);
			}
			queryTenantBizConfigResponse.Model = queryTenantBizConfigResponse_model;
        
			return queryTenantBizConfigResponse;
        }
    }
}
