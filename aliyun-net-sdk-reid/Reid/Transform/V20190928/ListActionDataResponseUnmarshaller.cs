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
using Aliyun.Acs.reid.Model.V20190928;

namespace Aliyun.Acs.reid.Transform.V20190928
{
    public class ListActionDataResponseUnmarshaller
    {
        public static ListActionDataResponse Unmarshall(UnmarshallerContext context)
        {
			ListActionDataResponse listActionDataResponse = new ListActionDataResponse();

			listActionDataResponse.HttpResponse = context.HttpResponse;
			listActionDataResponse.RequestId = context.StringValue("ListActionData.RequestId");
			listActionDataResponse.Success = context.BooleanValue("ListActionData.Success");
			listActionDataResponse.CursorTime = context.LongValue("ListActionData.CursorTime");
			listActionDataResponse.ErrorCode = context.StringValue("ListActionData.ErrorCode");
			listActionDataResponse.ErrorMessage = context.StringValue("ListActionData.ErrorMessage");
			listActionDataResponse.PageNumber = context.IntegerValue("ListActionData.PageNumber");
			listActionDataResponse.TotalCount = context.LongValue("ListActionData.TotalCount");
			listActionDataResponse.PageSize = context.IntegerValue("ListActionData.PageSize");

			List<ListActionDataResponse.ListActionData_Action> listActionDataResponse_actions = new List<ListActionDataResponse.ListActionData_Action>();
			for (int i = 0; i < context.Length("ListActionData.Actions.Length"); i++) {
				ListActionDataResponse.ListActionData_Action action = new ListActionDataResponse.ListActionData_Action();
				action.StoreId = context.LongValue("ListActionData.Actions["+ i +"].StoreId");
				action.GmtCreate = context.LongValue("ListActionData.Actions["+ i +"].GmtCreate");
				action.LeaveTimestamp = context.LongValue("ListActionData.Actions["+ i +"].LeaveTimestamp");
				action.LocationLayerType = context.StringValue("ListActionData.Actions["+ i +"].LocationLayerType");
				action.StayValid = context.BooleanValue("ListActionData.Actions["+ i +"].StayValid");
				action.Gender = context.StringValue("ListActionData.Actions["+ i +"].Gender");
				action.UkId = context.LongValue("ListActionData.Actions["+ i +"].UkId");
				action.ArriveTimestamp = context.LongValue("ListActionData.Actions["+ i +"].ArriveTimestamp");
				action.GmtModified = context.LongValue("ListActionData.Actions["+ i +"].GmtModified");
				action.ImageType = context.StringValue("ListActionData.Actions["+ i +"].ImageType");
				action.InStay = context.LongValue("ListActionData.Actions["+ i +"].InStay");
				action.Status = context.IntegerValue("ListActionData.Actions["+ i +"].Status");
				action.Age = context.IntegerValue("ListActionData.Actions["+ i +"].Age");
				action.Id = context.LongValue("ListActionData.Actions["+ i +"].Id");
				action.ImageUrl = context.StringValue("ListActionData.Actions["+ i +"].ImageUrl");
				action.LocationId = context.LongValue("ListActionData.Actions["+ i +"].LocationId");
				action.StayPeriod = context.IntegerValue("ListActionData.Actions["+ i +"].StayPeriod");
				action.Score = context.FloatValue("ListActionData.Actions["+ i +"].Score");
				action.SpecialType = context.StringValue("ListActionData.Actions["+ i +"].SpecialType");
				action.ImageObjectKey = context.StringValue("ListActionData.Actions["+ i +"].ImageObjectKey");
				action.FacePointNumber = context.IntegerValue("ListActionData.Actions["+ i +"].FacePointNumber");
				action.BodyPointNumber = context.IntegerValue("ListActionData.Actions["+ i +"].BodyPointNumber");

				ListActionDataResponse.ListActionData_Action.ListActionData_ObjectPositionInImage objectPositionInImage = new ListActionDataResponse.ListActionData_Action.ListActionData_ObjectPositionInImage();
				objectPositionInImage.Bottom = context.FloatValue("ListActionData.Actions["+ i +"].ObjectPositionInImage.Bottom");
				objectPositionInImage.Left = context.FloatValue("ListActionData.Actions["+ i +"].ObjectPositionInImage.Left");
				objectPositionInImage.Top = context.FloatValue("ListActionData.Actions["+ i +"].ObjectPositionInImage.Top");
				objectPositionInImage.Right = context.FloatValue("ListActionData.Actions["+ i +"].ObjectPositionInImage.Right");
				action.ObjectPositionInImage = objectPositionInImage;

				ListActionDataResponse.ListActionData_Action.ListActionData_PointInMap pointInMap = new ListActionDataResponse.ListActionData_Action.ListActionData_PointInMap();
				pointInMap.X = context.FloatValue("ListActionData.Actions["+ i +"].PointInMap.X");
				pointInMap.Y = context.FloatValue("ListActionData.Actions["+ i +"].PointInMap.Y");
				action.PointInMap = pointInMap;

				listActionDataResponse_actions.Add(action);
			}
			listActionDataResponse.Actions = listActionDataResponse_actions;
        
			return listActionDataResponse;
        }
    }
}
