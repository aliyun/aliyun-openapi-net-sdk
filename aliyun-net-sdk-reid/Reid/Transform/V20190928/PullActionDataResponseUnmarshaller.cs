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
    public class PullActionDataResponseUnmarshaller
    {
        public static PullActionDataResponse Unmarshall(UnmarshallerContext context)
        {
			PullActionDataResponse pullActionDataResponse = new PullActionDataResponse();

			pullActionDataResponse.HttpResponse = context.HttpResponse;
			pullActionDataResponse.ErrorCode = context.StringValue("PullActionData.ErrorCode");
			pullActionDataResponse.ErrorMessage = context.StringValue("PullActionData.ErrorMessage");
			pullActionDataResponse.Message = context.StringValue("PullActionData.Message");
			pullActionDataResponse.Code = context.StringValue("PullActionData.Code");
			pullActionDataResponse.PartitionIndex = context.IntegerValue("PullActionData.PartitionIndex");
			pullActionDataResponse.DynamicCode = context.StringValue("PullActionData.DynamicCode");
			pullActionDataResponse.RequestId = context.StringValue("PullActionData.RequestId");
			pullActionDataResponse.Success = context.BooleanValue("PullActionData.Success");
			pullActionDataResponse.NextMessageId = context.LongValue("PullActionData.NextMessageId");
			pullActionDataResponse.DynamicMessage = context.StringValue("PullActionData.DynamicMessage");

			List<PullActionDataResponse.PullActionData_Action> pullActionDataResponse_actions = new List<PullActionDataResponse.PullActionData_Action>();
			for (int i = 0; i < context.Length("PullActionData.Actions.Length"); i++) {
				PullActionDataResponse.PullActionData_Action action = new PullActionDataResponse.PullActionData_Action();
				action.StoreId = context.LongValue("PullActionData.Actions["+ i +"].StoreId");
				action.GmtCreate = context.LongValue("PullActionData.Actions["+ i +"].GmtCreate");
				action.LeaveTimestamp = context.LongValue("PullActionData.Actions["+ i +"].LeaveTimestamp");
				action.LocationLayerType = context.StringValue("PullActionData.Actions["+ i +"].LocationLayerType");
				action.StayValid = context.BooleanValue("PullActionData.Actions["+ i +"].StayValid");
				action.Gender = context.StringValue("PullActionData.Actions["+ i +"].Gender");
				action.UkId = context.LongValue("PullActionData.Actions["+ i +"].UkId");
				action.ArriveTimestamp = context.LongValue("PullActionData.Actions["+ i +"].ArriveTimestamp");
				action.GmtModified = context.LongValue("PullActionData.Actions["+ i +"].GmtModified");
				action.ImageType = context.StringValue("PullActionData.Actions["+ i +"].ImageType");
				action.InStay = context.LongValue("PullActionData.Actions["+ i +"].InStay");
				action.Status = context.IntegerValue("PullActionData.Actions["+ i +"].Status");
				action.Age = context.IntegerValue("PullActionData.Actions["+ i +"].Age");
				action.Id = context.LongValue("PullActionData.Actions["+ i +"].Id");
				action.ImageUrl = context.StringValue("PullActionData.Actions["+ i +"].ImageUrl");
				action.LocationId = context.LongValue("PullActionData.Actions["+ i +"].LocationId");
				action.StayPeriod = context.IntegerValue("PullActionData.Actions["+ i +"].StayPeriod");
				action.FacePointNumber = context.IntegerValue("PullActionData.Actions["+ i +"].FacePointNumber");
				action.Score = context.FloatValue("PullActionData.Actions["+ i +"].Score");
				action.SpecialType = context.StringValue("PullActionData.Actions["+ i +"].SpecialType");
				action.ImageObjectKey = context.StringValue("PullActionData.Actions["+ i +"].ImageObjectKey");
				action.BodyPointNumber = context.IntegerValue("PullActionData.Actions["+ i +"].BodyPointNumber");

				PullActionDataResponse.PullActionData_Action.PullActionData_ObjectPositionInImage objectPositionInImage = new PullActionDataResponse.PullActionData_Action.PullActionData_ObjectPositionInImage();
				objectPositionInImage.Bottom = context.FloatValue("PullActionData.Actions["+ i +"].ObjectPositionInImage.Bottom");
				objectPositionInImage.Left = context.FloatValue("PullActionData.Actions["+ i +"].ObjectPositionInImage.Left");
				objectPositionInImage.Top = context.FloatValue("PullActionData.Actions["+ i +"].ObjectPositionInImage.Top");
				objectPositionInImage.Right = context.FloatValue("PullActionData.Actions["+ i +"].ObjectPositionInImage.Right");
				action.ObjectPositionInImage = objectPositionInImage;

				PullActionDataResponse.PullActionData_Action.PullActionData_PointInMap pointInMap = new PullActionDataResponse.PullActionData_Action.PullActionData_PointInMap();
				pointInMap.X = context.FloatValue("PullActionData.Actions["+ i +"].PointInMap.X");
				pointInMap.Y = context.FloatValue("PullActionData.Actions["+ i +"].PointInMap.Y");
				action.PointInMap = pointInMap;

				pullActionDataResponse_actions.Add(action);
			}
			pullActionDataResponse.Actions = pullActionDataResponse_actions;
        
			return pullActionDataResponse;
        }
    }
}
