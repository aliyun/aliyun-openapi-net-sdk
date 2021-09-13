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
using Aliyun.Acs.LinkWAN.Model.V20190301;

namespace Aliyun.Acs.LinkWAN.Transform.V20190301
{
    public class ListGatewayLocalConfigsResponseUnmarshaller
    {
        public static ListGatewayLocalConfigsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListGatewayLocalConfigsResponse listGatewayLocalConfigsResponse = new ListGatewayLocalConfigsResponse();

			listGatewayLocalConfigsResponse.HttpResponse = _ctx.HttpResponse;
			listGatewayLocalConfigsResponse.RequestId = _ctx.StringValue("ListGatewayLocalConfigs.RequestId");
			listGatewayLocalConfigsResponse.Success = _ctx.BooleanValue("ListGatewayLocalConfigs.Success");
			listGatewayLocalConfigsResponse.Code = _ctx.StringValue("ListGatewayLocalConfigs.Code");
			listGatewayLocalConfigsResponse.ErrorMessage = _ctx.StringValue("ListGatewayLocalConfigs.ErrorMessage");

			List<ListGatewayLocalConfigsResponse.ListGatewayLocalConfigs_D2dConfig> listGatewayLocalConfigsResponse_data = new List<ListGatewayLocalConfigsResponse.ListGatewayLocalConfigs_D2dConfig>();
			for (int i = 0; i < _ctx.Length("ListGatewayLocalConfigs.Data.Length"); i++) {
				ListGatewayLocalConfigsResponse.ListGatewayLocalConfigs_D2dConfig d2dConfig = new ListGatewayLocalConfigsResponse.ListGatewayLocalConfigs_D2dConfig();
				d2dConfig.DevType = _ctx.StringValue("ListGatewayLocalConfigs.Data["+ i +"].DevType");
				d2dConfig.Eui = _ctx.StringValue("ListGatewayLocalConfigs.Data["+ i +"].Eui");
				d2dConfig.D2dAddr = _ctx.StringValue("ListGatewayLocalConfigs.Data["+ i +"].D2dAddr");
				d2dConfig.D2dKey = _ctx.StringValue("ListGatewayLocalConfigs.Data["+ i +"].D2dKey");
				d2dConfig.Freq = _ctx.IntegerValue("ListGatewayLocalConfigs.Data["+ i +"].Freq");
				d2dConfig.Datr = _ctx.IntegerValue("ListGatewayLocalConfigs.Data["+ i +"].Datr");
				d2dConfig.TaskId = _ctx.LongValue("ListGatewayLocalConfigs.Data["+ i +"].TaskId");
				d2dConfig.CreateMillis = _ctx.LongValue("ListGatewayLocalConfigs.Data["+ i +"].CreateMillis");
				d2dConfig.ModifiedMillis = _ctx.LongValue("ListGatewayLocalConfigs.Data["+ i +"].ModifiedMillis");

				listGatewayLocalConfigsResponse_data.Add(d2dConfig);
			}
			listGatewayLocalConfigsResponse.Data = listGatewayLocalConfigsResponse_data;
        
			return listGatewayLocalConfigsResponse;
        }
    }
}
