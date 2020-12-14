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
    public class ListVehicleResultsResponseUnmarshaller
    {
        public static ListVehicleResultsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVehicleResultsResponse listVehicleResultsResponse = new ListVehicleResultsResponse();

			listVehicleResultsResponse.HttpResponse = _ctx.HttpResponse;
			listVehicleResultsResponse.Code = _ctx.StringValue("ListVehicleResults.Code");
			listVehicleResultsResponse.Message = _ctx.StringValue("ListVehicleResults.Message");
			listVehicleResultsResponse.RequestId = _ctx.StringValue("ListVehicleResults.RequestId");
			listVehicleResultsResponse.PageNumber = _ctx.LongValue("ListVehicleResults.PageNumber");
			listVehicleResultsResponse.PageSize = _ctx.LongValue("ListVehicleResults.PageSize");
			listVehicleResultsResponse.TotalCount = _ctx.LongValue("ListVehicleResults.TotalCount");

			List<ListVehicleResultsResponse.ListVehicleResults_Datas> listVehicleResultsResponse_data = new List<ListVehicleResultsResponse.ListVehicleResults_Datas>();
			for (int i = 0; i < _ctx.Length("ListVehicleResults.Data.Length"); i++) {
				ListVehicleResultsResponse.ListVehicleResults_Datas datas = new ListVehicleResultsResponse.ListVehicleResults_Datas();
				datas.VehicleId = _ctx.StringValue("ListVehicleResults.Data["+ i +"].VehicleId");
				datas.Gender = _ctx.StringValue("ListVehicleResults.Data["+ i +"].Gender");
				datas.VehicleClass = _ctx.StringValue("ListVehicleResults.Data["+ i +"].VehicleClass");
				datas.Profession = _ctx.StringValue("ListVehicleResults.Data["+ i +"].Profession");
				datas.LiveAddress = _ctx.StringValue("ListVehicleResults.Data["+ i +"].LiveAddress");
				datas.PlateId = _ctx.StringValue("ListVehicleResults.Data["+ i +"].PlateId");
				datas.VehicleApplication = _ctx.StringValue("ListVehicleResults.Data["+ i +"].VehicleApplication");
				datas.PersonId = _ctx.StringValue("ListVehicleResults.Data["+ i +"].PersonId");
				datas.UpdateTime = _ctx.StringValue("ListVehicleResults.Data["+ i +"].UpdateTime");

				listVehicleResultsResponse_data.Add(datas);
			}
			listVehicleResultsResponse.Data = listVehicleResultsResponse_data;
        
			return listVehicleResultsResponse;
        }
    }
}
