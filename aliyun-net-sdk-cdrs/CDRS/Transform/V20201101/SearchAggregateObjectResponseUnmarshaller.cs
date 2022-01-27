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
    public class SearchAggregateObjectResponseUnmarshaller
    {
        public static SearchAggregateObjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchAggregateObjectResponse searchAggregateObjectResponse = new SearchAggregateObjectResponse();

			searchAggregateObjectResponse.HttpResponse = _ctx.HttpResponse;
			searchAggregateObjectResponse.Code = _ctx.StringValue("SearchAggregateObject.Code");
			searchAggregateObjectResponse.Message = _ctx.StringValue("SearchAggregateObject.Message");
			searchAggregateObjectResponse.Total = _ctx.IntegerValue("SearchAggregateObject.Total");
			searchAggregateObjectResponse.PageSize = _ctx.LongValue("SearchAggregateObject.PageSize");
			searchAggregateObjectResponse.RequestId = _ctx.StringValue("SearchAggregateObject.RequestId");
			searchAggregateObjectResponse.Success = _ctx.BooleanValue("SearchAggregateObject.Success");

			SearchAggregateObjectResponse.SearchAggregateObject_Data data = new SearchAggregateObjectResponse.SearchAggregateObject_Data();

			List<SearchAggregateObjectResponse.SearchAggregateObject_Data.SearchAggregateObject_BodyListItem> data_bodyList = new List<SearchAggregateObjectResponse.SearchAggregateObject_Data.SearchAggregateObject_BodyListItem>();
			for (int i = 0; i < _ctx.Length("SearchAggregateObject.Data.BodyList.Length"); i++) {
				SearchAggregateObjectResponse.SearchAggregateObject_Data.SearchAggregateObject_BodyListItem bodyListItem = new SearchAggregateObjectResponse.SearchAggregateObject_Data.SearchAggregateObject_BodyListItem();
				bodyListItem.DeviceID = _ctx.StringValue("SearchAggregateObject.Data.BodyList["+ i +"].DeviceID");
				bodyListItem.ObjectType = _ctx.StringValue("SearchAggregateObject.Data.BodyList["+ i +"].ObjectType");
				bodyListItem.LeftTopX = _ctx.IntegerValue("SearchAggregateObject.Data.BodyList["+ i +"].LeftTopX");
				bodyListItem.LeftTopY = _ctx.IntegerValue("SearchAggregateObject.Data.BodyList["+ i +"].LeftTopY");
				bodyListItem.RightBottomX = _ctx.IntegerValue("SearchAggregateObject.Data.BodyList["+ i +"].RightBottomX");
				bodyListItem.RightBottomY = _ctx.IntegerValue("SearchAggregateObject.Data.BodyList["+ i +"].RightBottomY");
				bodyListItem.Score = _ctx.FloatValue("SearchAggregateObject.Data.BodyList["+ i +"].Score");
				bodyListItem.ShotTime = _ctx.StringValue("SearchAggregateObject.Data.BodyList["+ i +"].ShotTime");
				bodyListItem.SourceImageUrl = _ctx.StringValue("SearchAggregateObject.Data.BodyList["+ i +"].SourceImageUrl");
				bodyListItem.TargetImageUrl = _ctx.StringValue("SearchAggregateObject.Data.BodyList["+ i +"].TargetImageUrl");
				bodyListItem.DeviceName = _ctx.StringValue("SearchAggregateObject.Data.BodyList["+ i +"].DeviceName");
				bodyListItem.DeviceLatitude = _ctx.FloatValue("SearchAggregateObject.Data.BodyList["+ i +"].DeviceLatitude");
				bodyListItem.DeviceLongitude = _ctx.FloatValue("SearchAggregateObject.Data.BodyList["+ i +"].DeviceLongitude");
				bodyListItem.PersonId = _ctx.StringValue("SearchAggregateObject.Data.BodyList["+ i +"].PersonId");

				data_bodyList.Add(bodyListItem);
			}
			data.BodyList = data_bodyList;

			List<SearchAggregateObjectResponse.SearchAggregateObject_Data.SearchAggregateObject_FaceListItem> data_faceList = new List<SearchAggregateObjectResponse.SearchAggregateObject_Data.SearchAggregateObject_FaceListItem>();
			for (int i = 0; i < _ctx.Length("SearchAggregateObject.Data.FaceList.Length"); i++) {
				SearchAggregateObjectResponse.SearchAggregateObject_Data.SearchAggregateObject_FaceListItem faceListItem = new SearchAggregateObjectResponse.SearchAggregateObject_Data.SearchAggregateObject_FaceListItem();
				faceListItem.DeviceID = _ctx.StringValue("SearchAggregateObject.Data.FaceList["+ i +"].DeviceID");
				faceListItem.ObjectType = _ctx.StringValue("SearchAggregateObject.Data.FaceList["+ i +"].ObjectType");
				faceListItem.LeftTopX = _ctx.IntegerValue("SearchAggregateObject.Data.FaceList["+ i +"].LeftTopX");
				faceListItem.LeftTopY = _ctx.IntegerValue("SearchAggregateObject.Data.FaceList["+ i +"].LeftTopY");
				faceListItem.RightBottomX = _ctx.IntegerValue("SearchAggregateObject.Data.FaceList["+ i +"].RightBottomX");
				faceListItem.RightBottomY = _ctx.IntegerValue("SearchAggregateObject.Data.FaceList["+ i +"].RightBottomY");
				faceListItem.Score = _ctx.FloatValue("SearchAggregateObject.Data.FaceList["+ i +"].Score");
				faceListItem.ShotTime = _ctx.StringValue("SearchAggregateObject.Data.FaceList["+ i +"].ShotTime");
				faceListItem.SourceImageUrl = _ctx.StringValue("SearchAggregateObject.Data.FaceList["+ i +"].SourceImageUrl");
				faceListItem.TargetImageUrl = _ctx.StringValue("SearchAggregateObject.Data.FaceList["+ i +"].TargetImageUrl");
				faceListItem.DeviceName = _ctx.StringValue("SearchAggregateObject.Data.FaceList["+ i +"].DeviceName");
				faceListItem.DeviceLatitude = _ctx.FloatValue("SearchAggregateObject.Data.FaceList["+ i +"].DeviceLatitude");
				faceListItem.DeviceLongitude = _ctx.FloatValue("SearchAggregateObject.Data.FaceList["+ i +"].DeviceLongitude");
				faceListItem.PersonId = _ctx.StringValue("SearchAggregateObject.Data.FaceList["+ i +"].PersonId");

				data_faceList.Add(faceListItem);
			}
			data.FaceList = data_faceList;

			List<SearchAggregateObjectResponse.SearchAggregateObject_Data.SearchAggregateObject_MotorListItem> data_motorList = new List<SearchAggregateObjectResponse.SearchAggregateObject_Data.SearchAggregateObject_MotorListItem>();
			for (int i = 0; i < _ctx.Length("SearchAggregateObject.Data.MotorList.Length"); i++) {
				SearchAggregateObjectResponse.SearchAggregateObject_Data.SearchAggregateObject_MotorListItem motorListItem = new SearchAggregateObjectResponse.SearchAggregateObject_Data.SearchAggregateObject_MotorListItem();
				motorListItem.DeviceID = _ctx.StringValue("SearchAggregateObject.Data.MotorList["+ i +"].DeviceID");
				motorListItem.ObjectType = _ctx.StringValue("SearchAggregateObject.Data.MotorList["+ i +"].ObjectType");
				motorListItem.LeftTopX = _ctx.IntegerValue("SearchAggregateObject.Data.MotorList["+ i +"].LeftTopX");
				motorListItem.LeftTopY = _ctx.IntegerValue("SearchAggregateObject.Data.MotorList["+ i +"].LeftTopY");
				motorListItem.RightBottomX = _ctx.IntegerValue("SearchAggregateObject.Data.MotorList["+ i +"].RightBottomX");
				motorListItem.RightBottomY = _ctx.IntegerValue("SearchAggregateObject.Data.MotorList["+ i +"].RightBottomY");
				motorListItem.Score = _ctx.FloatValue("SearchAggregateObject.Data.MotorList["+ i +"].Score");
				motorListItem.ShotTime = _ctx.StringValue("SearchAggregateObject.Data.MotorList["+ i +"].ShotTime");
				motorListItem.SourceImageUrl = _ctx.StringValue("SearchAggregateObject.Data.MotorList["+ i +"].SourceImageUrl");
				motorListItem.TargetImageUrl = _ctx.StringValue("SearchAggregateObject.Data.MotorList["+ i +"].TargetImageUrl");
				motorListItem.DeviceName = _ctx.StringValue("SearchAggregateObject.Data.MotorList["+ i +"].DeviceName");
				motorListItem.DeviceLatitude = _ctx.FloatValue("SearchAggregateObject.Data.MotorList["+ i +"].DeviceLatitude");
				motorListItem.DeviceLongitude = _ctx.FloatValue("SearchAggregateObject.Data.MotorList["+ i +"].DeviceLongitude");
				motorListItem.PersonId = _ctx.StringValue("SearchAggregateObject.Data.MotorList["+ i +"].PersonId");

				data_motorList.Add(motorListItem);
			}
			data.MotorList = data_motorList;

			List<SearchAggregateObjectResponse.SearchAggregateObject_Data.SearchAggregateObject_NonMotorListItem> data_nonMotorList = new List<SearchAggregateObjectResponse.SearchAggregateObject_Data.SearchAggregateObject_NonMotorListItem>();
			for (int i = 0; i < _ctx.Length("SearchAggregateObject.Data.NonMotorList.Length"); i++) {
				SearchAggregateObjectResponse.SearchAggregateObject_Data.SearchAggregateObject_NonMotorListItem nonMotorListItem = new SearchAggregateObjectResponse.SearchAggregateObject_Data.SearchAggregateObject_NonMotorListItem();
				nonMotorListItem.DeviceID = _ctx.StringValue("SearchAggregateObject.Data.NonMotorList["+ i +"].DeviceID");
				nonMotorListItem.ObjectType = _ctx.StringValue("SearchAggregateObject.Data.NonMotorList["+ i +"].ObjectType");
				nonMotorListItem.LeftTopX = _ctx.IntegerValue("SearchAggregateObject.Data.NonMotorList["+ i +"].LeftTopX");
				nonMotorListItem.LeftTopY = _ctx.IntegerValue("SearchAggregateObject.Data.NonMotorList["+ i +"].LeftTopY");
				nonMotorListItem.RightBottomX = _ctx.IntegerValue("SearchAggregateObject.Data.NonMotorList["+ i +"].RightBottomX");
				nonMotorListItem.RightBottomY = _ctx.IntegerValue("SearchAggregateObject.Data.NonMotorList["+ i +"].RightBottomY");
				nonMotorListItem.Score = _ctx.FloatValue("SearchAggregateObject.Data.NonMotorList["+ i +"].Score");
				nonMotorListItem.ShotTime = _ctx.StringValue("SearchAggregateObject.Data.NonMotorList["+ i +"].ShotTime");
				nonMotorListItem.SourceImageUrl = _ctx.StringValue("SearchAggregateObject.Data.NonMotorList["+ i +"].SourceImageUrl");
				nonMotorListItem.TargetImageUrl = _ctx.StringValue("SearchAggregateObject.Data.NonMotorList["+ i +"].TargetImageUrl");
				nonMotorListItem.DeviceName = _ctx.StringValue("SearchAggregateObject.Data.NonMotorList["+ i +"].DeviceName");
				nonMotorListItem.DeviceLatitude = _ctx.FloatValue("SearchAggregateObject.Data.NonMotorList["+ i +"].DeviceLatitude");
				nonMotorListItem.DeviceLongitude = _ctx.FloatValue("SearchAggregateObject.Data.NonMotorList["+ i +"].DeviceLongitude");
				nonMotorListItem.PersonId = _ctx.StringValue("SearchAggregateObject.Data.NonMotorList["+ i +"].PersonId");

				data_nonMotorList.Add(nonMotorListItem);
			}
			data.NonMotorList = data_nonMotorList;
			searchAggregateObjectResponse.Data = data;
        
			return searchAggregateObjectResponse;
        }
    }
}
