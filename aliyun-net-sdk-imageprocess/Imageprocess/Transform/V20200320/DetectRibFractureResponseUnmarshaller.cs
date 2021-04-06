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
using Aliyun.Acs.imageprocess.Model.V20200320;

namespace Aliyun.Acs.imageprocess.Transform.V20200320
{
    public class DetectRibFractureResponseUnmarshaller
    {
        public static DetectRibFractureResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DetectRibFractureResponse detectRibFractureResponse = new DetectRibFractureResponse();

			detectRibFractureResponse.HttpResponse = _ctx.HttpResponse;
			detectRibFractureResponse.RequestId = _ctx.StringValue("DetectRibFracture.RequestId");

			DetectRibFractureResponse.DetectRibFracture_Data data = new DetectRibFractureResponse.DetectRibFracture_Data();
			data.ResultURL = _ctx.StringValue("DetectRibFracture.Data.ResultURL");

			List<string> data_origin = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectRibFracture.Data.Origin.Length"); i++) {
				data_origin.Add(_ctx.StringValue("DetectRibFracture.Data.Origin["+ i +"]"));
			}
			data.Origin = data_origin;

			List<string> data_spacing = new List<string>();
			for (int i = 0; i < _ctx.Length("DetectRibFracture.Data.Spacing.Length"); i++) {
				data_spacing.Add(_ctx.StringValue("DetectRibFracture.Data.Spacing["+ i +"]"));
			}
			data.Spacing = data_spacing;

			List<DetectRibFractureResponse.DetectRibFracture_Data.DetectRibFracture_DetectionsItem> data_detections = new List<DetectRibFractureResponse.DetectRibFracture_Data.DetectRibFracture_DetectionsItem>();
			for (int i = 0; i < _ctx.Length("DetectRibFracture.Data.Detections.Length"); i++) {
				DetectRibFractureResponse.DetectRibFracture_Data.DetectRibFracture_DetectionsItem detectionsItem = new DetectRibFractureResponse.DetectRibFracture_Data.DetectRibFracture_DetectionsItem();
				detectionsItem.FractureCategory = _ctx.StringValue("DetectRibFracture.Data.Detections["+ i +"].FractureCategory");
				detectionsItem.FractureConfidence = _ctx.FloatValue("DetectRibFracture.Data.Detections["+ i +"].FractureConfidence");
				detectionsItem.FractureLocation = _ctx.StringValue("DetectRibFracture.Data.Detections["+ i +"].FractureLocation");
				detectionsItem.FractureSegment = _ctx.LongValue("DetectRibFracture.Data.Detections["+ i +"].FractureSegment");
				detectionsItem.FractureId = _ctx.IntegerValue("DetectRibFracture.Data.Detections["+ i +"].FractureId");

				List<string> detectionsItem_coordinateImage = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectRibFracture.Data.Detections["+ i +"].CoordinateImage.Length"); j++) {
					detectionsItem_coordinateImage.Add(_ctx.StringValue("DetectRibFracture.Data.Detections["+ i +"].CoordinateImage["+ j +"]"));
				}
				detectionsItem.CoordinateImage = detectionsItem_coordinateImage;

				List<string> detectionsItem_coordinates = new List<string>();
				for (int j = 0; j < _ctx.Length("DetectRibFracture.Data.Detections["+ i +"].Coordinates.Length"); j++) {
					detectionsItem_coordinates.Add(_ctx.StringValue("DetectRibFracture.Data.Detections["+ i +"].Coordinates["+ j +"]"));
				}
				detectionsItem.Coordinates = detectionsItem_coordinates;

				data_detections.Add(detectionsItem);
			}
			data.Detections = data_detections;
			detectRibFractureResponse.Data = data;
        
			return detectRibFractureResponse;
        }
    }
}
