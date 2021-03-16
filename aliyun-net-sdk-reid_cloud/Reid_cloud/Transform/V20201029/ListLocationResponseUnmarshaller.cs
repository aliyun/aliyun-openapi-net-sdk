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
    public class ListLocationResponseUnmarshaller
    {
        public static ListLocationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListLocationResponse listLocationResponse = new ListLocationResponse();

			listLocationResponse.HttpResponse = _ctx.HttpResponse;
			listLocationResponse.ErrorCode = _ctx.StringValue("ListLocation.ErrorCode");
			listLocationResponse.ErrorMessage = _ctx.StringValue("ListLocation.ErrorMessage");
			listLocationResponse.Message = _ctx.StringValue("ListLocation.Message");
			listLocationResponse.Code = _ctx.StringValue("ListLocation.Code");
			listLocationResponse.DynamicCode = _ctx.StringValue("ListLocation.DynamicCode");
			listLocationResponse.RequestId = _ctx.StringValue("ListLocation.RequestId");
			listLocationResponse.Success = _ctx.BooleanValue("ListLocation.Success");
			listLocationResponse.DynamicMessage = _ctx.StringValue("ListLocation.DynamicMessage");

			List<ListLocationResponse.ListLocation_LocationInfoItem> listLocationResponse_locationInfoItems = new List<ListLocationResponse.ListLocation_LocationInfoItem>();
			for (int i = 0; i < _ctx.Length("ListLocation.LocationInfoItems.Length"); i++) {
				ListLocationResponse.ListLocation_LocationInfoItem locationInfoItem = new ListLocationResponse.ListLocation_LocationInfoItem();
				locationInfoItem.ExternalId = _ctx.StringValue("ListLocation.LocationInfoItems["+ i +"].ExternalId");
				locationInfoItem.LocationType = _ctx.StringValue("ListLocation.LocationInfoItems["+ i +"].LocationType");
				locationInfoItem.Status = _ctx.IntegerValue("ListLocation.LocationInfoItems["+ i +"].Status");
				locationInfoItem.StoreId = _ctx.LongValue("ListLocation.LocationInfoItems["+ i +"].StoreId");
				locationInfoItem.GmtCreate = _ctx.LongValue("ListLocation.LocationInfoItems["+ i +"].GmtCreate");
				locationInfoItem.ParentLocationId = _ctx.LongValue("ListLocation.LocationInfoItems["+ i +"].ParentLocationId");
				locationInfoItem.GmtModified = _ctx.LongValue("ListLocation.LocationInfoItems["+ i +"].GmtModified");
				locationInfoItem.LocationName = _ctx.StringValue("ListLocation.LocationInfoItems["+ i +"].LocationName");
				locationInfoItem.LayerType = _ctx.StringValue("ListLocation.LocationInfoItems["+ i +"].LayerType");
				locationInfoItem.LocationId = _ctx.LongValue("ListLocation.LocationInfoItems["+ i +"].LocationId");

				List<ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi> locationInfoItem_rectRois = new List<ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi>();
				for (int j = 0; j < _ctx.Length("ListLocation.LocationInfoItems["+ i +"].RectRois.Length"); j++) {
					ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi rectRoi = new ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi();

					ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi.ListLocation_RightBottom rightBottom = new ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi.ListLocation_RightBottom();
					rightBottom.X = _ctx.FloatValue("ListLocation.LocationInfoItems["+ i +"].RectRois["+ j +"].RightBottom.X");
					rightBottom.Y = _ctx.FloatValue("ListLocation.LocationInfoItems["+ i +"].RectRois["+ j +"].RightBottom.Y");
					rectRoi.RightBottom = rightBottom;

					ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi.ListLocation_LeftTop leftTop = new ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi.ListLocation_LeftTop();
					leftTop.X = _ctx.FloatValue("ListLocation.LocationInfoItems["+ i +"].RectRois["+ j +"].LeftTop.X");
					leftTop.Y = _ctx.FloatValue("ListLocation.LocationInfoItems["+ i +"].RectRois["+ j +"].LeftTop.Y");
					rectRoi.LeftTop = leftTop;

					List<ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi.ListLocation_Point> rectRoi_points = new List<ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi.ListLocation_Point>();
					for (int k = 0; k < _ctx.Length("ListLocation.LocationInfoItems["+ i +"].RectRois["+ j +"].Points.Length"); k++) {
						ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi.ListLocation_Point point = new ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi.ListLocation_Point();
						point.X = _ctx.FloatValue("ListLocation.LocationInfoItems["+ i +"].RectRois["+ j +"].Points["+ k +"].X");
						point.Y = _ctx.FloatValue("ListLocation.LocationInfoItems["+ i +"].RectRois["+ j +"].Points["+ k +"].Y");

						rectRoi_points.Add(point);
					}
					rectRoi.Points = rectRoi_points;

					locationInfoItem_rectRois.Add(rectRoi);
				}
				locationInfoItem.RectRois = locationInfoItem_rectRois;

				listLocationResponse_locationInfoItems.Add(locationInfoItem);
			}
			listLocationResponse.LocationInfoItems = listLocationResponse_locationInfoItems;
        
			return listLocationResponse;
        }
    }
}
