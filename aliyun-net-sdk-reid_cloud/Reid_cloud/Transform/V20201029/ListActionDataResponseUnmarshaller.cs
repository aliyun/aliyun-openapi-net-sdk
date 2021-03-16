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
using Aliyun.Acs.reid_cloud.Model.V20201029;

namespace Aliyun.Acs.reid_cloud.Transform.V20201029
{
    public class ListActionDataResponseUnmarshaller
    {
        public static ListActionDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListActionDataResponse listActionDataResponse = new ListActionDataResponse();

			listActionDataResponse.HttpResponse = _ctx.HttpResponse;
			listActionDataResponse.RequestId = _ctx.StringValue("ListActionData.RequestId");
			listActionDataResponse.Success = _ctx.BooleanValue("ListActionData.Success");
			listActionDataResponse.DynamicMessage = _ctx.StringValue("ListActionData.DynamicMessage");
			listActionDataResponse.CursorTime = _ctx.LongValue("ListActionData.CursorTime");
			listActionDataResponse.ErrorCode = _ctx.StringValue("ListActionData.ErrorCode");
			listActionDataResponse.ErrorMessage = _ctx.StringValue("ListActionData.ErrorMessage");
			listActionDataResponse.PageNumber = _ctx.IntegerValue("ListActionData.PageNumber");
			listActionDataResponse.Message = _ctx.StringValue("ListActionData.Message");
			listActionDataResponse.Code = _ctx.StringValue("ListActionData.Code");
			listActionDataResponse.TotalCount = _ctx.LongValue("ListActionData.TotalCount");
			listActionDataResponse.DynamicCode = _ctx.StringValue("ListActionData.DynamicCode");
			listActionDataResponse.PageSize = _ctx.IntegerValue("ListActionData.PageSize");

			List<ListActionDataResponse.ListActionData_Action> listActionDataResponse_actions = new List<ListActionDataResponse.ListActionData_Action>();
			for (int i = 0; i < _ctx.Length("ListActionData.Actions.Length"); i++) {
				ListActionDataResponse.ListActionData_Action action = new ListActionDataResponse.ListActionData_Action();
				action.StoreId = _ctx.LongValue("ListActionData.Actions["+ i +"].StoreId");
				action.GmtCreate = _ctx.LongValue("ListActionData.Actions["+ i +"].GmtCreate");
				action.LeaveTimestamp = _ctx.LongValue("ListActionData.Actions["+ i +"].LeaveTimestamp");
				action.LocationLayerType = _ctx.StringValue("ListActionData.Actions["+ i +"].LocationLayerType");
				action.StayValid = _ctx.BooleanValue("ListActionData.Actions["+ i +"].StayValid");
				action.Gender = _ctx.StringValue("ListActionData.Actions["+ i +"].Gender");
				action.UkId = _ctx.LongValue("ListActionData.Actions["+ i +"].UkId");
				action.ArriveTimestamp = _ctx.LongValue("ListActionData.Actions["+ i +"].ArriveTimestamp");
				action.GmtModified = _ctx.LongValue("ListActionData.Actions["+ i +"].GmtModified");
				action.ImageType = _ctx.StringValue("ListActionData.Actions["+ i +"].ImageType");
				action.InStay = _ctx.LongValue("ListActionData.Actions["+ i +"].InStay");
				action.Status = _ctx.IntegerValue("ListActionData.Actions["+ i +"].Status");
				action.Age = _ctx.IntegerValue("ListActionData.Actions["+ i +"].Age");
				action.Id = _ctx.LongValue("ListActionData.Actions["+ i +"].Id");
				action.BodyPointNumber = _ctx.IntegerValue("ListActionData.Actions["+ i +"].BodyPointNumber");
				action.ImageUrl = _ctx.StringValue("ListActionData.Actions["+ i +"].ImageUrl");
				action.LocationId = _ctx.LongValue("ListActionData.Actions["+ i +"].LocationId");
				action.StayPeriod = _ctx.IntegerValue("ListActionData.Actions["+ i +"].StayPeriod");
				action.FacePointNumber = _ctx.IntegerValue("ListActionData.Actions["+ i +"].FacePointNumber");
				action.Score = _ctx.FloatValue("ListActionData.Actions["+ i +"].Score");
				action.SpecialType = _ctx.StringValue("ListActionData.Actions["+ i +"].SpecialType");
				action.ImageObjectKey = _ctx.StringValue("ListActionData.Actions["+ i +"].ImageObjectKey");

				ListActionDataResponse.ListActionData_Action.ListActionData_ObjectPositionInImage objectPositionInImage = new ListActionDataResponse.ListActionData_Action.ListActionData_ObjectPositionInImage();
				objectPositionInImage.Bottom = _ctx.FloatValue("ListActionData.Actions["+ i +"].ObjectPositionInImage.Bottom");
				objectPositionInImage.Left = _ctx.FloatValue("ListActionData.Actions["+ i +"].ObjectPositionInImage.Left");
				objectPositionInImage.Top = _ctx.FloatValue("ListActionData.Actions["+ i +"].ObjectPositionInImage.Top");
				objectPositionInImage.Right = _ctx.FloatValue("ListActionData.Actions["+ i +"].ObjectPositionInImage.Right");
				action.ObjectPositionInImage = objectPositionInImage;

				ListActionDataResponse.ListActionData_Action.ListActionData_PointInMap pointInMap = new ListActionDataResponse.ListActionData_Action.ListActionData_PointInMap();
				pointInMap.X = _ctx.FloatValue("ListActionData.Actions["+ i +"].PointInMap.X");
				pointInMap.Y = _ctx.FloatValue("ListActionData.Actions["+ i +"].PointInMap.Y");
				action.PointInMap = pointInMap;

				listActionDataResponse_actions.Add(action);
			}
			listActionDataResponse.Actions = listActionDataResponse_actions;
        
			return listActionDataResponse;
        }
    }
}
