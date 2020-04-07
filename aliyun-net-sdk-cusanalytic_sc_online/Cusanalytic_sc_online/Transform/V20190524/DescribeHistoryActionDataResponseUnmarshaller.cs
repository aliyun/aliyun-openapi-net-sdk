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
    public class DescribeHistoryActionDataResponseUnmarshaller
    {
        public static DescribeHistoryActionDataResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeHistoryActionDataResponse describeHistoryActionDataResponse = new DescribeHistoryActionDataResponse();

			describeHistoryActionDataResponse.HttpResponse = context.HttpResponse;
			describeHistoryActionDataResponse.PageNo = context.IntegerValue("DescribeHistoryActionData.PageNo");
			describeHistoryActionDataResponse.TsStart = context.LongValue("DescribeHistoryActionData.TsStart");
			describeHistoryActionDataResponse.PageLimit = context.IntegerValue("DescribeHistoryActionData.PageLimit");
			describeHistoryActionDataResponse.PageCount = context.IntegerValue("DescribeHistoryActionData.PageCount");
			describeHistoryActionDataResponse.IsSuccess = context.BooleanValue("DescribeHistoryActionData.IsSuccess");
			describeHistoryActionDataResponse.ErrorMsg = context.StringValue("DescribeHistoryActionData.ErrorMsg");
			describeHistoryActionDataResponse.StoreId = context.StringValue("DescribeHistoryActionData.StoreId");
			describeHistoryActionDataResponse.TotalCount = context.LongValue("DescribeHistoryActionData.TotalCount");
			describeHistoryActionDataResponse.TsEnd = context.LongValue("DescribeHistoryActionData.TsEnd");

			List<DescribeHistoryActionDataResponse.DescribeHistoryActionData_ActionsMsgItem> describeHistoryActionDataResponse_actionsMsgItems = new List<DescribeHistoryActionDataResponse.DescribeHistoryActionData_ActionsMsgItem>();
			for (int i = 0; i < context.Length("DescribeHistoryActionData.ActionsMsgItems.Length"); i++) {
				DescribeHistoryActionDataResponse.DescribeHistoryActionData_ActionsMsgItem actionsMsgItem = new DescribeHistoryActionDataResponse.DescribeHistoryActionData_ActionsMsgItem();
				actionsMsgItem.LocationId = context.LongValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].LocationId");
				actionsMsgItem.UkId = context.LongValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].UkId");
				actionsMsgItem.GmtModified = context.StringValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].GmtModified");
				actionsMsgItem.Status = context.LongValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Status");
				actionsMsgItem.GmtCreate = context.StringValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].GmtCreate");
				actionsMsgItem.StoreId = context.LongValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].StoreId");
				actionsMsgItem.Tag = context.StringValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Tag");
				actionsMsgItem.Id = context.LongValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Id");
				actionsMsgItem.LocationLayerType = context.StringValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].LocationLayerType");

				DescribeHistoryActionDataResponse.DescribeHistoryActionData_ActionsMsgItem.DescribeHistoryActionData_Infos infos = new DescribeHistoryActionDataResponse.DescribeHistoryActionData_ActionsMsgItem.DescribeHistoryActionData_Infos();
				infos.InStay = context.LongValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Infos.InStay");
				infos.Maxts = context.LongValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Infos.Maxts");
				infos.StayValid = context.LongValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Infos.StayValid");
				infos.StayPeriod = context.LongValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Infos.StayPeriod");
				infos.RawId = context.LongValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Infos.RawId");
				infos.Mints = context.LongValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Infos.Mints");

				DescribeHistoryActionDataResponse.DescribeHistoryActionData_ActionsMsgItem.DescribeHistoryActionData_Infos.DescribeHistoryActionData_MapImagePoint mapImagePoint = new DescribeHistoryActionDataResponse.DescribeHistoryActionData_ActionsMsgItem.DescribeHistoryActionData_Infos.DescribeHistoryActionData_MapImagePoint();
				mapImagePoint.X = context.FloatValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Infos.MapImagePoint.X");
				mapImagePoint.Y = context.FloatValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Infos.MapImagePoint.Y");
				infos.MapImagePoint = mapImagePoint;

				DescribeHistoryActionDataResponse.DescribeHistoryActionData_ActionsMsgItem.DescribeHistoryActionData_Infos.DescribeHistoryActionData_FaceImgRect faceImgRect = new DescribeHistoryActionDataResponse.DescribeHistoryActionData_ActionsMsgItem.DescribeHistoryActionData_Infos.DescribeHistoryActionData_FaceImgRect();
				faceImgRect.Bottom = context.FloatValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Infos.FaceImgRect.Bottom");
				faceImgRect.Left = context.FloatValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Infos.FaceImgRect.Left");
				faceImgRect.Top = context.FloatValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Infos.FaceImgRect.Top");
				faceImgRect.Right = context.FloatValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Infos.FaceImgRect.Right");
				infos.FaceImgRect = faceImgRect;
				actionsMsgItem.Infos = infos;

				DescribeHistoryActionDataResponse.DescribeHistoryActionData_ActionsMsgItem.DescribeHistoryActionData_Attributes attributes = new DescribeHistoryActionDataResponse.DescribeHistoryActionData_ActionsMsgItem.DescribeHistoryActionData_Attributes();
				attributes.ImgUrl = context.StringValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Attributes.ImgUrl");
				attributes.Score = context.LongValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Attributes.Score");
				attributes.Gender = context.StringValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Attributes.Gender");
				attributes.IsClerk = context.LongValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Attributes.IsClerk");
				attributes.AgeNum = context.IntegerValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Attributes.AgeNum");
				attributes.ImgObjectKey = context.StringValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Attributes.ImgObjectKey");
				attributes.ImgType = context.StringValue("DescribeHistoryActionData.ActionsMsgItems["+ i +"].Attributes.ImgType");
				actionsMsgItem.Attributes = attributes;

				describeHistoryActionDataResponse_actionsMsgItems.Add(actionsMsgItem);
			}
			describeHistoryActionDataResponse.ActionsMsgItems = describeHistoryActionDataResponse_actionsMsgItems;
        
			return describeHistoryActionDataResponse;
        }
    }
}
