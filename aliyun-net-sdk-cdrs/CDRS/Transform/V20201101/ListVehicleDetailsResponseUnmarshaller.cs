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
    public class ListVehicleDetailsResponseUnmarshaller
    {
        public static ListVehicleDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVehicleDetailsResponse listVehicleDetailsResponse = new ListVehicleDetailsResponse();

			listVehicleDetailsResponse.HttpResponse = _ctx.HttpResponse;
			listVehicleDetailsResponse.Code = _ctx.StringValue("ListVehicleDetails.Code");
			listVehicleDetailsResponse.Message = _ctx.StringValue("ListVehicleDetails.Message");
			listVehicleDetailsResponse.RequestId = _ctx.StringValue("ListVehicleDetails.RequestId");
			listVehicleDetailsResponse.PageNumber = _ctx.LongValue("ListVehicleDetails.PageNumber");
			listVehicleDetailsResponse.PageSize = _ctx.LongValue("ListVehicleDetails.PageSize");
			listVehicleDetailsResponse.TotalCount = _ctx.LongValue("ListVehicleDetails.TotalCount");

			List<ListVehicleDetailsResponse.ListVehicleDetails_Datas> listVehicleDetailsResponse_data = new List<ListVehicleDetailsResponse.ListVehicleDetails_Datas>();
			for (int i = 0; i < _ctx.Length("ListVehicleDetails.Data.Length"); i++) {
				ListVehicleDetailsResponse.ListVehicleDetails_Datas datas = new ListVehicleDetailsResponse.ListVehicleDetails_Datas();
				datas.VehicleId = _ctx.StringValue("ListVehicleDetails.Data["+ i +"].VehicleId");
				datas.VehicleColor = _ctx.StringValue("ListVehicleDetails.Data["+ i +"].VehicleColor");
				datas.TargetImageStoragePath = _ctx.StringValue("ListVehicleDetails.Data["+ i +"].TargetImageStoragePath");
				datas.Gender = _ctx.StringValue("ListVehicleDetails.Data["+ i +"].Gender");
				datas.PersonType = _ctx.StringValue("ListVehicleDetails.Data["+ i +"].PersonType");
				datas.PrefOutTime = _ctx.StringValue("ListVehicleDetails.Data["+ i +"].PrefOutTime");
				datas.PopularPoi = _ctx.StringValue("ListVehicleDetails.Data["+ i +"].PopularPoi");
				datas.PopularAddress = _ctx.StringValue("ListVehicleDetails.Data["+ i +"].PopularAddress");
				datas.SourceImageStoragePath = _ctx.StringValue("ListVehicleDetails.Data["+ i +"].SourceImageStoragePath");
				datas.VehicleClass = _ctx.StringValue("ListVehicleDetails.Data["+ i +"].VehicleClass");
				datas.VehicleApplication = _ctx.StringValue("ListVehicleDetails.Data["+ i +"].VehicleApplication");
				datas.PersonId = _ctx.StringValue("ListVehicleDetails.Data["+ i +"].PersonId");
				datas.PlateId = _ctx.StringValue("ListVehicleDetails.Data["+ i +"].PlateId");
				datas.SourceUrl = _ctx.StringValue("ListVehicleDetails.Data["+ i +"].SourceUrl");
				datas.TargetUrl = _ctx.StringValue("ListVehicleDetails.Data["+ i +"].TargetUrl");

				listVehicleDetailsResponse_data.Add(datas);
			}
			listVehicleDetailsResponse.Data = listVehicleDetailsResponse_data;
        
			return listVehicleDetailsResponse;
        }
    }
}
