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
    public class ListCityMapImageDetailsResponseUnmarshaller
    {
        public static ListCityMapImageDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCityMapImageDetailsResponse listCityMapImageDetailsResponse = new ListCityMapImageDetailsResponse();

			listCityMapImageDetailsResponse.HttpResponse = _ctx.HttpResponse;
			listCityMapImageDetailsResponse.Code = _ctx.StringValue("ListCityMapImageDetails.Code");
			listCityMapImageDetailsResponse.Message = _ctx.StringValue("ListCityMapImageDetails.Message");
			listCityMapImageDetailsResponse.RequestId = _ctx.StringValue("ListCityMapImageDetails.RequestId");
			listCityMapImageDetailsResponse.PageNumber = _ctx.LongValue("ListCityMapImageDetails.PageNumber");
			listCityMapImageDetailsResponse.PageSize = _ctx.LongValue("ListCityMapImageDetails.PageSize");
			listCityMapImageDetailsResponse.TotalCount = _ctx.LongValue("ListCityMapImageDetails.TotalCount");

			List<ListCityMapImageDetailsResponse.ListCityMapImageDetails_Datas> listCityMapImageDetailsResponse_data = new List<ListCityMapImageDetailsResponse.ListCityMapImageDetails_Datas>();
			for (int i = 0; i < _ctx.Length("ListCityMapImageDetails.Data.Length"); i++) {
				ListCityMapImageDetailsResponse.ListCityMapImageDetails_Datas datas = new ListCityMapImageDetailsResponse.ListCityMapImageDetails_Datas();
				datas.PersonTargetImageStoragePath = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].PersonTargetImageStoragePath");
				datas.AgeLowerLimit = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].AgeLowerLimit");
				datas.AgeUpLimit = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].AgeUpLimit");
				datas.VehicleColor = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].VehicleColor");
				datas.TrousersColor = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].TrousersColor");
				datas.DataSourceId = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].DataSourceId");
				datas.Gender = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].Gender");
				datas.AgeLowerLimitReliability = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].AgeLowerLimitReliability");
				datas.GenderCodeReliability = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].GenderCodeReliability");
				datas.VehicleClassReliability = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].VehicleClassReliability");
				datas.RecordId = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].RecordId");
				datas.AgeCodeReliability = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].AgeCodeReliability");
				datas.SourceImageStoragePath = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].SourceImageStoragePath");
				datas.VehicleClass = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].VehicleClass");
				datas.MotorTargetImageStoragePath = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].MotorTargetImageStoragePath");
				datas.CoatColor = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].CoatColor");
				datas.FaceTargetImageStoragePath = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].FaceTargetImageStoragePath");
				datas.ShotTime = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].ShotTime");
				datas.VehicleColorReliability = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].VehicleColorReliability");
				datas.TrousersColorReliability = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].TrousersColorReliability");
				datas.CoatColorReliability = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].CoatColorReliability");
				datas.LeftTopX = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].LeftTopX");
				datas.LeftTopY = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].LeftTopY");
				datas.RightBottomX = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].RightBottomX");
				datas.RightBottomY = _ctx.StringValue("ListCityMapImageDetails.Data["+ i +"].RightBottomY");

				listCityMapImageDetailsResponse_data.Add(datas);
			}
			listCityMapImageDetailsResponse.Data = listCityMapImageDetailsResponse_data;
        
			return listCityMapImageDetailsResponse;
        }
    }
}
