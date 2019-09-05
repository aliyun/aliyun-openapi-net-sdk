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
    public class DescribeLocationsResponseUnmarshaller
    {
        public static DescribeLocationsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeLocationsResponse describeLocationsResponse = new DescribeLocationsResponse();

			describeLocationsResponse.HttpResponse = context.HttpResponse;
			describeLocationsResponse.StoreId = context.StringValue("DescribeLocations.StoreId");

			List<DescribeLocationsResponse.DescribeLocations_LocationMsgItem> describeLocationsResponse_locationMsgItems = new List<DescribeLocationsResponse.DescribeLocations_LocationMsgItem>();
			for (int i = 0; i < context.Length("DescribeLocations.LocationMsgItems.Length"); i++) {
				DescribeLocationsResponse.DescribeLocations_LocationMsgItem locationMsgItem = new DescribeLocationsResponse.DescribeLocations_LocationMsgItem();
				locationMsgItem.Tag = context.StringValue("DescribeLocations.LocationMsgItems["+ i +"].Tag");
				locationMsgItem.Id = context.LongValue("DescribeLocations.LocationMsgItems["+ i +"].Id");
				locationMsgItem.ExtId = context.StringValue("DescribeLocations.LocationMsgItems["+ i +"].ExtId");
				locationMsgItem.LocationType = context.StringValue("DescribeLocations.LocationMsgItems["+ i +"].LocationType");
				locationMsgItem.Name = context.StringValue("DescribeLocations.LocationMsgItems["+ i +"].Name");
				locationMsgItem.Status = context.LongValue("DescribeLocations.LocationMsgItems["+ i +"].Status");
				locationMsgItem.GmtCreate = context.StringValue("DescribeLocations.LocationMsgItems["+ i +"].GmtCreate");
				locationMsgItem.StoreId = context.LongValue("DescribeLocations.LocationMsgItems["+ i +"].StoreId");
				locationMsgItem.GmtModified = context.StringValue("DescribeLocations.LocationMsgItems["+ i +"].GmtModified");
				locationMsgItem.ParentLocationId = context.LongValue("DescribeLocations.LocationMsgItems["+ i +"].ParentLocationId");
				locationMsgItem.LayerType = context.StringValue("DescribeLocations.LocationMsgItems["+ i +"].LayerType");

				List<DescribeLocationsResponse.DescribeLocations_LocationMsgItem.DescribeLocations_RectRoi> locationMsgItem_rectRois = new List<DescribeLocationsResponse.DescribeLocations_LocationMsgItem.DescribeLocations_RectRoi>();
				for (int j = 0; j < context.Length("DescribeLocations.LocationMsgItems["+ i +"].RectRois.Length"); j++) {
					DescribeLocationsResponse.DescribeLocations_LocationMsgItem.DescribeLocations_RectRoi rectRoi = new DescribeLocationsResponse.DescribeLocations_LocationMsgItem.DescribeLocations_RectRoi();

					DescribeLocationsResponse.DescribeLocations_LocationMsgItem.DescribeLocations_RectRoi.DescribeLocations_LeftTop leftTop = new DescribeLocationsResponse.DescribeLocations_LocationMsgItem.DescribeLocations_RectRoi.DescribeLocations_LeftTop();
					leftTop.X = context.FloatValue("DescribeLocations.LocationMsgItems["+ i +"].RectRois["+ j +"].LeftTop.X");
					leftTop.Y = context.FloatValue("DescribeLocations.LocationMsgItems["+ i +"].RectRois["+ j +"].LeftTop.Y");
					rectRoi.LeftTop = leftTop;

					DescribeLocationsResponse.DescribeLocations_LocationMsgItem.DescribeLocations_RectRoi.DescribeLocations_RightBottom rightBottom = new DescribeLocationsResponse.DescribeLocations_LocationMsgItem.DescribeLocations_RectRoi.DescribeLocations_RightBottom();
					rightBottom.X = context.FloatValue("DescribeLocations.LocationMsgItems["+ i +"].RectRois["+ j +"].RightBottom.X");
					rightBottom.Y = context.FloatValue("DescribeLocations.LocationMsgItems["+ i +"].RectRois["+ j +"].RightBottom.Y");
					rectRoi.RightBottom = rightBottom;

					List<DescribeLocationsResponse.DescribeLocations_LocationMsgItem.DescribeLocations_RectRoi.DescribeLocations_Point> rectRoi_points = new List<DescribeLocationsResponse.DescribeLocations_LocationMsgItem.DescribeLocations_RectRoi.DescribeLocations_Point>();
					for (int k = 0; k < context.Length("DescribeLocations.LocationMsgItems["+ i +"].RectRois["+ j +"].Points.Length"); k++) {
						DescribeLocationsResponse.DescribeLocations_LocationMsgItem.DescribeLocations_RectRoi.DescribeLocations_Point point = new DescribeLocationsResponse.DescribeLocations_LocationMsgItem.DescribeLocations_RectRoi.DescribeLocations_Point();
						point.X = context.FloatValue("DescribeLocations.LocationMsgItems["+ i +"].RectRois["+ j +"].Points["+ k +"].X");
						point.Y = context.FloatValue("DescribeLocations.LocationMsgItems["+ i +"].RectRois["+ j +"].Points["+ k +"].Y");

						rectRoi_points.Add(point);
					}
					rectRoi.Points = rectRoi_points;

					locationMsgItem_rectRois.Add(rectRoi);
				}
				locationMsgItem.RectRois = locationMsgItem_rectRois;

				describeLocationsResponse_locationMsgItems.Add(locationMsgItem);
			}
			describeLocationsResponse.LocationMsgItems = describeLocationsResponse_locationMsgItems;
        
			return describeLocationsResponse;
        }
    }
}
