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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class ListCityMapPersonFlowResponseUnmarshaller
    {
        public static ListCityMapPersonFlowResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCityMapPersonFlowResponse listCityMapPersonFlowResponse = new ListCityMapPersonFlowResponse();

			listCityMapPersonFlowResponse.HttpResponse = _ctx.HttpResponse;
			listCityMapPersonFlowResponse.Code = _ctx.StringValue("ListCityMapPersonFlow.Code");
			listCityMapPersonFlowResponse.Message = _ctx.StringValue("ListCityMapPersonFlow.Message");
			listCityMapPersonFlowResponse.RequestId = _ctx.StringValue("ListCityMapPersonFlow.RequestId");
			listCityMapPersonFlowResponse.PageNumber = _ctx.LongValue("ListCityMapPersonFlow.PageNumber");
			listCityMapPersonFlowResponse.PageSize = _ctx.LongValue("ListCityMapPersonFlow.PageSize");
			listCityMapPersonFlowResponse.TotalCount = _ctx.LongValue("ListCityMapPersonFlow.TotalCount");

			List<ListCityMapPersonFlowResponse.ListCityMapPersonFlow_Datas> listCityMapPersonFlowResponse_data = new List<ListCityMapPersonFlowResponse.ListCityMapPersonFlow_Datas>();
			for (int i = 0; i < _ctx.Length("ListCityMapPersonFlow.Data.Length"); i++) {
				ListCityMapPersonFlowResponse.ListCityMapPersonFlow_Datas datas = new ListCityMapPersonFlowResponse.ListCityMapPersonFlow_Datas();
				datas.OriginDataSourceId = _ctx.StringValue("ListCityMapPersonFlow.Data["+ i +"].OriginDataSourceId");
				datas.TargetDataSourceId = _ctx.StringValue("ListCityMapPersonFlow.Data["+ i +"].TargetDataSourceId");
				datas.FlowNumber = _ctx.StringValue("ListCityMapPersonFlow.Data["+ i +"].FlowNumber");
				datas.FlowDirection = _ctx.StringValue("ListCityMapPersonFlow.Data["+ i +"].FlowDirection");

				listCityMapPersonFlowResponse_data.Add(datas);
			}
			listCityMapPersonFlowResponse.Data = listCityMapPersonFlowResponse_data;
        
			return listCityMapPersonFlowResponse;
        }
    }
}
