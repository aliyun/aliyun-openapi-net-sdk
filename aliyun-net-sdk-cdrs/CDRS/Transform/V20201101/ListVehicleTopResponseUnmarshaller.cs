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
    public class ListVehicleTopResponseUnmarshaller
    {
        public static ListVehicleTopResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVehicleTopResponse listVehicleTopResponse = new ListVehicleTopResponse();

			listVehicleTopResponse.HttpResponse = _ctx.HttpResponse;
			listVehicleTopResponse.Code = _ctx.StringValue("ListVehicleTop.Code");
			listVehicleTopResponse.Message = _ctx.StringValue("ListVehicleTop.Message");
			listVehicleTopResponse.RequestId = _ctx.StringValue("ListVehicleTop.RequestId");
			listVehicleTopResponse.PageNumber = _ctx.LongValue("ListVehicleTop.PageNumber");
			listVehicleTopResponse.PageSize = _ctx.LongValue("ListVehicleTop.PageSize");
			listVehicleTopResponse.TotalCount = _ctx.LongValue("ListVehicleTop.TotalCount");

			List<ListVehicleTopResponse.ListVehicleTop_Datas> listVehicleTopResponse_data = new List<ListVehicleTopResponse.ListVehicleTop_Datas>();
			for (int i = 0; i < _ctx.Length("ListVehicleTop.Data.Length"); i++) {
				ListVehicleTopResponse.ListVehicleTop_Datas datas = new ListVehicleTopResponse.ListVehicleTop_Datas();
				datas.CorpId = _ctx.StringValue("ListVehicleTop.Data["+ i +"].CorpId");
				datas.VehicleId = _ctx.StringValue("ListVehicleTop.Data["+ i +"].VehicleId");
				datas.PoiId = _ctx.StringValue("ListVehicleTop.Data["+ i +"].PoiId");
				datas.PoiName = _ctx.StringValue("ListVehicleTop.Data["+ i +"].PoiName");
				datas.PassHour = _ctx.StringValue("ListVehicleTop.Data["+ i +"].PassHour");
				datas.Frequency = _ctx.StringValue("ListVehicleTop.Data["+ i +"].Frequency");

				listVehicleTopResponse_data.Add(datas);
			}
			listVehicleTopResponse.Data = listVehicleTopResponse_data;
        
			return listVehicleTopResponse;
        }
    }
}
