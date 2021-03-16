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
    public class PullActionDataResponseUnmarshaller
    {
        public static PullActionDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			PullActionDataResponse pullActionDataResponse = new PullActionDataResponse();

			pullActionDataResponse.HttpResponse = _ctx.HttpResponse;
			pullActionDataResponse.ErrorCode = _ctx.StringValue("PullActionData.ErrorCode");
			pullActionDataResponse.ErrorMessage = _ctx.StringValue("PullActionData.ErrorMessage");
			pullActionDataResponse.Message = _ctx.StringValue("PullActionData.Message");
			pullActionDataResponse.Code = _ctx.StringValue("PullActionData.Code");
			pullActionDataResponse.DynamicCode = _ctx.StringValue("PullActionData.DynamicCode");
			pullActionDataResponse.PartitionIndex = _ctx.IntegerValue("PullActionData.PartitionIndex");
			pullActionDataResponse.RequestId = _ctx.StringValue("PullActionData.RequestId");
			pullActionDataResponse.Success = _ctx.BooleanValue("PullActionData.Success");
			pullActionDataResponse.NextMessageId = _ctx.LongValue("PullActionData.NextMessageId");
			pullActionDataResponse.DynamicMessage = _ctx.StringValue("PullActionData.DynamicMessage");

			List<PullActionDataResponse.PullActionData_Action> pullActionDataResponse_actions = new List<PullActionDataResponse.PullActionData_Action>();
			for (int i = 0; i < _ctx.Length("PullActionData.Actions.Length"); i++) {
				PullActionDataResponse.PullActionData_Action action = new PullActionDataResponse.PullActionData_Action();
				action.StoreId = _ctx.LongValue("PullActionData.Actions["+ i +"].StoreId");
				action.GmtCreate = _ctx.LongValue("PullActionData.Actions["+ i +"].GmtCreate");
				action.LeaveTimestamp = _ctx.LongValue("PullActionData.Actions["+ i +"].LeaveTimestamp");
				action.LocationLayerType = _ctx.StringValue("PullActionData.Actions["+ i +"].LocationLayerType");
				action.StayValid = _ctx.BooleanValue("PullActionData.Actions["+ i +"].StayValid");
				action.Gender = _ctx.StringValue("PullActionData.Actions["+ i +"].Gender");
				action.UkId = _ctx.LongValue("PullActionData.Actions["+ i +"].UkId");
				action.ArriveTimestamp = _ctx.LongValue("PullActionData.Actions["+ i +"].ArriveTimestamp");
				action.GmtModified = _ctx.LongValue("PullActionData.Actions["+ i +"].GmtModified");
				action.ImageType = _ctx.StringValue("PullActionData.Actions["+ i +"].ImageType");
				action.InStay = _ctx.LongValue("PullActionData.Actions["+ i +"].InStay");
				action.Status = _ctx.IntegerValue("PullActionData.Actions["+ i +"].Status");
				action.Age = _ctx.IntegerValue("PullActionData.Actions["+ i +"].Age");
				action.Id = _ctx.LongValue("PullActionData.Actions["+ i +"].Id");
				action.BodyPointNumber = _ctx.IntegerValue("PullActionData.Actions["+ i +"].BodyPointNumber");
				action.ImageUrl = _ctx.StringValue("PullActionData.Actions["+ i +"].ImageUrl");
				action.LocationId = _ctx.LongValue("PullActionData.Actions["+ i +"].LocationId");
				action.StayPeriod = _ctx.IntegerValue("PullActionData.Actions["+ i +"].StayPeriod");
				action.FacePointNumber = _ctx.IntegerValue("PullActionData.Actions["+ i +"].FacePointNumber");
				action.Score = _ctx.FloatValue("PullActionData.Actions["+ i +"].Score");
				action.SpecialType = _ctx.StringValue("PullActionData.Actions["+ i +"].SpecialType");
				action.ImageObjectKey = _ctx.StringValue("PullActionData.Actions["+ i +"].ImageObjectKey");

				PullActionDataResponse.PullActionData_Action.PullActionData_ObjectPositionInImage objectPositionInImage = new PullActionDataResponse.PullActionData_Action.PullActionData_ObjectPositionInImage();
				objectPositionInImage.Bottom = _ctx.FloatValue("PullActionData.Actions["+ i +"].ObjectPositionInImage.Bottom");
				objectPositionInImage.Left = _ctx.FloatValue("PullActionData.Actions["+ i +"].ObjectPositionInImage.Left");
				objectPositionInImage.Top = _ctx.FloatValue("PullActionData.Actions["+ i +"].ObjectPositionInImage.Top");
				objectPositionInImage.Right = _ctx.FloatValue("PullActionData.Actions["+ i +"].ObjectPositionInImage.Right");
				action.ObjectPositionInImage = objectPositionInImage;

				PullActionDataResponse.PullActionData_Action.PullActionData_PointInMap pointInMap = new PullActionDataResponse.PullActionData_Action.PullActionData_PointInMap();
				pointInMap.X = _ctx.FloatValue("PullActionData.Actions["+ i +"].PointInMap.X");
				pointInMap.Y = _ctx.FloatValue("PullActionData.Actions["+ i +"].PointInMap.Y");
				action.PointInMap = pointInMap;

				pullActionDataResponse_actions.Add(action);
			}
			pullActionDataResponse.Actions = pullActionDataResponse_actions;
        
			return pullActionDataResponse;
        }
    }
}
