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
    public class SearchObjectResponseUnmarshaller
    {
        public static SearchObjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchObjectResponse searchObjectResponse = new SearchObjectResponse();

			searchObjectResponse.HttpResponse = _ctx.HttpResponse;
			searchObjectResponse.Code = _ctx.StringValue("SearchObject.Code");
			searchObjectResponse.Message = _ctx.StringValue("SearchObject.Message");
			searchObjectResponse.Total = _ctx.IntegerValue("SearchObject.Total");
			searchObjectResponse.PageSize = _ctx.LongValue("SearchObject.PageSize");
			searchObjectResponse.RequestId = _ctx.StringValue("SearchObject.RequestId");
			searchObjectResponse.Success = _ctx.BooleanValue("SearchObject.Success");

			SearchObjectResponse.SearchObject_Data data = new SearchObjectResponse.SearchObject_Data();

			List<SearchObjectResponse.SearchObject_Data.SearchObject_BodyListItem> data_bodyList = new List<SearchObjectResponse.SearchObject_Data.SearchObject_BodyListItem>();
			for (int i = 0; i < _ctx.Length("SearchObject.Data.BodyList.Length"); i++) {
				SearchObjectResponse.SearchObject_Data.SearchObject_BodyListItem bodyListItem = new SearchObjectResponse.SearchObject_Data.SearchObject_BodyListItem();
				bodyListItem.DeviceID = _ctx.StringValue("SearchObject.Data.BodyList["+ i +"].DeviceID");
				bodyListItem.ObjectType = _ctx.StringValue("SearchObject.Data.BodyList["+ i +"].ObjectType");
				bodyListItem.LeftTopX = _ctx.IntegerValue("SearchObject.Data.BodyList["+ i +"].LeftTopX");
				bodyListItem.LeftTopY = _ctx.IntegerValue("SearchObject.Data.BodyList["+ i +"].LeftTopY");
				bodyListItem.RightBottomX = _ctx.IntegerValue("SearchObject.Data.BodyList["+ i +"].RightBottomX");
				bodyListItem.RightBottomY = _ctx.IntegerValue("SearchObject.Data.BodyList["+ i +"].RightBottomY");
				bodyListItem.Score = _ctx.FloatValue("SearchObject.Data.BodyList["+ i +"].Score");
				bodyListItem.ShotTime = _ctx.StringValue("SearchObject.Data.BodyList["+ i +"].ShotTime");
				bodyListItem.SourceImageUrl = _ctx.StringValue("SearchObject.Data.BodyList["+ i +"].SourceImageUrl");
				bodyListItem.TargetImageUrl = _ctx.StringValue("SearchObject.Data.BodyList["+ i +"].TargetImageUrl");

				data_bodyList.Add(bodyListItem);
			}
			data.BodyList = data_bodyList;

			List<SearchObjectResponse.SearchObject_Data.SearchObject_FaceListItem> data_faceList = new List<SearchObjectResponse.SearchObject_Data.SearchObject_FaceListItem>();
			for (int i = 0; i < _ctx.Length("SearchObject.Data.FaceList.Length"); i++) {
				SearchObjectResponse.SearchObject_Data.SearchObject_FaceListItem faceListItem = new SearchObjectResponse.SearchObject_Data.SearchObject_FaceListItem();
				faceListItem.DeviceID = _ctx.StringValue("SearchObject.Data.FaceList["+ i +"].DeviceID");
				faceListItem.ObjectType = _ctx.StringValue("SearchObject.Data.FaceList["+ i +"].ObjectType");
				faceListItem.LeftTopX = _ctx.IntegerValue("SearchObject.Data.FaceList["+ i +"].LeftTopX");
				faceListItem.LeftTopY = _ctx.IntegerValue("SearchObject.Data.FaceList["+ i +"].LeftTopY");
				faceListItem.RightBottomX = _ctx.IntegerValue("SearchObject.Data.FaceList["+ i +"].RightBottomX");
				faceListItem.RightBottomY = _ctx.IntegerValue("SearchObject.Data.FaceList["+ i +"].RightBottomY");
				faceListItem.Score = _ctx.FloatValue("SearchObject.Data.FaceList["+ i +"].Score");
				faceListItem.ShotTime = _ctx.StringValue("SearchObject.Data.FaceList["+ i +"].ShotTime");
				faceListItem.SourceImageUrl = _ctx.StringValue("SearchObject.Data.FaceList["+ i +"].SourceImageUrl");
				faceListItem.TargetImageUrl = _ctx.StringValue("SearchObject.Data.FaceList["+ i +"].TargetImageUrl");

				data_faceList.Add(faceListItem);
			}
			data.FaceList = data_faceList;

			List<SearchObjectResponse.SearchObject_Data.SearchObject_MotorListItem> data_motorList = new List<SearchObjectResponse.SearchObject_Data.SearchObject_MotorListItem>();
			for (int i = 0; i < _ctx.Length("SearchObject.Data.MotorList.Length"); i++) {
				SearchObjectResponse.SearchObject_Data.SearchObject_MotorListItem motorListItem = new SearchObjectResponse.SearchObject_Data.SearchObject_MotorListItem();
				motorListItem.DeviceID = _ctx.StringValue("SearchObject.Data.MotorList["+ i +"].DeviceID");
				motorListItem.ObjectType = _ctx.StringValue("SearchObject.Data.MotorList["+ i +"].ObjectType");
				motorListItem.LeftTopX = _ctx.IntegerValue("SearchObject.Data.MotorList["+ i +"].LeftTopX");
				motorListItem.LeftTopY = _ctx.IntegerValue("SearchObject.Data.MotorList["+ i +"].LeftTopY");
				motorListItem.RightBottomX = _ctx.IntegerValue("SearchObject.Data.MotorList["+ i +"].RightBottomX");
				motorListItem.RightBottomY = _ctx.IntegerValue("SearchObject.Data.MotorList["+ i +"].RightBottomY");
				motorListItem.Score = _ctx.FloatValue("SearchObject.Data.MotorList["+ i +"].Score");
				motorListItem.ShotTime = _ctx.StringValue("SearchObject.Data.MotorList["+ i +"].ShotTime");
				motorListItem.SourceImageUrl = _ctx.StringValue("SearchObject.Data.MotorList["+ i +"].SourceImageUrl");
				motorListItem.TargetImageUrl = _ctx.StringValue("SearchObject.Data.MotorList["+ i +"].TargetImageUrl");

				data_motorList.Add(motorListItem);
			}
			data.MotorList = data_motorList;

			List<SearchObjectResponse.SearchObject_Data.SearchObject_NonMotorListItem> data_nonMotorList = new List<SearchObjectResponse.SearchObject_Data.SearchObject_NonMotorListItem>();
			for (int i = 0; i < _ctx.Length("SearchObject.Data.NonMotorList.Length"); i++) {
				SearchObjectResponse.SearchObject_Data.SearchObject_NonMotorListItem nonMotorListItem = new SearchObjectResponse.SearchObject_Data.SearchObject_NonMotorListItem();
				nonMotorListItem.DeviceID = _ctx.StringValue("SearchObject.Data.NonMotorList["+ i +"].DeviceID");
				nonMotorListItem.ObjectType = _ctx.StringValue("SearchObject.Data.NonMotorList["+ i +"].ObjectType");
				nonMotorListItem.LeftTopX = _ctx.IntegerValue("SearchObject.Data.NonMotorList["+ i +"].LeftTopX");
				nonMotorListItem.LeftTopY = _ctx.IntegerValue("SearchObject.Data.NonMotorList["+ i +"].LeftTopY");
				nonMotorListItem.RightBottomX = _ctx.IntegerValue("SearchObject.Data.NonMotorList["+ i +"].RightBottomX");
				nonMotorListItem.RightBottomY = _ctx.IntegerValue("SearchObject.Data.NonMotorList["+ i +"].RightBottomY");
				nonMotorListItem.Score = _ctx.FloatValue("SearchObject.Data.NonMotorList["+ i +"].Score");
				nonMotorListItem.ShotTime = _ctx.StringValue("SearchObject.Data.NonMotorList["+ i +"].ShotTime");
				nonMotorListItem.SourceImageUrl = _ctx.StringValue("SearchObject.Data.NonMotorList["+ i +"].SourceImageUrl");
				nonMotorListItem.TargetImageUrl = _ctx.StringValue("SearchObject.Data.NonMotorList["+ i +"].TargetImageUrl");

				data_nonMotorList.Add(nonMotorListItem);
			}
			data.NonMotorList = data_nonMotorList;
			searchObjectResponse.Data = data;
        
			return searchObjectResponse;
        }
    }
}
