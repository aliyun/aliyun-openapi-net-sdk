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
using Aliyun.Acs.cusanalytic_sc_online.Model.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524
{
    public class DescribeActionDataResponseUnmarshaller
    {
        public static DescribeActionDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeActionDataResponse describeActionDataResponse = new DescribeActionDataResponse();

			describeActionDataResponse.HttpResponse = context.HttpResponse;
			describeActionDataResponse.PageNo = context.IntegerValue("DescribeActionData.PageNo");
			describeActionDataResponse.TsStart = context.LongValue("DescribeActionData.TsStart");
			describeActionDataResponse.PageLimit = context.IntegerValue("DescribeActionData.PageLimit");
			describeActionDataResponse.PageCount = context.IntegerValue("DescribeActionData.PageCount");
			describeActionDataResponse.IsSuccess = context.BooleanValue("DescribeActionData.IsSuccess");
			describeActionDataResponse.ErrorMsg = context.StringValue("DescribeActionData.ErrorMsg");
			describeActionDataResponse.StoreId = context.StringValue("DescribeActionData.StoreId");
			describeActionDataResponse.TsEnd = context.LongValue("DescribeActionData.TsEnd");

			List<DescribeActionDataResponse.DescribeActionData_ActionsMsgItem> describeActionDataResponse_actionsMsgItems = new List<DescribeActionDataResponse.DescribeActionData_ActionsMsgItem>();
			for (int i = 0; i < context.Length("DescribeActionData.ActionsMsgItems.Length"); i++) {
				DescribeActionDataResponse.DescribeActionData_ActionsMsgItem actionsMsgItem = new DescribeActionDataResponse.DescribeActionData_ActionsMsgItem();
				actionsMsgItem.LocationId = context.LongValue("DescribeActionData.ActionsMsgItems["+ i +"].LocationId");
				actionsMsgItem.UkId = context.LongValue("DescribeActionData.ActionsMsgItems["+ i +"].UkId");
				actionsMsgItem.GmtModified = context.StringValue("DescribeActionData.ActionsMsgItems["+ i +"].GmtModified");
				actionsMsgItem.Status = context.LongValue("DescribeActionData.ActionsMsgItems["+ i +"].Status");
				actionsMsgItem.GmtCreate = context.StringValue("DescribeActionData.ActionsMsgItems["+ i +"].GmtCreate");
				actionsMsgItem.StoreId = context.LongValue("DescribeActionData.ActionsMsgItems["+ i +"].StoreId");
				actionsMsgItem.Tag = context.StringValue("DescribeActionData.ActionsMsgItems["+ i +"].Tag");
				actionsMsgItem.Id = context.LongValue("DescribeActionData.ActionsMsgItems["+ i +"].Id");
				actionsMsgItem.LocationLayerType = context.StringValue("DescribeActionData.ActionsMsgItems["+ i +"].LocationLayerType");

				DescribeActionDataResponse.DescribeActionData_ActionsMsgItem.DescribeActionData_ActionInfosItem actionInfosItem = new DescribeActionDataResponse.DescribeActionData_ActionsMsgItem.DescribeActionData_ActionInfosItem();
				actionInfosItem.Maxts = context.LongValue("DescribeActionData.ActionsMsgItems["+ i +"].ActionInfosItem.Maxts");
				actionInfosItem.StayValid = context.LongValue("DescribeActionData.ActionsMsgItems["+ i +"].ActionInfosItem.StayValid");
				actionInfosItem.StayPeriod = context.LongValue("DescribeActionData.ActionsMsgItems["+ i +"].ActionInfosItem.StayPeriod");
				actionInfosItem.RawId = context.LongValue("DescribeActionData.ActionsMsgItems["+ i +"].ActionInfosItem.RawId");
				actionInfosItem.Mints = context.LongValue("DescribeActionData.ActionsMsgItems["+ i +"].ActionInfosItem.Mints");
				actionInfosItem.InStay = context.LongValue("DescribeActionData.ActionsMsgItems["+ i +"].ActionInfosItem.InStay");

				DescribeActionDataResponse.DescribeActionData_ActionsMsgItem.DescribeActionData_ActionInfosItem.DescribeActionData_MapImagePoint mapImagePoint = new DescribeActionDataResponse.DescribeActionData_ActionsMsgItem.DescribeActionData_ActionInfosItem.DescribeActionData_MapImagePoint();
				mapImagePoint.X = context.FloatValue("DescribeActionData.ActionsMsgItems["+ i +"].ActionInfosItem.MapImagePoint.X");
				mapImagePoint.Y = context.FloatValue("DescribeActionData.ActionsMsgItems["+ i +"].ActionInfosItem.MapImagePoint.Y");
				actionInfosItem.MapImagePoint = mapImagePoint;

				DescribeActionDataResponse.DescribeActionData_ActionsMsgItem.DescribeActionData_ActionInfosItem.DescribeActionData_FaceImgRect faceImgRect = new DescribeActionDataResponse.DescribeActionData_ActionsMsgItem.DescribeActionData_ActionInfosItem.DescribeActionData_FaceImgRect();
				faceImgRect.Bottom = context.FloatValue("DescribeActionData.ActionsMsgItems["+ i +"].ActionInfosItem.FaceImgRect.Bottom");
				faceImgRect.Left = context.FloatValue("DescribeActionData.ActionsMsgItems["+ i +"].ActionInfosItem.FaceImgRect.Left");
				faceImgRect.Top = context.FloatValue("DescribeActionData.ActionsMsgItems["+ i +"].ActionInfosItem.FaceImgRect.Top");
				faceImgRect.Right = context.FloatValue("DescribeActionData.ActionsMsgItems["+ i +"].ActionInfosItem.FaceImgRect.Right");
				actionInfosItem.FaceImgRect = faceImgRect;
				actionsMsgItem.ActionInfosItem = actionInfosItem;

				DescribeActionDataResponse.DescribeActionData_ActionsMsgItem.DescribeActionData_AttributesMsgItem attributesMsgItem = new DescribeActionDataResponse.DescribeActionData_ActionsMsgItem.DescribeActionData_AttributesMsgItem();
				attributesMsgItem.ImgUrl = context.StringValue("DescribeActionData.ActionsMsgItems["+ i +"].AttributesMsgItem.ImgUrl");
				attributesMsgItem.Score = context.LongValue("DescribeActionData.ActionsMsgItems["+ i +"].AttributesMsgItem.Score");
				attributesMsgItem.Gender = context.StringValue("DescribeActionData.ActionsMsgItems["+ i +"].AttributesMsgItem.Gender");
				attributesMsgItem.IsClerk = context.LongValue("DescribeActionData.ActionsMsgItems["+ i +"].AttributesMsgItem.IsClerk");
				attributesMsgItem.AgeNum = context.IntegerValue("DescribeActionData.ActionsMsgItems["+ i +"].AttributesMsgItem.AgeNum");
				attributesMsgItem.ImgObjectKey = context.StringValue("DescribeActionData.ActionsMsgItems["+ i +"].AttributesMsgItem.ImgObjectKey");
				attributesMsgItem.ImgType = context.StringValue("DescribeActionData.ActionsMsgItems["+ i +"].AttributesMsgItem.ImgType");
				actionsMsgItem.AttributesMsgItem = attributesMsgItem;

				describeActionDataResponse_actionsMsgItems.Add(actionsMsgItem);
			}
			describeActionDataResponse.ActionsMsgItems = describeActionDataResponse_actionsMsgItems;
        
			return describeActionDataResponse;
        }
    }
}
