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
    public class ListLocationResponseUnmarshaller
    {
        public static ListLocationResponse Unmarshall(UnmarshallerContext context)
        {
			ListLocationResponse listLocationResponse = new ListLocationResponse();

			listLocationResponse.HttpResponse = context.HttpResponse;
			listLocationResponse.ErrorCode = context.StringValue("ListLocation.ErrorCode");
			listLocationResponse.ErrorMessage = context.StringValue("ListLocation.ErrorMessage");
			listLocationResponse.RequestId = context.StringValue("ListLocation.RequestId");
			listLocationResponse.Success = context.BooleanValue("ListLocation.Success");

			List<ListLocationResponse.ListLocation_LocationInfoItem> listLocationResponse_locationInfoItems = new List<ListLocationResponse.ListLocation_LocationInfoItem>();
			for (int i = 0; i < context.Length("ListLocation.LocationInfoItems.Length"); i++) {
				ListLocationResponse.ListLocation_LocationInfoItem locationInfoItem = new ListLocationResponse.ListLocation_LocationInfoItem();
				locationInfoItem.ExternalId = context.StringValue("ListLocation.LocationInfoItems["+ i +"].ExternalId");
				locationInfoItem.LocationType = context.StringValue("ListLocation.LocationInfoItems["+ i +"].LocationType");
				locationInfoItem.Status = context.IntegerValue("ListLocation.LocationInfoItems["+ i +"].Status");
				locationInfoItem.StoreId = context.LongValue("ListLocation.LocationInfoItems["+ i +"].StoreId");
				locationInfoItem.GmtCreate = context.LongValue("ListLocation.LocationInfoItems["+ i +"].GmtCreate");
				locationInfoItem.ParentLocationId = context.LongValue("ListLocation.LocationInfoItems["+ i +"].ParentLocationId");
				locationInfoItem.GmtModified = context.LongValue("ListLocation.LocationInfoItems["+ i +"].GmtModified");
				locationInfoItem.LocationName = context.StringValue("ListLocation.LocationInfoItems["+ i +"].LocationName");
				locationInfoItem.LayerType = context.StringValue("ListLocation.LocationInfoItems["+ i +"].LayerType");
				locationInfoItem.LocationId = context.LongValue("ListLocation.LocationInfoItems["+ i +"].LocationId");

				List<ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi> locationInfoItem_rectRois = new List<ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi>();
				for (int j = 0; j < context.Length("ListLocation.LocationInfoItems["+ i +"].RectRois.Length"); j++) {
					ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi rectRoi = new ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi();

					List<ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi.ListLocation_Point> rectRoi_points = new List<ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi.ListLocation_Point>();
					for (int k = 0; k < context.Length("ListLocation.LocationInfoItems["+ i +"].RectRois["+ j +"].Points.Length"); k++) {
						ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi.ListLocation_Point point = new ListLocationResponse.ListLocation_LocationInfoItem.ListLocation_RectRoi.ListLocation_Point();
						point.X = context.FloatValue("ListLocation.LocationInfoItems["+ i +"].RectRois["+ j +"].Points["+ k +"].X");
						point.Y = context.FloatValue("ListLocation.LocationInfoItems["+ i +"].RectRois["+ j +"].Points["+ k +"].Y");

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
