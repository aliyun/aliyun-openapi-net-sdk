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
    public class ListVehicleTagDistributeResponseUnmarshaller
    {
        public static ListVehicleTagDistributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVehicleTagDistributeResponse listVehicleTagDistributeResponse = new ListVehicleTagDistributeResponse();

			listVehicleTagDistributeResponse.HttpResponse = _ctx.HttpResponse;
			listVehicleTagDistributeResponse.Code = _ctx.StringValue("ListVehicleTagDistribute.Code");
			listVehicleTagDistributeResponse.Message = _ctx.StringValue("ListVehicleTagDistribute.Message");
			listVehicleTagDistributeResponse.RequestId = _ctx.StringValue("ListVehicleTagDistribute.RequestId");
			listVehicleTagDistributeResponse.PageNumber = _ctx.LongValue("ListVehicleTagDistribute.PageNumber");
			listVehicleTagDistributeResponse.PageSize = _ctx.LongValue("ListVehicleTagDistribute.PageSize");
			listVehicleTagDistributeResponse.TotalCount = _ctx.LongValue("ListVehicleTagDistribute.TotalCount");

			List<ListVehicleTagDistributeResponse.ListVehicleTagDistribute_Datas> listVehicleTagDistributeResponse_data = new List<ListVehicleTagDistributeResponse.ListVehicleTagDistribute_Datas>();
			for (int i = 0; i < _ctx.Length("ListVehicleTagDistribute.Data.Length"); i++) {
				ListVehicleTagDistributeResponse.ListVehicleTagDistribute_Datas datas = new ListVehicleTagDistributeResponse.ListVehicleTagDistribute_Datas();
				datas.CorpId = _ctx.StringValue("ListVehicleTagDistribute.Data["+ i +"].CorpId");
				datas.TagValue = _ctx.StringValue("ListVehicleTagDistribute.Data["+ i +"].TagValue");
				datas._Value = _ctx.StringValue("ListVehicleTagDistribute.Data["+ i +"].Value");

				listVehicleTagDistributeResponse_data.Add(datas);
			}
			listVehicleTagDistributeResponse.Data = listVehicleTagDistributeResponse_data;
        
			return listVehicleTagDistributeResponse;
        }
    }
}
