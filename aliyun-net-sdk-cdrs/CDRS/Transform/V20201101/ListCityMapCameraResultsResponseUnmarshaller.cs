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
    public class ListCityMapCameraResultsResponseUnmarshaller
    {
        public static ListCityMapCameraResultsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCityMapCameraResultsResponse listCityMapCameraResultsResponse = new ListCityMapCameraResultsResponse();

			listCityMapCameraResultsResponse.HttpResponse = _ctx.HttpResponse;
			listCityMapCameraResultsResponse.Code = _ctx.StringValue("ListCityMapCameraResults.Code");
			listCityMapCameraResultsResponse.Message = _ctx.StringValue("ListCityMapCameraResults.Message");
			listCityMapCameraResultsResponse.RequestId = _ctx.StringValue("ListCityMapCameraResults.RequestId");
			listCityMapCameraResultsResponse.TotalCount = _ctx.LongValue("ListCityMapCameraResults.TotalCount");
			listCityMapCameraResultsResponse.PageNum = _ctx.StringValue("ListCityMapCameraResults.PageNum");
			listCityMapCameraResultsResponse.PageSize = _ctx.StringValue("ListCityMapCameraResults.PageSize");

			List<ListCityMapCameraResultsResponse.ListCityMapCameraResults_Datas> listCityMapCameraResultsResponse_data = new List<ListCityMapCameraResultsResponse.ListCityMapCameraResults_Datas>();
			for (int i = 0; i < _ctx.Length("ListCityMapCameraResults.Data.Length"); i++) {
				ListCityMapCameraResultsResponse.ListCityMapCameraResults_Datas datas = new ListCityMapCameraResultsResponse.ListCityMapCameraResults_Datas();
				datas.DataSourceId = _ctx.StringValue("ListCityMapCameraResults.Data["+ i +"].DataSourceId");
				datas.Latitude = _ctx.StringValue("ListCityMapCameraResults.Data["+ i +"].Latitude");
				datas.Longitude = _ctx.StringValue("ListCityMapCameraResults.Data["+ i +"].Longitude");
				datas.NearPoi = _ctx.StringValue("ListCityMapCameraResults.Data["+ i +"].NearPoi");
				datas.DataSourcePoi = _ctx.StringValue("ListCityMapCameraResults.Data["+ i +"].DataSourcePoi");
				datas.DataSourceName = _ctx.StringValue("ListCityMapCameraResults.Data["+ i +"].DataSourceName");
				datas.CorpId = _ctx.StringValue("ListCityMapCameraResults.Data["+ i +"].CorpId");

				listCityMapCameraResultsResponse_data.Add(datas);
			}
			listCityMapCameraResultsResponse.Data = listCityMapCameraResultsResponse_data;
        
			return listCityMapCameraResultsResponse;
        }
    }
}
