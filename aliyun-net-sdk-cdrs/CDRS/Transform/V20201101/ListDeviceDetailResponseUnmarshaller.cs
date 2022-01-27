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
    public class ListDeviceDetailResponseUnmarshaller
    {
        public static ListDeviceDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDeviceDetailResponse listDeviceDetailResponse = new ListDeviceDetailResponse();

			listDeviceDetailResponse.HttpResponse = _ctx.HttpResponse;
			listDeviceDetailResponse.Code = _ctx.StringValue("ListDeviceDetail.Code");
			listDeviceDetailResponse.Message = _ctx.StringValue("ListDeviceDetail.Message");
			listDeviceDetailResponse.RequestId = _ctx.StringValue("ListDeviceDetail.RequestId");
			listDeviceDetailResponse.PageNumber = _ctx.LongValue("ListDeviceDetail.PageNumber");
			listDeviceDetailResponse.PageSize = _ctx.LongValue("ListDeviceDetail.PageSize");
			listDeviceDetailResponse.TotalCount = _ctx.LongValue("ListDeviceDetail.TotalCount");

			List<ListDeviceDetailResponse.ListDeviceDetail_Datas> listDeviceDetailResponse_data = new List<ListDeviceDetailResponse.ListDeviceDetail_Datas>();
			for (int i = 0; i < _ctx.Length("ListDeviceDetail.Data.Length"); i++) {
				ListDeviceDetailResponse.ListDeviceDetail_Datas datas = new ListDeviceDetailResponse.ListDeviceDetail_Datas();
				datas.DataSourceId = _ctx.StringValue("ListDeviceDetail.Data["+ i +"].DataSourceId");
				datas.CorpId = _ctx.StringValue("ListDeviceDetail.Data["+ i +"].CorpId");
				datas.DataSourceName = _ctx.StringValue("ListDeviceDetail.Data["+ i +"].DataSourceName");
				datas.DataSourcePoi = _ctx.StringValue("ListDeviceDetail.Data["+ i +"].DataSourcePoi");
				datas.NearPoi = _ctx.StringValue("ListDeviceDetail.Data["+ i +"].NearPoi");
				datas.Latitude = _ctx.StringValue("ListDeviceDetail.Data["+ i +"].Latitude");
				datas.Longitude = _ctx.StringValue("ListDeviceDetail.Data["+ i +"].Longitude");

				listDeviceDetailResponse_data.Add(datas);
			}
			listDeviceDetailResponse.Data = listDeviceDetailResponse_data;
        
			return listDeviceDetailResponse;
        }
    }
}
